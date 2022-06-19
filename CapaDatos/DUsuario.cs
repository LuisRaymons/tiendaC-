using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario
    {
        private string tipo;
        private int id;
        private string name;
        private string email;
        private string password;
        private byte[] img;
        private string type;
        private string api_token;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public byte[] Img { get => img; set => img = value; }
        public string Type { get => type; set => type = value; }
        public string Api_token { get => api_token; set => api_token = value; }

        public DUsuario() {}
        public DUsuario(string tipo, int id,string name,string email,string password, byte[] img, string type, string api_token)
        {
            this.Tipo = tipo;
            this.id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.img = img;
            this.Type = type;
            this.Api_token = api_token;
        }

        // Peticciones Insert, update,delete
        public string peticion(DUsuario usuario)
        {
            string responde = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_users";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = usuario.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = usuario.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@name";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 255;
                paramname.Value = usuario.Name;
                cmd.Parameters.Add(paramname);

                SqlParameter paramemail = new SqlParameter();
                paramemail.ParameterName = "@email";
                paramemail.SqlDbType = SqlDbType.VarChar;
                paramemail.Size = 255;
                paramemail.Value = usuario.Email;
                cmd.Parameters.Add(paramemail);

                SqlParameter parampassword = new SqlParameter();
                parampassword.ParameterName = "@password";
                parampassword.SqlDbType = SqlDbType.VarChar;
                parampassword.Size = 255;
                parampassword.Value = usuario.Password;
                cmd.Parameters.Add(parampassword);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = usuario.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramtype = new SqlParameter();
                paramtype.ParameterName = "@type";
                paramtype.SqlDbType = SqlDbType.VarChar;
                paramtype.Size = 100;
                paramtype.Value = usuario.Type;
                cmd.Parameters.Add(paramtype);

                SqlParameter paramapitoken = new SqlParameter();
                paramapitoken.ParameterName = "@api_token";
                paramapitoken.SqlDbType = SqlDbType.VarChar;
                paramapitoken.Size = 255;
                paramapitoken.Value = usuario.Api_token;
                cmd.Parameters.Add(paramapitoken);

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
        public DataTable peticionData(DUsuario usuario)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                //sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_users";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = usuario.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = usuario.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@name";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 255;
                paramname.Value = usuario.Name;
                cmd.Parameters.Add(paramname);

                SqlParameter paramemail = new SqlParameter();
                paramemail.ParameterName = "@email";
                paramemail.SqlDbType = SqlDbType.VarChar;
                paramemail.Size = 255;
                paramemail.Value = usuario.Email;
                cmd.Parameters.Add(paramemail);

                SqlParameter parampassword = new SqlParameter();
                parampassword.ParameterName = "@password";
                parampassword.SqlDbType = SqlDbType.VarChar;
                parampassword.Size = 255;
                parampassword.Value = usuario.Password;
                cmd.Parameters.Add(parampassword);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = usuario.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramtype = new SqlParameter();
                paramtype.ParameterName = "@type";
                paramtype.SqlDbType = SqlDbType.VarChar;
                paramtype.Size = 100;
                paramtype.Value = usuario.Type;
                cmd.Parameters.Add(paramtype);

                SqlParameter paramapitoken = new SqlParameter();
                paramapitoken.ParameterName = "@api_token";
                paramapitoken.SqlDbType = SqlDbType.VarChar;
                paramapitoken.Size = 255;
                paramapitoken.Value = usuario.Api_token;
                cmd.Parameters.Add(paramapitoken);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            } catch(Exception ex){
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

        // Select
        public IDataReader usuarioselect()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM users", sqlcon);
                cmd.Connection = sqlcon;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                dr = null;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

            return dr;
        }
        
        // obtener id
        public IDataReader getUserId(int id)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE id = " + id, sqlcon);
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
