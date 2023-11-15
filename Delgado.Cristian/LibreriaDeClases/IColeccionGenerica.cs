using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public interface IColeccionGenerica<T>
    {
        List<T> OrdenarEnFormaCreciente(string clave);
        List<T> OrdenarEnFormaDecreciente(string clave);
    }
}
