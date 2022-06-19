using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCliente
    {
        public static string peticiones(string peticion, int id, string nombre, string apellidos, string telefono, byte[] img, string direccion, int cp, string colonia)
        {
            DCliente dcliente = new DCliente();
            dcliente.Tipo = peticion;
            dcliente.Id = id;
            dcliente.Nombre = nombre;
            dcliente.Apellidos = apellidos;
            dcliente.Telefono = telefono;
            dcliente.Img = img;
            dcliente.Direccion = direccion;
            dcliente.Cp = cp;
            dcliente.Colonia = colonia;

            return dcliente.peticiones(dcliente);

        }

        public static DataTable peticionesData(string peticion, int id, string nombre, string apellidos, string telefono, byte[] img, string direccion, int cp, string colonia)
        {
            DCliente dcliente = new DCliente();
            dcliente.Tipo = peticion;
            dcliente.Id = id;
            dcliente.Nombre = nombre;
            dcliente.Apellidos = apellidos;
            dcliente.Telefono = telefono;
            dcliente.Img = img;
            dcliente.Direccion = direccion;
            dcliente.Cp = cp;
            dcliente.Colonia = colonia;

            return dcliente.peticionesData(dcliente);
        }

        public static IDataReader categoriasselect()
        {
            DCliente dcliente = new DCliente();
            return dcliente.clienteselect();
        }

        public static IDataReader consultarclientebyid(int id)
        {
            DCliente dcliente = new DCliente();
            return dcliente.consultarclientebyid(id);
        }


    }
}
