using LibreriaDeClases;
using Usuarios;

namespace WinFormLogin
{
    public partial class FormLogin : Form
    {
        private List<Usuario>? usuarios;
        private FormMenuPrincipal formPrincipal;
        public FormLogin()
        {
            usuarios = Usuario.DeserializarUsuarios();
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validar = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.correo == this.txtCorreo.Text && usuario.clave == this.txtClave.Text)
                {
                    validar = true;
                    this.Hide();
                    formPrincipal = new FormMenuPrincipal(this, usuario);
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

        //Cierrro el form principal desde el form login

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.Close();
        }
    }
}
