using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPrecioProducto
    {
        private string tipo;
        private int id;
        private double precio;
        private int productoid;
        private string search;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Productoid { get => productoid; set => productoid = value; }
        public string Search { get => search; set => search = value; }

        public DPrecioProducto() {}
        public DPrecioProducto(string tipo,int id, double precio, int producto,string search)
        {
            this.Tipo = tipo;
            this.Id = id;
            this.Precio = precio;
            this.Productoid = productoid;
            this.Search = search;
        }
    
        public string peticiones(DPrecioProducto precio)
        {
            string responde = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_producto_precio";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = precio.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = precio.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramprecio = new SqlParameter();
                paramprecio.ParameterName = "@precio";
                paramprecio.SqlDbType = SqlDbType.Decimal;
                paramprecio.Precision = 10;
                paramprecio.Scale = 2;
                paramprecio.Value = precio.Precio;
                cmd.Parameters.Add(paramprecio);

                SqlParameter paramidproduct = new SqlParameter();
                paramidproduct.ParameterName = "@id_product";
                paramidproduct.SqlDbType = SqlDbType.Int;
                paramidproduct.Value = precio.Productoid;
                cmd.Parameters.Add(paramidproduct);

                SqlParameter paramsearch = new SqlParameter();
                paramsearch.ParameterName = "@search";
                paramsearch.SqlDbType = SqlDbType.Char;
                paramsearch.Size = 80;
                paramsearch.Value = precio.Search;
                cmd.Parameters.Add(paramsearch);

                responde = cmd.ExecuteNonQuery().ToString();
            } catch(Exception ex)
            {
                responde = "Error al realizar la la actualizacion";
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return responde;
        }

        public DataTable peticionesData(DPrecioProducto precio)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                //sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_producto_precio";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = precio.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = precio.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramprecio = new SqlParameter();
                paramprecio.ParameterName = "@precio";
                paramprecio.SqlDbType = SqlDbType.Decimal;
                paramprecio.Precision = 10;
                paramprecio.Scale = 2;
                paramprecio.Value = precio.Precio;
                cmd.Parameters.Add(paramprecio);

                SqlParameter paramidproduct = new SqlParameter();
                paramidproduct.ParameterName = "@id_product";
                paramidproduct.SqlDbType = SqlDbType.Int;
                paramidproduct.Value = precio.Productoid;
                cmd.Parameters.Add(paramidproduct);

                SqlParameter paramsearch = new SqlParameter();
                paramsearch.ParameterName = "@search";
                paramsearch.SqlDbType = SqlDbType.Char;
                paramsearch.Size = 80;
                paramsearch.Value = precio.Search;
                cmd.Parameters.Add(paramsearch);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            } catch(Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return dt;
        }
        
        public IDataReader obtenerpreciobyid(int id)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT pp.id,pp.precio,pp.id_product,p.nombre FROM productoprecio pp JOIN producto p ON(pp.id_product = p.id) WHERE pp.id = " + Convert.ToInt32(id), sqlcon);
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
