using Newtonsoft.Json;

namespace Usuarios
{
    public class UsuarioLogin
    {
        public string? apellido { get; set; }
        public string? nombre { get; set; }
        public int? legajo { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }
        public string? perfil { get; set; }
        public DateOnly? fecha { get; set; }

        public static List<UsuarioLogin>? DeserializarUsuarios(string clave)
        {
            string directorioActual = Directory.GetCurrentDirectory();
            string ruta;
            if (clave == "login")
            {
                ruta = directorioActual + @"\usuarioss.json";
            }
            else
            {
                ruta = directorioActual + @"\registroActividad.json";
            }
            List<UsuarioLogin>? objArchivo;
            if (File.Exists(ruta))
            {
                objArchivo = JsonConvert.DeserializeObject<List<UsuarioLogin>?>(File.ReadAllText(ruta));
                return objArchivo;
            }
            return null;
        }
        /// <summary>
        /// método que serializa la actividad de los usuarios ingresados en la aplicación
        /// </summary>
        /// <param name="registros">Lista UsuarioLogin que cumple como registro</param>
        public static void SerializarRegistroActividad(List<UsuarioLogin> registros)
        {
            string json = JsonConvert.SerializeObject(registros, Formatting.Indented);
            File.WriteAllText("registroActividad.json", json);
        }
        /// <summary>
        /// Constructor de operador de la clase UsuarioLogin que compara atributos
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns>true si son iguales los atributos, false de lo contrario</returns>
        public static bool operator ==(UsuarioLogin u1,  UsuarioLogin u2)
        {
            return u1.nombre == u2.nombre && u1.fecha == u2.fecha;
        }
        public static bool operator !=(UsuarioLogin u1, UsuarioLogin u2)
        {
            return !(u1 == u2);
        }

        public override bool Equals(object? obj)
        {
            bool resultado = false;
            if (obj is UsuarioLogin)
            {
                if(this == (UsuarioLogin)obj) 
                    resultado = true;
            }
            return resultado;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Método estatico que compara mediante atributos si el usuario ingresado recienmente esta en la lista UsuarioLogin
        /// </summary>
        /// <param name="lista">Lista usuarioLogin</param>
        /// <param name="usuarioIngresado">Usuario ingresado recienmente</param>
        /// <returns>Lista UsuarioLogin</returns>
        public static List<UsuarioLogin> LimpiarRegistroActividad(List<UsuarioLogin> lista, UsuarioLogin usuarioIngresado)
        {
            if (!lista.Contains(usuarioIngresado))
                lista.Add(usuarioIngresado);
            return lista;
        }

    }
}