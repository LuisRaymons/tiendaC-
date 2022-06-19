using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCliente
    {
        private string tipo;
        private int id;
        private string nombre;
        private string apellidos;
        private string telefono;
        private byte[] img;
        private string direccion;
        private int cp;
        private string colonia;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public byte[] Img { get => img; set => img = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Colonia { get => colonia; set => colonia = value; }

        public DCliente() {}

        public DCliente(string tipo, int id, string nombre, string apellidos, string telefono, byte[] img, string direccion, int cp, string colonia)
        {
            this.Tipo = tipo;
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Img = img;
            this.Direccion = direccion;
            this.Cp = cp;
            this.Colonia = colonia;

        }

        // Peticciones Insert, update,delete
        public string peticiones(DCliente cliente)
        {
            string responde = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = cliente.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = cliente.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@nombre";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 100;
                paramname.Value = cliente.Nombre;
                cmd.Parameters.Add(paramname);

                SqlParameter paramlastname = new SqlParameter();
                paramlastname.ParameterName = "@apellidos";
                paramlastname.SqlDbType = SqlDbType.VarChar;
                paramlastname.Size = 100;
                paramlastname.Value = cliente.Apellidos;
                cmd.Parameters.Add(paramlastname);

                SqlParameter paramtelefono = new SqlParameter();
                paramtelefono.ParameterName = "@telefono";
                paramtelefono.SqlDbType = SqlDbType.VarChar;
                paramtelefono.Size = 30;
                paramtelefono.Value = cliente.Telefono;
                cmd.Parameters.Add(paramtelefono);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = cliente.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramdireccion = new SqlParameter();
                paramdireccion.ParameterName = "@direccion";
                paramdireccion.SqlDbType = SqlDbType.VarChar;
                paramdireccion.Size = 200;
                paramdireccion.Value = cliente.Direccion;
                cmd.Parameters.Add(paramdireccion);

                SqlParameter paramcp = new SqlParameter();
                paramcp.ParameterName = "@cp";
                paramcp.SqlDbType = SqlDbType.Int;
                paramcp.Value = cliente.Cp;
                cmd.Parameters.Add(paramcp);

                SqlParameter paramcolonia = new SqlParameter();
                paramcolonia.ParameterName = "@colonia";
                paramcolonia.SqlDbType = SqlDbType.VarChar;
                paramcolonia.Size = 200;
                paramcolonia.Value = cliente.Colonia;
                cmd.Parameters.Add(paramcolonia);

                responde = cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
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
        public DataTable peticionesData(DCliente cliente)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                //sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = cliente.Tipo;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = cliente.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@nombre";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 100;
                paramname.Value = cliente.Nombre;
                cmd.Parameters.Add(paramname);

                SqlParameter paramlastname = new SqlParameter();
                paramlastname.ParameterName = "@apellidos";
                paramlastname.SqlDbType = SqlDbType.VarChar;
                paramlastname.Size = 100;
                paramlastname.Value = cliente.Apellidos;
                cmd.Parameters.Add(paramlastname);

                SqlParameter paramtelefono = new SqlParameter();
                paramtelefono.ParameterName = "@telefono";
                paramtelefono.SqlDbType = SqlDbType.VarChar;
                paramtelefono.Size = 30;
                paramtelefono.Value = cliente.Telefono;
                cmd.Parameters.Add(paramtelefono);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = cliente.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramdireccion = new SqlParameter();
                paramdireccion.ParameterName = "@direccion";
                paramdireccion.SqlDbType = SqlDbType.VarChar;
                paramdireccion.Size = 200;
                paramdireccion.Value = cliente.Direccion;
                cmd.Parameters.Add(paramdireccion);

                SqlParameter paramcp = new SqlParameter();
                paramcp.ParameterName = "@cp";
                paramcp.SqlDbType = SqlDbType.Int;
                paramcp.Value = cliente.Cp;
                cmd.Parameters.Add(paramcp);

                SqlParameter paramcolonia = new SqlParameter();
                paramcolonia.ParameterName = "@colonia";
                paramcolonia.SqlDbType = SqlDbType.VarChar;
                paramcolonia.Size = 200;
                paramcolonia.Value = cliente.Colonia;
                cmd.Parameters.Add(paramcolonia);

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
        
        // Select
        public IDataReader clienteselect()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM cliente", sqlcon);
                cmd.Connection = sqlcon;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                dr = null;
            }

            return dr;
        }
    
        public IDataReader consultarclientebyid(int id)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM cliente WHERE id = " + Convert.ToString(id), sqlcon);
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
