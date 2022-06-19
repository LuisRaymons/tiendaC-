using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NUsuario
    {
        public static string peticiones(string peticion, int id, string name, string email, string password, byte[] img, string type, string apitoken)
        {
            DUsuario dUsuario = new DUsuario();
            dUsuario.Tipo = peticion;
            dUsuario.Id = id;
            dUsuario.Name = name;
            dUsuario.Email = email;
            dUsuario.Password = password;
            dUsuario.Img = img;
            dUsuario.Type = type;
            dUsuario.Api_token = apitoken;

            return dUsuario.peticion(dUsuario);
        }

        public static DataTable peticionesData(string peticion, int id, string name, string email, string password, byte[] img, string type, string apitoken)
        {
            DUsuario dUsuario = new DUsuario();
            dUsuario.Tipo = peticion;
            dUsuario.Id = id;
            dUsuario.Name = name;
            dUsuario.Email = email;
            dUsuario.Password = password;
            dUsuario.Img = img;
            dUsuario.Type = type;
            dUsuario.Api_token = apitoken;

            return dUsuario.peticionData(dUsuario);
        }

        public static IDataReader categoriasselect()
        {
            DUsuario dUsuario = new DUsuario();
            return dUsuario.usuarioselect();
        }
        public static IDataReader getUserId(int id)
        {
            DUsuario dUsuario = new DUsuario();
            return dUsuario.getUserId(id);
        }
    }
}
