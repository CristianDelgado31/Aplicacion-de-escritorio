using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Verdura : Alimento
    {
        /// <summary>
        /// Atributo de la clase Verdura
        /// </summary>
        private bool seCocina;
        /// <summary>
        /// Atributo de la clase Verdura
        /// </summary>
        private bool esUnaHoja;
        /// <summary>
        /// Propiedad de la clase Verdura
        /// </summary>
        public bool SeCocina { get { return seCocina; } }
        /// <summary>
        /// Propiedad de la clase Verdura
        /// </summary>
        public bool EsUnaHoja { get { return esUnaHoja; } }
        public override void MostrarUnDato()
        {
            Console.WriteLine($"Se cocina: {seCocina}");
        }
        public Verdura()
        {

        }
        /// <summary>
        /// Constructor de la clase derivada Verdura de la clase base Alimento
        /// </summary>
        public Verdura(string nombre, Color colorDelAlimento, string codigo, string empresa, bool seCocina) : base(nombre, colorDelAlimento, codigo, empresa)
        {
            this.seCocina = seCocina;
        }
        /// <summary>
        /// Constructor de la clase derivada Verdura de la clase base Alimento
        /// </summary>
        public Verdura(string nombre, Color colorDelAlimento, string codigo, int unidades, string empresa, bool seCocina, bool esUnaHoja) : base(nombre, colorDelAlimento, codigo, unidades, empresa)
        {
            this.seCocina = seCocina;
            this.esUnaHoja = esUnaHoja;
        }
        /// <summary>
        /// Constructor de la clase derivada Verdura de la clase base Alimento
        /// </summary>
        public Verdura(string nombre, Color colorDelAlimento, string codigo, string empresa, int unidades, bool esUnaHoja, bool seCocina) : base(nombre, colorDelAlimento, codigo, empresa, unidades)
        {
            this.esUnaHoja = esUnaHoja;
            this.seCocina = seCocina;
        }
        protected override string MostrarDatos()
        {
            return $"{codigo}    {nombre}    {colorDelAlimento}    {empresa}    {unidades}    {esUnaHoja}    {seCocina}";
        }
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Verdura)
            {
                if (this == (Verdura)obj)
                {
                    result = true;
                }
            }
            return result;
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
