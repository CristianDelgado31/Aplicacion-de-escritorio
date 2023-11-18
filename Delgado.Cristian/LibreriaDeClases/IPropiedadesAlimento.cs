using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IPropiedadesAlimento
    {
        string Codigo { get; }
        string Nombre { get; }
        int Unidades { get; }
        ColorAlimento ColorDelAlimento { get; }
        string Empresa { get; }

        string MostrarCodigo();
    }
}
