using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCategoria
    {
        public static string peticiones(string peticion, int id, string nombre)
        {
            DCategoria dCategoria = new DCategoria();
            dCategoria.Tipopeticion = peticion;
            dCategoria.Id = id;
            dCategoria.Nombre = nombre;

            return dCategoria.peticiones(dCategoria);
        }

        public static DataTable peticionesData(string peticion, int id, string nombre)
        {
            DCategoria dCategoria = new DCategoria();
            dCategoria.Tipopeticion = peticion;
            dCategoria.Id = id;
            dCategoria.Nombre = nombre;

            return dCategoria.peticionesData(dCategoria);
        }

        public static IDataReader categoriasselect()
        {
            DCategoria dcategoria = new DCategoria();
            return dcategoria.categoriasselect();
        }
    }
}