-- =============================================
-- Author:    Luis Ramon Valencia Aguayo
-- Create date: 26 de Mayo del 2022
-- Description: Creacion de la base de datos tienda virtual
-- =============================================

/*------------------------------------creacion de la base de la base de datos------------------------------------------*/
DROP DATABASE IF EXISTS tiendavirtual
GO
CREATE DATABASE tiendavirtual
GO
USE tiendavirtual
GO

DROP TABLE IF EXISTS codigos_postales;
CREATE TABLE codigos_postales (
  d_codigo varchar(255),
  d_asenta varchar(255),
  d_tipo_asenta varchar(255),
  d_mnpio varchar(255),
  d_estado varchar(255),
  d_ciudad varchar(255),
  d_CP varchar(255),
  c_estado varchar(255),
  c_oficina varchar(255),
  c_CP varchar(255),
  c_tipo_asenta varchar(255),
  c_mnpio varchar(255),
  id_asenta_cpcons varchar(255),
  d_zona varchar(255),
  c_cve_ciudad varchar(255),
  id int NOT NULL IDENTITY,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS categoria_producto;
CREATE TABLE categoria_producto (
  id INT IDENTITY,
  nombre varchar(200) NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS producto;
CREATE TABLE producto (
  id INT IDENTITY,
  nombre varchar(200) NOT NULL,
  descripcion varchar(400) NOT NULL,
  precioPorKilo VARCHAR(15) CHECK(precioPorKilo IN('true','false'))NOT NULL,
  img image,
  id_categoria INT NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS users;
CREATE TABLE users (
  id INT IDENTITY,
  name varchar(255) NOT NULL,
  email varchar(255) NOT NULL,
  email_verified_at timestamp NULL,
  password varchar(255) NOT NULL,
  img image,
  type varchar(100),
  api_token varchar(255),
  remember_token varchar(100),
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS almacen;
CREATE TABLE almacen (
  id INT IDENTITY,
  entrada INT NOT NULL DEFAULT 1,
  salida INT NOT NULL DEFAULT 0,
  stock INT NOT NULL,
  id_user INT NOT NULL,
  id_producto INT NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS cliente;
CREATE TABLE cliente (
  id INT IDENTITY,
  nombre varchar(100) NOT NULL,
  apellidos varchar(100) NOT NULL,
  telefono varchar(30) NOT NULL,
  img image,
  direccion varchar(200) NOT NULL,
  cp INT NOT NULL,
  colonia varchar(200) NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS promotor;
CREATE TABLE promotor (
  id INT IDENTITY,
  nombre varchar(200) NOT NULL,
  direccion varchar(200) NOT NULL,
  telefono varchar(100) NOT NULL,
  sitioWeb varchar(200) DEFAULT NULL,
  img image,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS compra;
CREATE TABLE compra (
  id INT IDENTITY,
  folio varchar(200) NOT NULL,
  cantidad_stock INT NOT NULL,
  precio_total decimal(10,4) NOT NULL,
  img image,
  id_almacen INT NOT NULL,
  id_promotor INT NOT NULL,
  id_producto INT NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS productoprecio;
CREATE TABLE productoprecio (
  id INT IDENTITY,
  precio decimal(10,2) NOT NULL,
  id_product INT NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS typepay;
CREATE TABLE typepay (
  id INT IDENTITY,
  name varchar(150) NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS venta;
CREATE TABLE venta (
  id INT IDENTITY,
  factura varchar(100) NOT NULL,
  impuesto decimal(10,2) NOT NULL,
  precio_total decimal(10,2) NOT NULL,
  id_pago INT NOT NULL,
  id_cliente INT NOT NULL,
  id_users INT NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS d_venta;
CREATE TABLE d_venta (
  id INT IDENTITY,
  id_venta INT NOT NULL,
  id_producto INT NOT NULL,
  cantidad INT NOT NULL,
  precio decimal(10,4) NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS cuentaporcobrar;
CREATE TABLE cuentaporcobrar (
  id INT IDENTITY,
  id_venta INT NOT NULL,
  id_cliente INT NOT NULL,
  precioTotal decimal(10,4) NOT NULL,
  pagos INT NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS d_cuentaporcobrar;
CREATE TABLE d_cuentaporcobrar (
  id INT IDENTITY,
  id_cuenta INT NOT NULL,
  precioabono decimal(10,4) NOT NULL,
  PRIMARY KEY (id)
)
GO

DROP TABLE IF EXISTS arqueocaja;
CREATE TABLE arqueocaja (
  id INT IDENTITY,
  apertura datetime NOT NULL,
  apertura_precio decimal(10,4) NOT NULL,
  cierre datetime DEFAULT NULL,
  cierre_precio decimal(10,4) NOT NULL,
  id_user INT NOT NULL,
  PRIMARY KEY (id)
)
GO

/*------------------------------------creacion de procedimientos almacenados------------------------------------------*/
  
  /*------sp categoroia de productos------*/
  DROP PROCEDURE IF EXISTS sp_categoria
  GO
  CREATE PROCEDURE sp_categoria @tipo CHAR(30), @id INT, @nombre VARCHAR(200) 
    AS
    BEGIN
      declare @categoriasexist INT;

      IF(@tipo = 'Obtener')
        BEGIN
          SELECT * FROM categoria_producto;
        END
      ELSE IF(@tipo = 'TextoBuscar')
        BEGIN
          SELECT * FROM categoria_producto  WHERE nombre LIKE '%' + @nombre + '%';
        END
      ELSE IF(@tipo = 'SELECTCATEGORIA')
        BEGIN
          SELECT 0 AS id, 'Seleccione una categoria' AS nombre
            UNION ALL
          SELECT * FROM categoria_producto
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN
          SET  @categoriasexist = (SELECT COUNT(*) FROM categoria_producto WHERE nombre = @nombre)

          IF(@categoriasexist < 1)
            BEGIN
              INSERT INTO categoria_producto(nombre) VALUES(@nombre);
              SELECT 'El registro fue insertaddo con exito';
            END
          ELSE
            BEGIN
              SELECT 'La categoria ya existe en la base de datos';
            END
        END
      ELSE IF(@tipo = 'Modificar')
        BEGIN
          SET  @categoriasexist = (SELECT COUNT(*) FROM categoria_producto WHERE nombre = @nombre)
          IF(@categoriasexist < 1)
              BEGIN
                UPDATE categoria_producto SET nombre = @nombre WHERE id = @id;
                SELECT 'El registro se update con exito';
              END
          ELSE
            BEGIN
              SELECT 'El registro de categoria ya existe en la base de datos';
            END
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM categoria_producto WHERE id = @id;
          SELECT 'El registro fue eliminado con exito';
        END
      END
  GO

  /*------sp producto------*/
  DROP PROCEDURE IF EXISTS sp_producto
  GO
  CREATE PROCEDURE sp_producto @tipo CHAR(30),@id INT,@nombre varchar(200),@descripcion varchar(400),@precioPorKilo CHAR(30),@img image,
                               @id_categoria INT
  
    AS
    BEGIN
      DECLARE @productoexist INT;
      DECLARE @idCategoria INT;

      IF(@tipo = 'Obtener')
        BEGIN
          SELECT p.id,p.nombre,p.descripcion,p.precioPorKilo,c.nombre as categoria FROM producto p JOIN categoria_producto c ON(p.id_categoria =  c.id)
        END
      ELSE IF(@tipo = 'TextoBuscar') 
        BEGIN
           SELECT p.id,p.nombre,p.descripcion,p.precioPorKilo,c.nombre as categoria FROM producto p JOIN categoria_producto c ON(p.id_categoria =  c.id) WHERE p.nombre LIKE '%' + @nombre + '%';
        END
      ELSE IF(@tipo = 'SELECTPRODUCT')
        BEGIN
          SELECT 0 AS id,'Seleccione un producto' AS nombre,'' AS descripcion,'' AS precioPorKilo,0 as id_categoria
            UNION ALL
          SELECT id,nombre,descripcion,precioPorKilo,id_categoria FROM producto;

        END
      ELSE IF(@tipo = 'Insertar') 
        BEGIN
          SET @productoexist = (SELECT COUNT(*) FROM producto WHERE nombre = @nombre)

          IF(@productoexist < 1)
            BEGIN
            SET @idCategoria = (SELECT COUNT(*) FROM categoria_producto WHERE id = @id_categoria)

            IF(@idCategoria != 0)
              BEGIN
                INSERT INTO producto(nombre,descripcion,precioPorKilo,img,id_categoria) VALUES(@nombre,@descripcion,@precioPorKilo,@img,@id_categoria)
                SELECT 'El registro fue insertado con exito';
              END
            ELSE
              BEGIN
                SELECT 'La categoria seleccionada no se encuentra en la base de datos';
              END
            END
          ELSE
            BEGIN
              SELECT 'El registro ya existe en la base de datos';
            END          
        END
      ELSE IF(@tipo = 'Modificar') 
        BEGIN
          SET @productoexist = (SELECT COUNT(*) FROM producto WHERE nombre = @nombre)
          IF(@productoexist < 1)
            BEGIN
            SET @idCategoria = (SELECT COUNT(*) FROM categoria_producto WHERE id = @id_categoria)

            IF(@idCategoria != 0)
              BEGIN
                UPDATE producto SET nombre = @nombre, descripcion = @descripcion, precioPorKilo = @precioPorKilo, img = @img, id_categoria = @id_categoria
                WHERE id=@id;

                SELECT 'El registro de producto fue modificado con exito';
              END
            ELSE
              BEGIN
                SELECT 'La categoria seleccionada no se encuentra en la base de datos';
              END
            END 
          ELSE
            BEGIN
              SELECT 'El registro de producto ya existe en la base de datos';
            END
        END
      ELSE IF(@tipo = 'DELETE') 
        BEGIN
          DELETE FROM producto WHERE id = @id;
          SELECT 'El registro fue eliminado con exito';
        END
      ELSE IF(@tipo = 'BuscarById')
        BEGIN
          SELECT p.id,p.nombre,p.descripcion,p.precioPorKilo,c.nombre as categoria,p.img, c.id as idcategoria FROM producto p JOIN categoria_producto c ON(p.id_categoria =  c.id) WHERE p.id = @id;
        END
    END     
  GO

  /*------sp users------*/
  DROP PROCEDURE IF EXISTS sp_users
  GO 
  CREATE PROCEDURE sp_users @tipo CHAR(30),@id INT,@name varchar(255),@email varchar(255),@password varchar(255),@img image,@type varchar(100),
                            @api_token varchar(255)
    AS
    BEGIN
      DECLARE @userexist INT, @passwordedit VARCHAR(100), @api_tokenedit VARCHAR(100);
      IF(@tipo = 'Obtener')
        BEGIN
          SELECT id,name,email,type,api_token FROM users;
        END
      ELSE IF(@tipo = 'TextoBuscar')
        BEGIN
          SELECT id,name,email,type,api_token FROM users WHERE name LIKE '%' + @name + '%';
        END  
      ELSE IF(@tipo = 'login')
        BEGIN
          SELECT * FROM users WHERE email = @email AND password = @password;
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN
          SET @userexist = (SELECT COUNT(*) FROM users WHERE email = @email);

          IF(@userexist < 1)
            BEGIN
              INSERT INTO users(name,email,password,img,type,api_token) VALUES(@name,@email,@password,@img,@type,@api_token);
              SELECT * FROM users WHERE email = @email; 
            END
          ELSE
            BEGIN
              SELECT 'El usuario ya existe en la base de datos';
            END
        END
      ELSE IF(@tipo = 'Modificar')
        BEGIN
          SET @userexist = (SELECT COUNT(*) FROM users WHERE email = @email);
          SET @passwordedit = (SELECT password FROM users WHERE id = @id);
          SET @api_tokenedit = (SELECT api_token FROM users WHERE id = @id);

          IF(@userexist < 2)
            BEGIN
              UPDATE users SET name = @name, 
                               email = @email, 
                               password = (CASE WHEN @password = '' THEN @passwordedit ELSE @password END), /*@password,*/ 
                               img = @img, 
                               type = @type, 
                               api_token = (CASE WHEN @api_token = '' THEN @api_tokenedit ELSE @api_token END) /*@api_token*/ 
              WHERE id = @id;
              SELECT 'El registro fue actualizado con exito';
            END
          ELSE
            BEGIN
              SELECT 'El usuario ya existe en la base de datos';
            END
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM users WHERE id = @id;
          SELECT 'El registro eliminado con exito';
        END
    END
  GO

  /*------sp almacen------*/
  DROP PROCEDURE IF EXISTS sp_almacen
  GO
  CREATE PROCEDURE sp_almacen @tipo CHAR(30),@id INT,@entrada INT,@salida INT,@stock INT,@id_user INT,@id_producto INT
    AS
    BEGIN
      DECLARE @existproductalmacen INT, @entradasIN INT, @salidasIN INT, @entradastotal INT, @salidastotal INT, @stocktotal INT;

      IF(@tipo = 'Obtener')
        BEGIN
          SELECT * FROM almacen;
        END
      ELSE IF(@tipo = 'ObtenerById')
        BEGIN
          SELECT * FROM almacen WHERE id_producto = @id_producto;
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN
          SET @existproductalmacen = (SELECT COUNT(*) FROM almacen WHERE id_producto = @id_producto);

          IF(@existproductalmacen > 0)
            BEGIN
              SET @entradasIN = (SELECT entrada FROM almacen WHERE id_producto = @id_producto);
              SET @salidasIN = (SELECT salida FROM almacen WHERE id_producto = @id_producto);

              SET @entradastotal = @entradasIN + @entrada;
              SET @salidastotal = @salidasIN + @salida;
              SET @stocktotal = @entradastotal - @salidastotal;              


              UPDATE almacen SET  entrada = @entradastotal, salida = @salidastotal, stock = @stocktotal, id_user = @id_user WHERE id_producto = @id_producto;

              SELECT 'El registro fue actualizado con exito'
            END
          ELSE
            BEGIN
              INSERT INTO almacen(entrada,salida,stock,id_producto,id_user) VALUES(@entrada,@salida,@stock,@id_producto,@id_user);

              SELECT 'El registro se inserto con exito';
            END

        END
      ELSE IF(@tipo = 'Modificar')
        BEGIN
          UPDATE almacen SET entrada = @entrada, salida = @salida, stock = @stock, id_user = @id_user WHERE id_producto = @id_producto;
          SELECT 'El registro de almacen fue actualizado con exito';
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM almacen WHERE id_producto = @id_producto;
        END
    END
  GO

  /*------sp cliente------*/
  DROP PROCEDURE IF EXISTS sp_cliente
  GO
  CREATE PROCEDURE sp_cliente @tipo CHAR(30), @id INT,@nombre varchar(100),@apellidos varchar(100),@telefono varchar(30),@img image,
                              @direccion varchar(200),@cp INT,@colonia varchar(200)
  
    AS
    BEGIN
      DECLARE @existcliente INT;

      IF(@tipo = 'Obtener')
        BEGIN
          SELECT id,nombre,apellidos,telefono,direccion,cp,colonia FROM cliente;
        END
      ELSE IF(@tipo = 'TextoBuscar')
        BEGIN
          SELECT id,nombre,apellidos,telefono,direccion,cp,colonia FROM cliente WHERE nombre LIKE '%' + @nombre + '%';
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN
          SET @existcliente = (SELECT COUNT(*) FROM cliente WHERE nombre = @nombre AND apellidos = @apellidos);

          IF(@existcliente < 1)
            BEGIN
              INSERT INTO cliente(nombre,apellidos,telefono,img,direccion,cp,colonia) VALUES(@nombre,@apellidos,@telefono,@img,@direccion,@cp,@colonia);
              SELECT 'El registro fue insertdo con exito';
            END
          ELSE
            BEGIN
              SELECT 'El registro ya existe en la base de datos';
            END
        END
      ELSE IF(@tipo = 'Modificar')
        BEGIN
          UPDATE cliente SET nombre = @nombre, apellidos = @apellidos, telefono = @telefono, img = @img, direccion = @direccion, cp = @cp, colonia = @colonia WHERE id = @id;
          SELECT 'El registro se actualizo con exito';
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM cliente WHERE id = @id;
        END
      ELSE IF(@tipo = 'SELECTCLIENT')
        BEGIN
          SELECT 0 as id, 'Seleccione un cliente' as nombre
            UNION ALL
          SELECT id,CONCAT_WS(' ',nombre,apellidos) as nombre FROM cliente;
        END
    END
  GO

  /*------sp promotor------*/
  DROP PROCEDURE IF EXISTS sp_promotor
  GO
  CREATE PROCEDURE sp_promotor @tipo CHAR(30),@id INT,@nombre varchar(200),@direccion varchar(200),@telefono varchar(100),@sitioWeb varchar(200), 
                               @img image
  
    AS
    BEGIN
      DECLARE @existpromotor INT;

      IF(@tipo = 'Obtener')
        BEGIN
          SELECT id,nombre,direccion,telefono,sitioWeb FROM promotor;
        END
      ELSE IF(@tipo = 'TextoBuscar')
        BEGIN
          SELECT id,nombre,direccion,telefono,sitioWeb FROM promotor WHERE nombre LIKE '%' + @nombre + '%';
        END
      ELSE IF(@tipo = 'SELECTPROMOTOR')
        BEGIN
          SELECT 0 AS id,'Seleccione una opcion' AS nombre,'' AS direccion,'' AS telefono,'' AS sitioWeb
            UNION ALL
          SELECT id,nombre,direccion,telefono,sitioWeb FROM promotor;
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN
          SET @existpromotor = (SELECT COUNT(*) FROM promotor WHERE nombre = @nombre);

          IF(@existpromotor < 1)
            BEGIN
              INSERT INTO promotor(nombre,direccion,telefono,sitioWeb,img) VALUES(@nombre,@direccion,@telefono,@sitioWeb,@img);
              SELECT 'Se inserto el registro con exito';
            END
          ELSE
            BEGIN
              SELECT 'El promotor ya existe en la base de datos';
            END
        END
      ELSE IF(@tipo = 'Modificar')
        BEGIN
          UPDATE promotor SET nombre = @nombre, direccion = @direccion, telefono = @telefono, sitioWeb = @sitioWeb, img = @img WHERE id = @id;
          SELECT 'El registro fue actualizado con exito';
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM promotor WHERE id = @id;
        END
    END  
  GO

  /*------sp compra------*/
  DROP PROCEDURE IF EXISTS sp_compra
  GO
  CREATE PROCEDURE sp_compra @tipo CHAR(30), @id INT,@folio varchar(200),@cantidad_stock INT,@precio_total decimal(10,4),@img image,@producto INT,@id_promotor INT
  
    AS
    BEGIN
      DECLARE @existpromotor INT, @existproduct INT, @idalmacen INT, @entradasexist INT, @stockexist INT;
      IF(@tipo = 'Obtener')
        BEGIN
          SELECT c.id,c.folio,c.cantidad_stock,c.precio_total, p.nombre AS Promotor, pr.nombre AS Producto
            FROM compra c JOIN promotor p ON(c.id_promotor = p.id)
            JOIN producto pr ON(c.id_producto = pr.id);
        END
      ELSE IF(@tipo = 'TextoBuscar')
        BEGIN
          SELECT c.id,c.folio,c.cantidad_stock,c.precio_total, p.nombre AS Promotor, pr.nombre AS Producto
          FROM compra c JOIN promotor p ON(c.id_promotor = p.id)
          JOIN producto pr ON(c.id_producto = pr.id) WHERE c.folio LIKE '%' + @folio + '%';
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN

          SET @existpromotor = (SELECT COUNT(*) FROM promotor WHERE id = @id_promotor);
          SET @existproduct  = (SELECT COUNT(*) FROM producto WHERE id = @producto);

          IF(@existpromotor < 1)
            BEGIN
              SELECT 'El promotor seleccionado no se encuentra en la base de datos';
            END
          ELSE IF(@existproduct < 1)
            BEGIN
              SELECT 'El producto no tiene existencia en almacen';
            END
          ELSE
            BEGIN
              SET @idalmacen = (SELECT TOP 1 id FROM almacen WHERE id_producto = @producto);
              SET @entradasexist = (SELECT TOP 1 entrada FROM almacen WHERE id_producto = @producto);
              SET @stockexist = (SELECT TOP 1 stock FROM almacen WHERE id_producto = @producto);

              IF(@idalmacen = NULL)
                BEGIN
                  SELECT 'El producto no tiene existencia en almacen';
                END
              ELSE IF(@entradasexist = NULL)
                BEGIN
                  SET @entradasexist = 0;
                END
              ELSE
                BEGIN
                  IF(@idalmacen IS NULL)
                    BEGIN
                      INSERT INTO almacen(entrada,salida,stock,id_user,id_producto) VALUES(@cantidad_stock,0,@cantidad_stock,1,@producto);
                      INSERT INTO compra(folio,cantidad_stock,precio_total,img,id_almacen,id_producto,id_promotor) 
                         VALUES(@folio,@cantidad_stock,@precio_total,@img,1,@producto,@id_promotor);

                      SELECT 'La insercion del registro se realizo con exito';
                    END
                  ELSE
                    BEGIN
                      INSERT INTO compra(folio,cantidad_stock,precio_total,img,id_almacen,id_producto,id_promotor) 
                         VALUES(@folio,@cantidad_stock,@precio_total,@img,@idalmacen,@producto,@id_promotor);

                      UPDATE almacen SET entrada = (@entradasexist + @cantidad_stock), stock = (@stockexist + @cantidad_stock) WHERE id = @idalmacen;
                      SELECT 'La insercion del registro se realizo con exito';
                    END                  
                END  
            END
        END
      ELSE IF(@tipo = 'Modificar')
        BEGIN
          SET @idalmacen = (SELECT TOP 1 id FROM almacen WHERE id_producto = @producto);

          SET @entradasexist = (SELECT TOP 1 entrada FROM almacen WHERE id_producto = @producto);
          SET @stockexist = (SELECT TOP 1 stock FROM almacen WHERE id_producto = @producto);

          UPDATE compra SET cantidad_stock = @cantidad_stock, precio_total= @precio_total, img = @img, id_almacen = @idalmacen, 
                            id_promotor = @id_promotor WHERE id = @id;

          IF(@cantidad_stock > 0)
          BEGIN
            UPDATE almacen SET entrada = (@entradasexist - @cantidad_stock), stock = (@stockexist - @cantidad_stock);
          END

          SELECT 'El registro fue actualizado con exito';
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM compra WHERE id = @id;
          SELECT 'El registro se elimino con exito';
        END
      ELSE IF(@tipo = 'Almacendata')
        BEGIN
          SELECT * FROM almacen WHERE id_producto = @producto;
        END
    END
  GO

  /*------sp producto precio------*/
  DROP PROCEDURE IF EXISTS sp_producto_precio
  GO
  CREATE PROCEDURE sp_producto_precio @tipo CHAR(30), @id INT,@precio decimal(10,2), @id_product INT, @search CHAR(80)
    AS
    BEGIN
      DECLARE @existproduct INT;

      IF(@tipo = 'Obtener')
        BEGIN
          SELECT pr.id,pr.precio,p.nombre FROM productoprecio pr JOIN producto p ON(pr.id_product = p.id)
        END
      ELSE IF(@tipo = 'ObtenerById')
        BEGIN
          SELECT pr.id,pr.precio,p.nombre FROM productoprecio pr JOIN producto p ON(pr.id_product = p.id) WHERE pr.id =  @id;
        END
      ELSE IF(@tipo = 'OBTENERPRODUCTFALTANTE')
        BEGIN
          SELECT 0 AS id,'Seleccione un producto' AS nombre,'' AS descripcion,'false' AS precioPorKilo,'' AS img,0 AS id_categoria
          UNION ALL
          SELECT * FROM producto WHERE id NOT IN(SELECT id FROM productoprecio);
        END
      ELSE IF(@tipo = 'PRODUCTONAME')
        BEGIN
          SELECT pr.id,pr.precio,p.nombre FROM productoprecio pr JOIN producto p ON(pr.id_product = p.id) WHERE p.nombre LIKE '%' + @search + '%';
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN
          SET @existproduct = (SELECT COUNT(*) FROM producto WHERE id = @id_product);

          IF(@existproduct > 0)
            BEGIN
              INSERT INTO productoprecio(precio,id_product) VALUES(@precio,@id_product);
              SELECT 'El registro fue insertado con exito';
            END
          ELSE
            BEGIN
              SELECT 'No se encontro el producto selecciondo';
            END
        END
      ELSE IF(@tipo = 'Modificar')
        BEGIN
          UPDATE productoprecio SET precio = @precio WHERE id = @id;
          SELECT 'El registro fue actualizado con exito';
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM productoprecio WHERE id = @id;
          SELECT 'El registro fue elimminado con exito';
        END
    END
  GO

  /*------FALTA LOS SP DE venta,detalle de venta cuentaporcobrar, detalle de cuentaporcobrar, arqueocaja------*/
  

  /*------sp ventas------*/
  DROP PROCEDURE IF EXISTS sp_venta
  GO
  CREATE PROCEDURE sp_venta @tipo CHAR(30), @id INT,@factura VARCHAR(100),@preciototal DECIMAL(10,2), @idpago INT,@idclient INT,@iduser INT
    AS
    BEGIN
      DECLARE @fechahoy VARCHAR(30), @idfinal INT, @facture VARCHAR(100);

      IF(@tipo = 'Obtener')
        BEGIN
          SELECT v.id,v.factura,v.precio_total,t.name as tipopago, c.nombre as cliente, u.name as usuario
                FROM venta v JOIN typepay t ON(v.id_pago = t.id)
                LEFT JOIN cliente c ON(v.id_cliente = c.id)
                LEFT JOIN users u ON(v.id_users = u.id);
        END
      ELSE IF(@tipo = 'ObtenerDetalle')
        BEGIN
            SELECT dv.id_venta,v.factura,p.nombre AS producto, dv.cantidad, dv.precio,v.precio_total,t.name AS tipopago,c.nombre as cliente, u.name as usuario
                  FROM d_venta dv JOIN venta v ON(dv.id_venta = v.id)
                  JOIN producto p ON(dv.id_producto = p.id)
                  JOIN typepay t ON(v.id_pago = t.id)
                  JOIN cliente c ON(v.id_cliente = c.id)
                  JOIN users u ON(v.id_users = u.id)
            WHERE v.factura = @factura;
        END
      ELSE IF(@tipo = 'Obtenerfactura')
        BEGIN
          SELECT v.id,v.factura,v.precio_total,t.name as tipopago, c.nombre as cliente, u.name as usuario
                FROM venta v JOIN typepay t ON(v.id_pago = t.id)
                LEFT JOIN cliente c ON(v.id_cliente = c.id)
                LEFT JOIN users u ON(v.id_users = u.id)
                WHERE v.factura LIKE '%' + @factura + '%';
        END
      ELSE IF(@tipo = 'ObtenerById')
        BEGIN
            SELECT dv.id_venta,v.factura,p.nombre AS producto, dv.cantidad, dv.precio,v.precio_total,t.name AS tipopago,c.nombre as cliente, u.name as usuario
                  FROM d_venta dv JOIN venta v ON(dv.id_venta = v.id)
                  JOIN producto p ON(dv.id_producto = p.id)
                  JOIN typepay t ON(v.id_pago = t.id)
                  JOIN cliente c ON(v.id_cliente = c.id)
                  JOIN users u ON(v.id_users = u.id)
            WHERE v.id = @id;
        END
      ELSE IF(@tipo = 'Insertar')
        BEGIN

          SET @fechahoy = CONVERT(CHAR(8), GETDATE(), 112);
          SET @idfinal = (SELECT TOP 1 id FROM venta ORDER BY id DESC);
          IF(@idfinal IS NULL)
            BEGIN
              SET @idfinal = 0;
            END
          SET @facture = CAST(@fechahoy AS VARCHAR) + CAST(@idfinal + 1 AS VARCHAR);

          INSERT INTO venta(factura,impuesto,precio_total,id_pago,id_cliente,id_users) VALUES(@facture,0.16,@preciototal,@idpago,@idclient,@iduser);
          SELECT TOP 1 * FROM venta ORDER BY id DESC;
          
        END
      ELSE IF(@tipo = 'Eliminar')
        BEGIN
          DELETE FROM d_venta WHERE id_venta = @id;
          DELETE FROM venta WHERE id = @id;
          SELECT 'El registro fue eliminado con exito';
        END
      ELSE IF(@tipo = 'TipoPago')
        BEGIN
          SELECT 0 AS id, 'Seleccione el tipo de pago' AS name
            UNION ALL
          SELECT * FROM typepay;
        END   
    

    END
  GO

  /*------sp detalle venta------*/
  DROP PROCEDURE IF EXISTS sp_venta_detalle;
  GO
  CREATE PROCEDURE sp_venta_detalle @tipo CHAR(30), @id INT, @idventa INT, @id_producto INT, @cantidad INT, @precio DECIMAL(10,2)
    AS
    BEGIN
      DECLARE @entrada INT,@salida INT,@stock INT
      IF(@tipo = 'Insertar')
        BEGIN
          
          SET @entrada = (SELECT entrada FROM almacen WHERE id_producto = @id_producto);
          SET @salida = (SELECT salida FROM almacen WHERE id_producto = @id_producto);
          SET @stock = (SELECT stock FROM almacen WHERE id_producto = @id_producto);

          INSERT INTO d_venta(id_venta,id_producto,cantidad,precio) VALUES(@idventa,@id_producto,@cantidad,@precio);
          UPDATE almacen SET stock =  (@stock-@cantidad), salida = (@salida + @cantidad) WHERE id_producto = @id_producto;
          SELECT 'La insercion se realizo con exito'

        END
      ELSE IF(@tipo = 'Eliminar')
      BEGIN
        DELETE FROM d_venta WHERE id = @id;
        SELECT 'El registro fue eliminado con exito';
      END
      ELSE IF(@tipo = 'EliminarVenta')
        BEGIN
          DELETE FROM d_venta WHERE id_venta = @idventa;
          SELECT 'El registro fue eliminado con exito';
        END
    END
  GO


/*------------------------------------Inserciones basicas------------------------------------------*/

INSERT INTO users(name,email,password,type,api_token) VALUES('Luis Ramon Valencia Aguayo','admincorreo@hotmail.com','Admin123','Administrador','rnjddfndjgnd');
INSERT INTO users(name,email,password,type,api_token) VALUES('Jose Antonio Ranirez Sanchez','elcorreoprueba@hotmail.com','Admin123','Vendedor','sdfsdfsdf');
INSERT INTO typepay(name) VALUES('EFECTIVO')
INSERT INTO cliente(nombre,apellidos,telefono,img,direccion,cp,colonia) VALUES('Cliente','Generico','0000000000','','',00000,'');

INSERT INTO categoria_producto(nombre) VALUES ('Frutas y Verduras');
INSERT INTO categoria_producto(nombre) VALUES ('Lacteos');

INSERT INTO cliente(nombre, apellidos, telefono, img, direccion, cp, colonia) VALUES ('Manuel','Perez Carillo', '3324234354', '', 'Lomas del paraiso', 46540, 'San Marcos');
INSERT INTO cliente(nombre, apellidos, telefono, img, direccion, cp, colonia) VALUES ('Lupillo','Perez Valencia', '4534535434532', '', 'Lomas del paraiso 32', 46530, 'Oconahua');

INSERT INTO producto(nombre, descripcion, precioPorKilo, img, id_categoria) VALUES ('Manzana', 'Fruto comestible de la especie Malus domestica, el manzano común', 'true', '', 1);
INSERT INTO producto(nombre, descripcion, precioPorKilo, img, id_categoria) VALUES ('Jamon', 'Jamon de pierna', 'true', '', 2);
INSERT INTO producto(nombre, descripcion, precioPorKilo, img, id_categoria) VALUES ('Leche entera', 'Leche entera 19 hermanos', 'false', '', 2);
INSERT INTO producto(nombre, descripcion, precioPorKilo, img, id_categoria) VALUES ('Papas', 'papas naturales', 'true', '', 1);

INSERT INTO almacen(entrada, salida, stock, id_user, id_producto) VALUES (20, 0, 20, 1, 1);
INSERT INTO almacen(entrada, salida, stock, id_user, id_producto) VALUES (45, 0, 45, 1, 2);
INSERT INTO almacen(entrada, salida, stock, id_user, id_producto) VALUES (80, 0, 80, 1, 3);
INSERT INTO almacen(entrada, salida, stock, id_user, id_producto) VALUES (30, 0, 30, 1, 4);

INSERT INTO productoprecio (precio, id_product) VALUES (CAST(12.30 AS Decimal(10, 2)), 1);
INSERT INTO productoprecio (precio, id_product) VALUES (CAST(17.50 AS Decimal(10, 2)), 3);
INSERT INTO productoprecio (precio, id_product) VALUES (CAST(13.30 AS Decimal(10, 2)), 4);

INSERT INTO promotor(nombre,direccion,telefono,sitioWeb, img) VALUES ('19 Hermanos', 'K.M 5 Carretera Tototlán-Atotonilco. Tototlán, Jal 44180 Guadalajara (México)', '01 800 841 0939', 'https://19hermanos.com.mx/', '');
INSERT INTO promotor(nombre,direccion,telefono,sitioWeb, img) VALUES ('Mercado de Abastos', 'C. Chícharo 26-27, Comercial Abastos, 44530 Guadalajara, Jal.', '0000000000', '', '');

INSERT INTO compra (folio, cantidad_stock, precio_total, img, id_almacen, id_promotor, id_producto) VALUES ('factura-gdfgdgdfg', 20, CAST(870.4000 AS Decimal(10, 4)), '', 1, 1, 1);
INSERT INTO compra (folio, cantidad_stock, precio_total, img, id_almacen, id_promotor, id_producto) VALUES ('factura-gdfgdgdfg', 45, CAST(530.4000 AS Decimal(10, 4)), '', 1, 2, 2);
INSERT INTO compra (folio, cantidad_stock, precio_total, img, id_almacen, id_promotor, id_producto) VALUES ('factura-gdfgdgdfg', 80, CAST(859.5000 AS Decimal(10, 4)), '', 1, 1, 3);
INSERT INTO compra (folio, cantidad_stock, precio_total, img, id_almacen, id_promotor, id_producto) VALUES ('factura-gdfgdgdfg', 80, CAST(859.5000 AS Decimal(10, 4)), '', 1, 2, 4);






