using LibreriaDeClases;
using Usuarios;
using BaseDeDatos;

namespace WinFormLogin
{
    public partial class Login : Form
    {
        private List<UsuarioLogin>? usuarios;
        private AccesoDatos conexionBD;
        private bool conexion;
        public Login()
        {
            conexionBD = new AccesoDatos();
            conexion = false;
            usuarios = UsuarioLogin.DeserializarUsuarios("login");
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validar = false;
            foreach (UsuarioLogin usuario in usuarios)
            {
                if (usuario.correo == this.txtCorreo.Text && usuario.clave == this.txtClave.Text)
                {
                    validar = true;
                    this.Hide();
                    WinFormPrincipal formPrincipal = new WinFormPrincipal(this, usuario);
                    formPrincipal.Show();
                    break;
                }
            }
            if (validar == false)
            {
                MessageBox.Show("Usuario y/o contraseña invalido/s");
            }
            txtCorreo.Clear();
            txtClave.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (conexionBD.PruebaConexion() && conexion == false)
            {
                MessageBox.Show("Conexion exitosa a la base de datos!");
                conexion = true;
            }
        }
    }
}
