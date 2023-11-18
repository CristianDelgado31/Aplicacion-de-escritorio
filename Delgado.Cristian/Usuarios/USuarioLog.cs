using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public class USuarioLog
    {
        private string nombre;
        private string apellido;
        private DateOnly fecha;
        private string hora;

        public USuarioLog(string nombre, string apellido, DateOnly fecha, string hora)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.hora = hora;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateOnly Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }

        public static List<USuarioLog>? DeserializarUsuariosLog()
        {
            string directorioActual = Directory.GetCurrentDirectory();
            string ruta = directorioActual + @"\registroActividad.json";
            List<USuarioLog>? objArchivo;
            if (File.Exists(ruta))
            {
                objArchivo = JsonConvert.DeserializeObject<List<USuarioLog>?>(File.ReadAllText(ruta));
                return objArchivo;
            }
            return null;
        }
        /// <summary>
        /// método que serializa la actividad de los usuarios ingresados en la aplicación
        /// </summary>
        /// <param name="registros">Lista UsuarioLogin que cumple como registro</param>
        public static void SerializarRegistroActividad(List<USuarioLog> registros)
        {
            string json = JsonConvert.SerializeObject(registros, Formatting.Indented);
            File.WriteAllText("registroActividad.json", json);
        }

        public static bool operator == (USuarioLog u1,  USuarioLog u2)
        {
            return u1.hora == u2.hora;
        }
        public static bool operator !=(USuarioLog a, USuarioLog u2)
        {
            return !(a == u2);
        }
    }
}
