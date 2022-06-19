using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NProducto
    {
        public static string peticiones(string peticion, int id, string nombre, string descripcion, string precioKilo, byte[] img, int idcategoria)
        {
            DProducto dProducto = new DProducto();
            dProducto.Tipo = peticion;
            dProducto.Id = id;
            dProducto.Nombre = nombre;
            dProducto.Descripcion = descripcion;
            dProducto.PrecioKilo = precioKilo;
            dProducto.Img = img;
            dProducto.Idcategoria = idcategoria;

            return dProducto.peticiones(dProducto);
        }

        public static DataTable peticionesData(string peticion, int id, string nombre, string descripcion, string precioKilo, byte[] img, int idcategoria)
        {
            DProducto dProducto = new DProducto();
            dProducto.Tipo = peticion;
            dProducto.Id = id;
            dProducto.Nombre = nombre;
            dProducto.Descripcion = descripcion;
            dProducto.PrecioKilo = precioKilo;
            dProducto.Img = img;
            dProducto.Idcategoria = idcategoria;

            return dProducto.peticionesData(dProducto);
        }

        public static IDataReader productselect()
        {
            DProducto dProducto = new DProducto();
            return dProducto.productosselect();
        }

        public static IDataReader consultarproductbyid(int id)
        {
            DProducto dProducto = new DProducto();
            return dProducto.consultarproductbyid(id);
        }
    }
}
