using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPromotor
    {
        private string tipo;
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        private string sitioweb;
        private byte[] img;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Sitioweb { get => sitioweb; set => sitioweb = value; }
        public byte[] Img { get => img; set => img = value; }

        public DPromotor() {}
        public DPromotor(string tipo, int id, string nombre, string direccion, string telefono, string sitioweb, byte[] img)
        {
            this.Tipo = tipo;
            this.Id = id;
            this.Nombre = nombre;
            this.direccion = direccion;
            this.Telefono = telefono;
            this.Sitioweb = sitioweb;
            this.Img = img;
        }
    
        public string peticiones(DPromotor promotor)
        {
            string responde = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_promotor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sp_promotor = new SqlParameter();
                sp_promotor.ParameterName = "@tipo";
                sp_promotor.SqlDbType = SqlDbType.Char;
                sp_promotor.Size = 30;
                sp_promotor.Value = promotor.Tipo;
                cmd.Parameters.Add(sp_promotor);

                SqlParameter parameterid = new SqlParameter();
                parameterid.ParameterName = "@id";
                parameterid.SqlDbType = SqlDbType.Int;
                parameterid.Value = Id;
                cmd.Parameters.Add(parameterid);

                SqlParameter paramnombre = new SqlParameter();
                paramnombre.ParameterName = "@nombre";
                paramnombre.SqlDbType = SqlDbType.VarChar;
                paramnombre.Size = 200;
                paramnombre.Value = promotor.Nombre;
                cmd.Parameters.Add(paramnombre);

                SqlParameter paramdireccion = new SqlParameter();
                paramdireccion.ParameterName = "@direccion";
                paramdireccion.SqlDbType = SqlDbType.VarChar;
                paramdireccion.Size = 200;
                paramdireccion.Value = promotor.Direccion;
                cmd.Parameters.Add(paramdireccion);

                SqlParameter paramtelefono = new SqlParameter();
                paramtelefono.ParameterName = "@telefono";
                paramtelefono.SqlDbType = SqlDbType.VarChar;
                paramtelefono.Size = 100;
                paramtelefono.Value = promotor.Telefono;
                cmd.Parameters.Add(paramtelefono);

                SqlParameter parasitioweb = new SqlParameter();
                parasitioweb.ParameterName = "@sitioWeb";
                parasitioweb.SqlDbType = SqlDbType.VarChar;
                parasitioweb.Size = 200;
                parasitioweb.Value = promotor.Sitioweb;
                cmd.Parameters.Add(parasitioweb);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = promotor.Img;
                cmd.Parameters.Add(paramimg);

                return cmd.ExecuteNonQuery().ToString();
            }
            catch(Exception ex)
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

        public DataTable peticionesData(DPromotor promotor)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                //sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_promotor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sp_promotor = new SqlParameter();
                sp_promotor.ParameterName = "@tipo";
                sp_promotor.SqlDbType = SqlDbType.Char;
                sp_promotor.Size = 30;
                sp_promotor.Value = promotor.Tipo;
                cmd.Parameters.Add(sp_promotor);

                SqlParameter parameterid = new SqlParameter();
                parameterid.ParameterName = "@id";
                parameterid.SqlDbType = SqlDbType.Int;
                parameterid.Value = Id;
                cmd.Parameters.Add(parameterid);

                SqlParameter paramnombre = new SqlParameter();
                paramnombre.ParameterName = "@nombre";
                paramnombre.SqlDbType = SqlDbType.VarChar;
                paramnombre.Size = 200;
                paramnombre.Value = promotor.Nombre;
                cmd.Parameters.Add(paramnombre);

                SqlParameter paramdireccion = new SqlParameter();
                paramdireccion.ParameterName = "@direccion";
                paramdireccion.SqlDbType = SqlDbType.VarChar;
                paramdireccion.Size = 200;
                paramdireccion.Value = promotor.Direccion;
                cmd.Parameters.Add(paramdireccion);

                SqlParameter paramtelefono = new SqlParameter();
                paramtelefono.ParameterName = "@telefono";
                paramtelefono.SqlDbType = SqlDbType.VarChar;
                paramtelefono.Size = 100;
                paramtelefono.Value = promotor.Telefono;
                cmd.Parameters.Add(paramtelefono);

                SqlParameter parasitioweb = new SqlParameter();
                parasitioweb.ParameterName = "@sitioWeb";
                parasitioweb.SqlDbType = SqlDbType.VarChar;
                parasitioweb.Size = 200;
                parasitioweb.Value = promotor.Sitioweb;
                cmd.Parameters.Add(parasitioweb);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = promotor.Img;
                cmd.Parameters.Add(paramimg);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            } catch(Exception ex)
            {
                dt = null;
                string datos = ex.Message;
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

        
        public IDataReader promotorselect()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM promotor", sqlcon);
                cmd.Connection = sqlcon;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                dr = null;
            }

            return dr;
        }
        
    
        public IDataReader promotorbyid(int id)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM promotor WHERE id = " + id, sqlcon);
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
