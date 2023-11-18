
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Carne : Alimento
    {
        /// <summary>
        /// Atributo de la clase Carne
        /// </summary>
        private string origenDeLaCarne;
        /// <summary>
        /// Atributo de la clase Carne
        /// </summary>
        private string ubicacionDelCorte;
        public override void MostrarUnDato()
        {
            Console.WriteLine($"Se cocina: {origenDeLaCarne}");
        }
        /// <summary>
        /// Propiedad de la clase Carne
        /// </summary>
        public string OrigenDeLaCarne { get { return origenDeLaCarne; } }
        /// <summary>
        /// Propiedad de la clase Carne
        /// </summary>
        public string UbicacionDelCorte { get { return ubicacionDelCorte; } }

        public Carne()
        {

        }
        /// <summary>
        /// Clase derivada Carne de la clase base Alimento
        /// </summary>
        public Carne(string nombre, ColorAlimento colorDelAlimento, string codigo, string empresa, string origenDeLaCarne) : base(nombre, colorDelAlimento, codigo, empresa)
        {
            this.origenDeLaCarne = origenDeLaCarne;
            this.ubicacionDelCorte = string.Empty;
        }
        /// <summary>
        /// Clase derivada Carne de la clase base Alimento
        /// </summary>
        public Carne(string nombre, ColorAlimento colorDelAlimento, string codigo, int unidades, string empresa, string origenDeLaCarne,
            string ubicacionDelCorte) : base(nombre, colorDelAlimento, codigo, unidades, empresa)
        {
            this.origenDeLaCarne = origenDeLaCarne;
            this.ubicacionDelCorte = ubicacionDelCorte;
        }
        /// <summary>
        /// Clase derivada Carne de la clase base Alimento
        /// </summary>
        public Carne(string nombre, ColorAlimento colorDelAlimento, string codigo, string empresa, int unidades, string ubicacionDelCorte,
            string origenDeLaCarne) : base(nombre, colorDelAlimento, codigo, empresa, unidades)
        {
            this.ubicacionDelCorte = ubicacionDelCorte;
            this.origenDeLaCarne = origenDeLaCarne;
        }
        protected override string MostrarDatos()
        {
            return $"{codigo}    {nombre}    {colorDelAlimento}    {empresa}    {unidades}    {origenDeLaCarne}    {ubicacionDelCorte}";
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
