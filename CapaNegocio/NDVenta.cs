using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NDVenta
    {
        public static string peticiones(string tipo, int id, int idventa, int idproducto, int cantidad, double precio)
        {
            DDVenta dVenta = new DDVenta();
            dVenta.Tipo = tipo;
            dVenta.Id = id;
            dVenta.Idventa = idventa;
            dVenta.Idproducto = idproducto;
            dVenta.Cantidad = cantidad;
            dVenta.Precio = precio;
            return dVenta.peticiones(dVenta);
        }
        public static DataTable peticionesData(string tipo, int id, int idventa, int idproducto, int cantidad, double precio)
        {
            DDVenta dVenta = new DDVenta();
            dVenta.Tipo = tipo;
            dVenta.Id = id;
            dVenta.Idventa = idventa;
            dVenta.Idproducto = idproducto;
            dVenta.Cantidad = cantidad;
            dVenta.Precio = precio;
            return dVenta.peticionesData(dVenta);
        }
    }
}
