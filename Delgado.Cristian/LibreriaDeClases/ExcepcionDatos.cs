using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionDatos: Exception
    {
        string datoIngresado;
        public ExcepcionDatos(string mensaje, string datoIngresado):base(mensaje) 
        {
            this.datoIngresado = datoIngresado;
        }

        public string DatoIngresado
        {
            get { return this.datoIngresado;}
        }
    }
}
