using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProducto
    {
        private string tipo;
        private int id;
        private string nombre;
        private string descripcion;
        private string precioKilo;
        private byte[] img;
        private int idcategoria;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string PrecioKilo { get => precioKilo; set => precioKilo = value; }
        public byte[] Img { get => img; set => img = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }

        public DProducto() { }

        public DProducto(string tipo, int id, string nombre, string descripcion, string precioKilo, byte[] img, int idcategoria)
        {
            this.Tipo = tipo;
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PrecioKilo = precioKilo;
            this.Img = img;
            this.Idcategoria = idcategoria;
        }

        // Peticciones Insert, update,delete
        public string peticiones(DProducto producto)
        {
            string responde = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_producto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parametertipo = new SqlParameter();
                parametertipo.ParameterName = "@tipo";
                parametertipo.SqlDbType = SqlDbType.Char;
                parametertipo.Size = 30;
                parametertipo.Value = producto.Tipo;
                cmd.Parameters.Add(parametertipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = producto.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@nombre";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 200;
                paramname.Value = producto.Nombre;
                cmd.Parameters.Add(paramname);

                SqlParameter paramdescripcion = new SqlParameter();
                paramdescripcion.ParameterName = "@descripcion";
                paramdescripcion.SqlDbType = SqlDbType.VarChar;
                paramdescripcion.Size = 400;
                paramdescripcion.Value = producto.Descripcion;
                cmd.Parameters.Add(paramdescripcion);

                SqlParameter parampreciokilo = new SqlParameter();
                parampreciokilo.ParameterName = "@precioPorKilo";
                parampreciokilo.SqlDbType = SqlDbType.Char;
                parampreciokilo.Size = 30;
                parampreciokilo.Value = producto.PrecioKilo;
                cmd.Parameters.Add(parampreciokilo);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Size = 200;
                paramimg.Value = producto.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramIdcategoria = new SqlParameter();
                paramIdcategoria.ParameterName = "@id_categoria";
                paramIdcategoria.SqlDbType = SqlDbType.Int;
                paramIdcategoria.Value = producto.Idcategoria;
                cmd.Parameters.Add(paramIdcategoria);

                responde = cmd.ExecuteNonQuery().ToString();

            } catch(Exception ex)
            {
                responde = ex.Message;
            }
            finally
            {
                if(sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return responde;
        }

        // Peticiones de datatable o busqueda por nombre
        public DataTable peticionesData(DProducto producto)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                //sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_producto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parametertipo = new SqlParameter();
                parametertipo.ParameterName = "@tipo";
                parametertipo.SqlDbType = SqlDbType.Char;
                parametertipo.Size = 30;
                parametertipo.Value = producto.Tipo;
                cmd.Parameters.Add(parametertipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = producto.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@nombre";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 200;
                paramname.Value = producto.Nombre;
                cmd.Parameters.Add(paramname);

                SqlParameter paramdescripcion = new SqlParameter();
                paramdescripcion.ParameterName = "@descripcion";
                paramdescripcion.SqlDbType = SqlDbType.VarChar;
                paramdescripcion.Size = 400;
                paramdescripcion.Value = producto.Descripcion;
                cmd.Parameters.Add(paramdescripcion);

                SqlParameter parampreciokilo = new SqlParameter();
                parampreciokilo.ParameterName = "@precioPorKilo";
                parampreciokilo.SqlDbType = SqlDbType.Char;
                parampreciokilo.Size = 30;
                parampreciokilo.Value = producto.PrecioKilo;
                cmd.Parameters.Add(parampreciokilo);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Size = 200;
                paramimg.Value = producto.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramIdcategoria = new SqlParameter();
                paramIdcategoria.ParameterName = "@id_categoria";
                paramIdcategoria.SqlDbType = SqlDbType.Int;
                paramIdcategoria.Value = producto.Idcategoria;
                cmd.Parameters.Add(paramIdcategoria);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            } catch(Exception ex)
            {
                dt = null;
            }
            finally
            {
                if(sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

            return dt;
        }
        
        public IDataReader consultarproductbyid(int id)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT p.id,p.nombre,p.descripcion,p.precioPorKilo,p.img,c.nombre as categoria FROM producto p JOIN categoria_producto c ON(p.id_categoria = c.id) WHERE p.id = " + id, sqlcon);
                cmd.Connection = sqlcon;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                dr = null;
            }

            return dr;
        }
        // Select
        public IDataReader productosselect()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM producto", sqlcon);
                cmd.Connection = sqlcon;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                dr = null;
            }

            return dr;
        }
    }

}