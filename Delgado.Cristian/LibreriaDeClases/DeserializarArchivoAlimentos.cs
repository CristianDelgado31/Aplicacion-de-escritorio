using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class DeserializarArchivoAlimentos
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public ColorAlimento ColorDelAlimento { get; set; }
        public string Empresa { get; set; }
        public bool? EsCitrico { get; set; }
        public bool CascaraComestible { get; set; }
        public bool? SeCocina { get; set; }
        public bool EsUnaHoja { get; set; }
        public string OrigenDeLaCarne { get; set; }
        public string UbicacionDelCorte { get; set; }
    }
}
