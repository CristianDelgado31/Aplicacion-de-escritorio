using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IColeccionGenerica<T>
        where T : Alimento
    {
        List<T> OrdenarEnFormaCreciente(string clave);
        List<T> OrdenarEnFormaDecreciente(string clave);
    }
}
