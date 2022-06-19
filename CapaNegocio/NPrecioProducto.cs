using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NPrecioProducto
    {
        public static string peticiones(string tipo, int id, double precio, int producto, string search)
        {
            DPrecioProducto dp = new DPrecioProducto();
            dp.Tipo = tipo;
            dp.Id = id;
            dp.Precio = precio;
            dp.Productoid = producto;
            dp.Search = search;
            return dp.peticiones(dp);
        }

        public static DataTable peticionesData(string tipo, int id, double precio, int producto, string search)
        {
            DPrecioProducto dp = new DPrecioProducto();
            dp.Tipo = tipo;
            dp.Id = id;
            dp.Precio = precio;
            dp.Productoid = producto;
            dp.Search = search;
            return dp.peticionesData(dp);
        }

        public static IDataReader obtenerpreciobyid(int id)
        {
            DPrecioProducto dp = new DPrecioProducto();
            return dp.obtenerpreciobyid(id);
        }
    }
}
