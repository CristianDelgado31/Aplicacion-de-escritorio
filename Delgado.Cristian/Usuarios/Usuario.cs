using Newtonsoft.Json;

namespace Usuarios
{
    public class Usuario
    {
        public string? apellido { get; set; }
        public string? nombre { get; set; }
        public int? legajo { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }
        public string? perfil { get; set; }
        public DateOnly? fecha { get; set; }

        public static List<Usuario>? DeserializarUsuarios()
        {
            string directorioActual = Directory.GetCurrentDirectory();
            Console.WriteLine(directorioActual);
            string ruta = directorioActual + @"\usuarioss.json";

            List<Usuario>? objArchivo;
            if (File.Exists(ruta))
            {
                objArchivo = JsonConvert.DeserializeObject<List<Usuario>?>(File.ReadAllText(ruta));
                return objArchivo;
            }
            return null;
        }

        public static bool operator == (List<Usuario> ListaUsuarios, Usuario usuario)
        {
            bool resultado = false;
            foreach (Usuario item in ListaUsuarios)
            {
                if(item.correo == usuario.correo && item.clave == usuario.clave)
                    resultado =  true;
            }
            return resultado;
        }
        public static bool operator !=(List<Usuario> ListaUsuarios, Usuario usuario)
        {
            return !(ListaUsuarios == usuario);
        }


    }
}