using LibreriaDeClases;
using Usuarios;

namespace WinFormLogin
{
    public partial class Login : Form
    {
        private List<UsuarioLogin>? usuarios;
        public Login()
        {
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

    }
}
