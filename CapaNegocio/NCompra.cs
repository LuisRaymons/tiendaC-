using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCompra
    {
        public static string peticiones(string tipo, int id, string folio, int cantidad_stock, double precio_total, byte[] img, int productoid, int promotorid)
        {
            DCompra dCompra = new DCompra();
            dCompra.Tipo = tipo;
            dCompra.Id = id;
            dCompra.Folio = folio;
            dCompra.Cantidad_stock = cantidad_stock;
            dCompra.Precio_total = precio_total;
            dCompra.Img = img;
            dCompra.Productoid = productoid;
            dCompra.Promotorid = promotorid;

            return dCompra.peticiones(dCompra);

        }

        public static DataTable peticionesData(string tipo, int id, string folio, int cantidad_stock, double precio_total, byte[] img, int productoid, int promotorid)
        {
            DCompra dCompra = new DCompra();
            dCompra.Tipo = tipo;
            dCompra.Id = id;
            dCompra.Folio = folio;
            dCompra.Cantidad_stock = cantidad_stock;
            dCompra.Precio_total = precio_total;
            dCompra.Img = img;
            dCompra.Productoid = productoid;
            dCompra.Promotorid = promotorid;

            return dCompra.peticionesData(dCompra);
        }
    
        public static IDataReader compraByid(int id)
        {
            DCompra dcompra = new DCompra();
            return dcompra.compraByid(id);
        }
    }
}
