using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDVenta
    {
        private string tipo;
        private int id;
        private int idventa;
        private int idproducto;
        private int cantidad;
        private double precio;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public int Idventa { get => idventa; set => idventa = value; }
        public int Idproducto { get => idproducto; set => idproducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }

        public DDVenta() {}

        public DDVenta(string tipo, int id, int idventa, int idproducto, int cantidad, double precio)
        {
            Tipo = tipo;
            Id = id;
            Idventa = idventa;
            Idproducto = idproducto;
            Cantidad = cantidad;
            Precio = precio;
        }   
    
        public string peticiones(DDVenta dventa)
        {
            string responde = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_venta_detalle";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = dventa.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = dventa.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramidventa = new SqlParameter();
                paramidventa.ParameterName = "@idventa";
                paramidventa.SqlDbType = SqlDbType.Int;
                paramidventa.Value = dventa.idventa;
                cmd.Parameters.Add(paramidventa);

                SqlParameter paramidproducto = new SqlParameter();
                paramidproducto.ParameterName = "@id_producto";
                paramidproducto.SqlDbType = SqlDbType.Int;
                paramidproducto.Value = dventa.Idproducto;
                cmd.Parameters.Add(paramidproducto);

                SqlParameter paramcantidad = new SqlParameter();
                paramcantidad.ParameterName = "@cantidad";
                paramcantidad.SqlDbType = SqlDbType.Int;
                paramcantidad.Value = dventa.Cantidad;
                cmd.Parameters.Add(paramcantidad);

                SqlParameter paramprecio = new SqlParameter();
                paramprecio.ParameterName = "@precio";
                paramprecio.SqlDbType = SqlDbType.Decimal;
                paramprecio.Precision = 10;
                paramprecio.Scale = 2;
                paramprecio.Value = dventa.Precio;
                cmd.Parameters.Add(paramprecio);

                responde = cmd.ExecuteNonQuery().ToString();
            } catch(Exception ex)
            {
                responde = null;
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

        public DataTable peticionesData(DDVenta dventa)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = dventa.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = dventa.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramidventa = new SqlParameter();
                paramidventa.ParameterName = "@idventa";
                paramidventa.SqlDbType = SqlDbType.Int;
                paramidventa.Value = dventa.idventa;
                cmd.Parameters.Add(paramidventa);

                SqlParameter paramidproducto = new SqlParameter();
                paramidproducto.ParameterName = "@id_producto";
                paramidproducto.SqlDbType = SqlDbType.Int;
                paramidproducto.Value = dventa.Idproducto;
                cmd.Parameters.Add(paramidproducto);

                SqlParameter paramcantidad = new SqlParameter();
                paramcantidad.ParameterName = "@cantidad";
                paramcantidad.SqlDbType = SqlDbType.Int;
                paramcantidad.Value = dventa.Cantidad;
                cmd.Parameters.Add(paramcantidad);

                SqlParameter paramprecio = new SqlParameter();
                paramprecio.ParameterName = "@precio";
                paramprecio.SqlDbType = SqlDbType.Decimal;
                paramprecio.Precision = 10;
                paramprecio.Scale = 2;
                paramprecio.Value = dventa.Precio;
                cmd.Parameters.Add(paramprecio);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch(Exception ex)
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
    }
}
