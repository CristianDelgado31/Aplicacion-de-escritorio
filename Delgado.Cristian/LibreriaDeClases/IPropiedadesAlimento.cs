using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public interface IPropiedadesAlimento
    {
        public string Codigo { get; }
        public string Nombre { get; }
        public int Unidades { get; }
        public Color ColorDelAlimento { get; }
        public string Empresa { get; }

        string MostrarCodigo();
    }
}
