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

        //Métodos para ordenar la lista en asc y desc
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

        public static List<Alimento> DeserializarListaAlimentos(string ubicacionArchivo)
        {
            List<Alimento> listaAlimento = new();
            string parseo = string.Empty;
            using (StreamReader sr = new StreamReader(ubicacionArchivo))
            {
                string json_str = sr.ReadToEnd();
                parseo = json_str;
            }
            List<DeserializarArchivoAlimentos>? listaDeserializada = JsonConvert.DeserializeObject<List<DeserializarArchivoAlimentos>>(parseo, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            Verdura verdura;
            Fruta fruta;
            Carne carne;
            foreach (var item in listaDeserializada)
            {
                if (item.EsCitrico != null)
                {
                    fruta = new Fruta(item.Nombre, item.ColorDelAlimento, item.Codigo, item.Unidades, item.Empresa, (bool)item.EsCitrico, item.CascaraComestible);
                    listaAlimento.Add(fruta);
                }
                else if (item.SeCocina != null)
                {
                    verdura = new Verdura(item.Nombre, item.ColorDelAlimento, item.Codigo, item.Unidades, item.Empresa, (bool)item.SeCocina, item.EsUnaHoja);
                    listaAlimento.Add(verdura);
                }
                else
                {
                    carne = new Carne(item.Nombre, item.ColorDelAlimento, item.Codigo, item.Unidades, item.Empresa, item.OrigenDeLaCarne, item.UbicacionDelCorte);
                    listaAlimento.Add(carne);
                }
            }
            return listaAlimento;
          
        }
        public static void SerializarListaAlimentos(List<T> listaAlimentos)
        {
            string json = JsonConvert.SerializeObject(listaAlimentos, Formatting.Indented);
            File.WriteAllText("alimentos.json", json);
        }

    }
}
