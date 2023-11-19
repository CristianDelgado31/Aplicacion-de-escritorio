using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Unitario
{
    [TestClass]
    public class UnitTestFormAgregarModificarAlimentos
    {
        [TestMethod]
        public void VerificarAlimentoIngresadoNuevo()
        {
            //Arrange
            ColeccionGenerica<Alimento> coleccionGenerica = new ColeccionGenerica<Alimento>();
            Alimento alimentoNuevo = new Verdura("Pepino", ColorAlimento.Verde, "CJD31", 11, "VerduleriaElAmigo", false, false);
            
            //Act
            bool resultado = coleccionGenerica + alimentoNuevo;

            //Assert
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarAlimentoIngresadoRepetido()
        {
            //Arrange
            ColeccionGenerica<Alimento> coleccionGenerica = new ColeccionGenerica<Alimento>();
            Alimento alimentoNuevo = new Verdura("Pepino", ColorAlimento.Verde, "CJD31", 11, "VerduleriaElAmigo", false, false);
            coleccionGenerica.listaAlimentos.Add(alimentoNuevo);

            //Act
            bool resultado = coleccionGenerica + alimentoNuevo;

            //Assert
            Assert.IsFalse(resultado);
        }
    }
}
