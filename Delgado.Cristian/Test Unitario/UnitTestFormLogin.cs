using Usuarios;
namespace Test_Unitario
{
    [TestClass]
    public class UnitTestFormLogin
    {
        [TestMethod]
        public void LogearUsuarioValido()
        {
            //Arrange
            Usuario usuario = new Usuario();
            usuario.correo = "cgorgen@vendedor.com";
            usuario.clave = "123abc45";

            List<Usuario> ListaUsuarios = Usuario.DeserializarUsuarios();

            //Act
            bool resultado = ListaUsuarios == usuario;
            
            // Assert
            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void LogearUsuarioInvalido()
        {
            //Arrange
            Usuario usuario = new Usuario();
            usuario.correo = "julian@alvarez.com";
            usuario.clave = "1111111";

            List<Usuario> ListaUsuarios = Usuario.DeserializarUsuarios();

            //Act
            bool resultado = ListaUsuarios != usuario;

            // Assert
            Assert.IsTrue(resultado);
        }


    }
}