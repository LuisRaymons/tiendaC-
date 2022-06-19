using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCompra
    {
        private string tipo;
        private int id;
        private string folio;
        private int cantidad_stock;
        private double precio_total;
        private byte[] img;
        private int productoid;
        private int promotorid;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
        public string Folio { get => folio; set => folio = value; }
        public int Cantidad_stock { get => cantidad_stock; set => cantidad_stock = value; }
        public double Precio_total { get => precio_total; set => precio_total = value; }
        public byte[] Img { get => img; set => img = value; }
        public int Productoid { get => productoid; set => productoid = value; }
        public int Promotorid { get => promotorid; set => promotorid = value; }

        public DCompra() {}
        public DCompra(string tipo, int id, string folio, int cantidad_stock, double precio_total, byte[] img, int productoid, int promotorid)
        {
            Tipo = tipo;
            Id = id;
            Folio = folio;
            Cantidad_stock = cantidad_stock;
            Precio_total = precio_total;
            Img = img;
            Productoid = productoid;
            Promotorid = promotorid;
        } 
        
        public string peticiones(DCompra compra)
        {
            string response = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paratipo = new SqlParameter();
                paratipo.ParameterName = "@tipo";
                paratipo.SqlDbType = SqlDbType.Char;
                paratipo.Size = 30;
                paratipo.Value = compra.Tipo;
                cmd.Parameters.Add(paratipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = compra.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramfolio = new SqlParameter();
                paramfolio.ParameterName = "@folio";
                paramfolio.SqlDbType = SqlDbType.VarChar;
                paramfolio.Size = 200;
                paramfolio.Value = compra.Folio;
                cmd.Parameters.Add(paramfolio);

                SqlParameter paramcantidastock = new SqlParameter();
                paramcantidastock.ParameterName = "@cantidad_stock";
                paramcantidastock.SqlDbType = SqlDbType.Int;
                paramcantidastock.Value = compra.Cantidad_stock;
                cmd.Parameters.Add(paramcantidastock);

                SqlParameter parampreciototal = new SqlParameter();
                parampreciototal.ParameterName = "@precio_total";
                parampreciototal.SqlDbType = SqlDbType.Decimal;
                parampreciototal.Precision = 10;
                parampreciototal.Scale = 2;
                parampreciototal.Value = compra.Precio_total;
                cmd.Parameters.Add(parampreciototal);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = compra.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramidproducto = new SqlParameter();
                paramidproducto.ParameterName = "@producto";
                paramidproducto.SqlDbType = SqlDbType.Int;
                paramidproducto.Value = compra.Productoid;
                cmd.Parameters.Add(paramidproducto);

                SqlParameter paramidpromotor = new SqlParameter();
                paramidpromotor.ParameterName = "@id_promotor";
                paramidpromotor.SqlDbType = SqlDbType.Int;
                paramidpromotor.Value = compra.Promotorid;
                cmd.Parameters.Add(paramidpromotor);


                return cmd.ExecuteNonQuery().ToString();

            } catch(Exception ex)
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

        public DataTable peticionesData(DCompra compra)
        {
            DataTable dt = new DataTable(); 
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                //sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paratipo = new SqlParameter();
                paratipo.ParameterName = "@tipo";
                paratipo.SqlDbType = SqlDbType.Char;
                paratipo.Size = 30;
                paratipo.Value = compra.Tipo;
                cmd.Parameters.Add(paratipo);

                SqlParameter paramid = new SqlParameter();
                paramid.ParameterName = "@id";
                paramid.SqlDbType = SqlDbType.Int;
                paramid.Value = compra.Id;
                cmd.Parameters.Add(paramid);

                SqlParameter paramfolio = new SqlParameter();
                paramfolio.ParameterName = "@folio";
                paramfolio.SqlDbType = SqlDbType.VarChar;
                paramfolio.Size = 200;
                paramfolio.Value = compra.Folio;
                cmd.Parameters.Add(paramfolio);

                SqlParameter paramcantidastock = new SqlParameter();
                paramcantidastock.ParameterName = "@cantidad_stock";
                paramcantidastock.SqlDbType = SqlDbType.Int;
                paramcantidastock.Value = compra.Cantidad_stock;
                cmd.Parameters.Add(paramcantidastock);

                SqlParameter parampreciototal = new SqlParameter();
                parampreciototal.ParameterName = "@precio_total";
                parampreciototal.SqlDbType = SqlDbType.Decimal;
                parampreciototal.Precision = 10;
                parampreciototal.Scale = 2;
                parampreciototal.Value = compra.Precio_total;
                cmd.Parameters.Add(parampreciototal);

                SqlParameter paramimg = new SqlParameter();
                paramimg.ParameterName = "@img";
                paramimg.SqlDbType = SqlDbType.Image;
                paramimg.Value = compra.Img;
                cmd.Parameters.Add(paramimg);

                SqlParameter paramidproducto = new SqlParameter();
                paramidproducto.ParameterName = "@producto";
                paramidproducto.SqlDbType = SqlDbType.Int;
                paramidproducto.Value = compra.Productoid;
                cmd.Parameters.Add(paramidproducto);

                SqlParameter paramidpromotor = new SqlParameter();
                paramidpromotor.ParameterName = "@id_promotor";
                paramidpromotor.SqlDbType = SqlDbType.Int;
                paramidpromotor.Value = compra.Promotorid;
                cmd.Parameters.Add(paramidpromotor);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            } catch(Exception ex)
            {
                dt = null;
            } finally
            {
                if(sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

            return dt;
        }
    
        public IDataReader compraByid(int id)
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlDataReader dr;
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM compra WHERE id = " + Convert.ToString(id), sqlcon);
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
