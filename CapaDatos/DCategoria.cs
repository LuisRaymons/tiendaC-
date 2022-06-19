using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCategoria
    {
        private string tipopeticion;
        private int id;
        private string nombre;

        public string Tipopeticion { get => tipopeticion; set => tipopeticion = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public DCategoria() {}
        public DCategoria(string tipopeticion, int id, string nombre)
        {
            this.Tipopeticion = tipopeticion;
            this.Id = id;
            this.Nombre = nombre;
        }

        // Peticciones Insert, update,delete
        public string peticiones(DCategoria categoria)
        {
            string response = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = categoria.Tipopeticion;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = categoria.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@nombre";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 200;
                paramname.Value = categoria.Nombre;
                cmd.Parameters.Add(paramname);

                response = cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }
            finally
            {
                if(sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

            return response;
        }

        // Peticiones de datatable o busqueda por nombre
        public DataTable peticionesData(DCategoria categoria)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                //sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramtipo = new SqlParameter();
                paramtipo.ParameterName = "@tipo";
                paramtipo.SqlDbType = SqlDbType.Char;
                paramtipo.Size = 30;
                paramtipo.Value = categoria.Tipopeticion;
                cmd.Parameters.Add(paramtipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = categoria.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramname = new SqlParameter();
                paramname.ParameterName = "@nombre";
                paramname.SqlDbType = SqlDbType.VarChar;
                paramname.Size = 200;
                paramname.Value = categoria.Nombre;
                cmd.Parameters.Add(paramname);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

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
        public IDataReader categoriasselect()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM categoria_producto", sqlcon);
                cmd.Connection = sqlcon;
                dr = cmd.ExecuteReader();
            } catch(Exception ex)
            {
                dr = null;
            }
            /*
            finally
            {
                if(sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            */
            return dr;
        }
    
    }
}
