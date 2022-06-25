using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVenta
    {
        private string tipo;
        private int id;
        private string factura;
        private double preciototal;
        private int idpago;
        private int idcliente;
        private int iduser;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public string Factura { get => factura; set => factura = value; }
        public double Preciototal { get => preciototal; set => preciototal = value; }
        public int Idpago { get => idpago; set => idpago = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
        public int Iduser { get => iduser; set => iduser = value; }

        public DVenta() {}
        public DVenta(string tipo, int id, string factura, double preciototal, int idpago, int idcliente, int iduser)
        {
            this.Tipo = tipo;
            this.Id = id;
            this.Factura = factura;
            this.Preciototal = preciototal;
            this.Idpago = idpago;
            this.Idcliente = idcliente;
            this.Iduser = iduser;
        }

        public string peticiones(DVenta venta)
        {
            string responde = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = venta.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = venta.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramfactura = new SqlParameter();
                paramfactura.ParameterName = "@factura";
                paramfactura.SqlDbType = SqlDbType.VarChar;
                paramfactura.Size = 100;
                paramfactura.Value = venta.Factura;
                cmd.Parameters.Add(paramfactura);

                SqlParameter parampreciototal = new SqlParameter();
                parampreciototal.ParameterName = "@preciototal";
                parampreciototal.SqlDbType = SqlDbType.Decimal;
                parampreciototal.Precision = 10;
                parampreciototal.Scale = 2;
                parampreciototal.Value = venta.Preciototal;
                cmd.Parameters.Add(parampreciototal);

                SqlParameter paramidpago = new SqlParameter();
                paramidpago.ParameterName = "@idpago";
                paramidpago.SqlDbType = SqlDbType.Int;
                paramidpago.Value = venta.Idpago;
                cmd.Parameters.Add(paramidpago);

                SqlParameter paramidclient = new SqlParameter();
                paramidclient.ParameterName = "@idclient";
                paramidclient.SqlDbType = SqlDbType.Int;
                paramidclient.Value = venta.Idcliente;
                cmd.Parameters.Add(paramidclient);

                SqlParameter paramiduser = new SqlParameter();
                paramiduser.ParameterName = "@iduser";
                paramiduser.SqlDbType = SqlDbType.Int;
                paramiduser.Value = venta.Iduser;
                cmd.Parameters.Add(paramiduser);

                responde = cmd.ExecuteNonQuery().ToString();

            } catch(Exception ex)
            {
                responde = null;
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

        public DataTable peticionesData(DVenta venta)
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
                paramtipo.Value = venta.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = venta.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramfactura = new SqlParameter();
                paramfactura.ParameterName = "@factura";
                paramfactura.SqlDbType = SqlDbType.VarChar;
                paramfactura.Size = 100;
                paramfactura.Value = venta.Factura;
                cmd.Parameters.Add(paramfactura);

                SqlParameter parampreciototal = new SqlParameter();
                parampreciototal.ParameterName = "@preciototal";
                parampreciototal.SqlDbType = SqlDbType.Decimal;
                parampreciototal.Precision = 10;
                parampreciototal.Scale = 2;
                parampreciototal.Value = venta.Preciototal;
                cmd.Parameters.Add(parampreciototal);

                SqlParameter paramidpago = new SqlParameter();
                paramidpago.ParameterName = "@idpago";
                paramidpago.SqlDbType = SqlDbType.Int;
                paramidpago.Value = venta.Idpago;
                cmd.Parameters.Add(paramidpago);

                SqlParameter paramidclient = new SqlParameter();
                paramidclient.ParameterName = "@idclient";
                paramidclient.SqlDbType = SqlDbType.Int;
                paramidclient.Value = venta.Idcliente;
                cmd.Parameters.Add(paramidclient);

                SqlParameter paramiduser = new SqlParameter();
                paramiduser.ParameterName = "@iduser";
                paramiduser.SqlDbType = SqlDbType.Int;
                paramiduser.Value = venta.Iduser;
                cmd.Parameters.Add(paramiduser);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
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
    }
}
