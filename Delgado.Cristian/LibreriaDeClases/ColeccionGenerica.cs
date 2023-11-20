using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibreriaDeClases
{
    public class ColeccionGenerica<T> : IColeccionGenerica<T>
     where T : Alimento
    {
        public List<T> listaAlimentos;
        public ColeccionGenerica()
        {
            listaAlimentos = new List<T>();
        }
        public static bool operator +(ColeccionGenerica<T> coleccion, T alimentoIngresado)
        {
            bool resultado = true;
            if (coleccion.listaAlimentos.Contains(alimentoIngresado))
            {
                resultado = false;
            }
            if (resultado == true)
            {
                coleccion.listaAlimentos.Add(alimentoIngresado);
            }

            return resultado;
        }
        public static bool operator -(ColeccionGenerica<T> coleccion, T alimentoIngresado)
        {
            bool resultado = false;
            if (coleccion.listaAlimentos.Contains(alimentoIngresado))
            {
                coleccion.listaAlimentos.Remove(alimentoIngresado);
                resultado = true;
            }
            return resultado;
        }

        public List<T> OrdenarEnFormaCreciente(string clave)
        {
            if (clave == "nombre")
            {
                listaAlimentos = listaAlimentos.OrderBy(a => a.Nombre).ToList();
            }
            else if (clave == "unidad")
            {
                listaAlimentos = listaAlimentos.OrderBy(a => a.Unidades).ToList();
            }
            return listaAlimentos;
        }
        public List<T> OrdenarEnFormaDecreciente(string clave)
        {
            if (clave == "nombre")
            {
                listaAlimentos = listaAlimentos.OrderByDescending(a => a.Nombre).ToList();
            }
            else if (clave == "unidad")
            {
                listaAlimentos = listaAlimentos.OrderByDescending(a => a.Unidades).ToList();
            }
            return listaAlimentos;
        }
        public static void SerializarListaAlimentos(List<T> listaAlimentos)
        {
            string json = JsonConvert.SerializeObject(listaAlimentos, Formatting.Indented);
            File.WriteAllText("alimentos.json", json);
        }

    }
}
