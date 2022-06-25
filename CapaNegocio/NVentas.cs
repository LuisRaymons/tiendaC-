using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NVentas
    {
        public static string peticiones(string tipo, int id, string factura, double preciototal, int idpago, int idcliente, int iduser)
        {
            DVenta dVenta = new DVenta();
            dVenta.Tipo = tipo;
            dVenta.Id = id;
            dVenta.Factura = factura;
            dVenta.Preciototal = preciototal;
            dVenta.Idpago = idpago;
            dVenta.Idcliente = idcliente;
            dVenta.Iduser = iduser;
            return dVenta.peticiones(dVenta);

        }
        public static DataTable peticionesData(string tipo, int id, string factura, double preciototal, int idpago, int idcliente, int iduser)
        {
            DVenta dVenta = new DVenta();
            dVenta.Tipo = tipo;
            dVenta.Id = id;
            dVenta.Factura = factura;
            dVenta.Preciototal = preciototal;
            dVenta.Idpago = idpago;
            dVenta.Idcliente = idcliente;
            dVenta.Iduser = iduser;
            return dVenta.peticionesData(dVenta);
        }
    }
}
