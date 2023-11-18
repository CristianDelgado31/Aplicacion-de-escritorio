using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Fruta : Alimento
    {
        /// <summary>
        /// Atributo de la clase Fruta
        /// </summary>
        private bool esCitrico;
        /// <summary>
        /// Atributo de la clase Fruta
        /// </summary>
        private bool cascaraComestible;
        public override void MostrarUnDato()
        {
            Console.WriteLine(nombre);
        }

        /// <summary>
        /// Propiedad de la clase Fruta
        /// </summary>
        public bool EsCitrico { get { return esCitrico; } }
        /// <summary>
        /// Propiedad de la clase Fruta
        /// </summary>
        public bool CascaraComestible { get { return cascaraComestible; } }
        public Fruta()
        {

        }
        /// <summary>
        /// Clase derivada Fruta de la clase base Alimento
        /// </summary>
        public Fruta(string nombre, ColorAlimento colorDelAlimento, string codigo, string empresa, int unidades, bool cascaraComestible) : base(nombre, colorDelAlimento, codigo, empresa, unidades)
        {
            this.cascaraComestible = cascaraComestible;
        }
        /// <summary>
        /// Clase derivada Fruta de la clase base Alimento
        /// </summary>
        public Fruta(string nombre, ColorAlimento colorDelAlimento, string codigo, int unidades, string empresa, bool esCitrico, bool cascaraComestible) : base(nombre, colorDelAlimento, codigo, empresa, unidades)
        {
            this.esCitrico = esCitrico;
            this.cascaraComestible = cascaraComestible;
        }
        /// <summary>
        /// Clase derivada Fruta de la clase base Alimento
        /// </summary>
        public Fruta(string nombre, ColorAlimento colorDelAlimento, string codigo, string empresa, bool esCitrico, int unidades) : base(nombre, colorDelAlimento, codigo, empresa, unidades)
        {
            this.esCitrico = esCitrico;
        }
        protected override string MostrarDatos()
        {
            return $"{codigo}    {nombre}    {colorDelAlimento}    {empresa}    {unidades}    {esCitrico}    {cascaraComestible}";
        }

        public override string ToString()
        {
            return MostrarDatos();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
