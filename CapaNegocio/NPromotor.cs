using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NPromotor
    {
        public static string peticiones(string tipo, int id, string nombre, string direccion, string telefono, string sitioweb, byte[] img)
        {
            DPromotor dpromotor = new DPromotor();
            dpromotor.Tipo = tipo;
            dpromotor.Id = id;
            dpromotor.Nombre = nombre;
            dpromotor.Direccion = direccion;
            dpromotor.Telefono = telefono;
            dpromotor.Sitioweb = sitioweb;
            dpromotor.Img = img;

            return dpromotor.peticiones(dpromotor);
        }

        public static DataTable peticionesData(string tipo, int id, string nombre, string direccion, string telefono, string sitioweb, byte[] img)
        {
            DPromotor dpromotor = new DPromotor();
            dpromotor.Tipo = tipo;
            dpromotor.Id = id;
            dpromotor.Nombre = nombre;
            dpromotor.Direccion = direccion;
            dpromotor.Telefono = telefono;
            dpromotor.Sitioweb = sitioweb;
            dpromotor.Img = img;
            return dpromotor.peticionesData(dpromotor);
        }

        public static IDataReader promotorselect()
        {
            DPromotor dpromotor = new DPromotor();
            return dpromotor.promotorselect();
        }

        public static IDataReader promotorbyid(int id)
        {
            DPromotor dpromotor = new DPromotor();
            return dpromotor.promotorbyid(id);
        }

    }
}
