using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public abstract class Alimento
    {
        /// <summary>
        /// Atributo de la clase Alimento y sus clases derivadas.
        /// </summary>
        protected string nombre;
        /// <summary>
        /// Atributo de la clase Alimento y sus clases derivadas.
        /// </summary>
        protected Color colorDelAlimento;
        /// <summary>
        /// Atributo de la clase Alimento y sus clases derivadas.
        /// </summary>
        protected string codigo;
        /// <summary>
        /// Atributo de la clase Alimento y sus clases derivadas.
        /// </summary>
        protected int unidades;
        /// <summary>
        /// Atributo de la clase Alimento y sus clases derivadas.
        /// </summary>
        protected string empresa;

        /// <summary>
        /// Método abstracto de la clase Alimento e implementada en las clases derivadas
        /// </summary>
        #region Método abstracto
        public abstract void MostrarUnDato();
        #endregion

        #region Propiedades publicas
        /// <summary>
        /// Propiedad de la clase Alimento y de las clases derivadas
        /// </summary>
        public string Codigo { get { return codigo; } }
        /// <summary>
        /// Propiedad de la clase Alimento y de las clases derivadas
        /// </summary>
        public string Nombre { get { return nombre; } }
        /// <summary>
        /// Propiedad de la clase Alimento y de las clases derivadas
        /// </summary>
        public int Unidades { get { return unidades; } }
        /// <summary>
        /// Propiedad de la clase Alimento y de las clases derivadas
        /// </summary>
        public Color ColorDelAlimento { get { return colorDelAlimento; } }
        /// <summary>
        /// Propiedad de la clase Alimento y de las clases derivadas
        /// </summary>
        public string Empresa { get { return empresa; } }

        #endregion

        public Alimento()
        {

        }
        #region Constructores sobrecargados
        /// <summary>
        /// Constructor de la clase Alimento
        /// </summary>
        public Alimento(string nombre, Color colorDelAlimento, string codigo, string empresa)
        {
            this.nombre = nombre;
            this.colorDelAlimento = colorDelAlimento;
            this.codigo = codigo;
            this.empresa = empresa;
            this.unidades = 1;
        }
        /// <summary>
        /// Constructor de la clase Alimento
        /// </summary>
        public Alimento(string nombre, Color colorDelAlimento, string codigo, int unidades, string empresa)
        {
            this.nombre = nombre;
            this.colorDelAlimento = colorDelAlimento;
            this.codigo = codigo;
            this.unidades = unidades;
            this.empresa = empresa;
        }
        /// <summary>
        /// Constructor de la clase Alimento
        /// </summary>
        public Alimento(string nombre, Color colorDelAlimento, string codigo, string empresa, int unidades)
        {
            this.nombre = nombre;
            this.colorDelAlimento = colorDelAlimento;
            this.codigo = codigo;
            this.empresa = empresa;
            this.unidades = unidades;
        }
        #endregion

        public string MostrarCodigo()
        {
            return codigo;
        }

        #region Método virtual
        /// <summary>
        /// Método virtual de la clase Alimento y modificada en sus clases derivadas
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            return $"Nombre: {nombre} - Color del alimento: {colorDelAlimento} - Codigo: {codigo} - Unidades: {unidades}";
        }
        #endregion
        /// <summary>
        /// Compara si dos objetos son del mismo tipo
        /// </summary>
        /// <param name="obj">objeto para ser comparado</param>
        /// <returns>Retorna true si son iguales, false por el contrario</returns>
        #region Polimorfismo de Equals y ToString
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Alimento)
            {
                if (this == (Alimento)obj)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// Muestra una cadena de texto de los atributos del alimento
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return MostrarDatos();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Compara si dos alimentos son iguales en los atributos codigo y empresa.
        /// </summary>
        /// <param name="a">Alimento a</param>
        /// <param name="b">Alimento b</param>
        /// <returns>true, si son iguales, de lo contrario false</returns>
        public static bool operator ==(Alimento a, Alimento b)
        {
            return a.codigo == b.codigo && a.empresa == b.empresa;
        }
        /// <summary>
        /// Compara si dos alimentos son distintos.
        /// </summary>
        /// <param name="a">Alimento a</param>
        /// <param name="b">Alimento b</param>
        /// <returns>true si son distintos, de lo contrario false</returns>
        public static bool operator !=(Alimento a, Alimento b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Retorna el atributo empresa del objeto de tipo Alimento
        /// </summary>
        /// <param name="a">Objeto alimento</param>
        public static implicit operator string(Alimento a)
        {
            return a.Empresa;
        }
        /// <summary>
        /// Retornar las unidades del objeto tipo Alimento
        /// </summary>
        /// <param name="a">Alimento</param>
        public static explicit operator int(Alimento a)
        {
            return a.Unidades;
        }
        #endregion

        #region Sobrecarga de métodos
        public string MostrarDatoIngresado(string dato)
        {
            return dato;
        }
        public int MostrarDatoIngresado(int dato)
        {
            return dato;
        }
        #endregion
    }
}
