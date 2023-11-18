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
            string ruta = directorioActual + @"\usuarioss.json";

            List<Usuario>? objArchivo;
            if (File.Exists(ruta))
            {
                objArchivo = JsonConvert.DeserializeObject<List<Usuario>?>(File.ReadAllText(ruta));
                return objArchivo;
            }
            return null;
        }


    }
}