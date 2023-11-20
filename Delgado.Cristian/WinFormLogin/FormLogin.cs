using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios;

namespace WinFormLogin
{
    public partial class FormLogin : Form
    {
        public delegate void NotificarDatosIngresados(string mensaje);
        public event NotificarDatosIngresados MostrarNotificacion; 

        private bool dragging;
        private Point startPoint;
        private List<Usuario>? usuarios;
        private FormMenuPrincipal formPrincipal;
        public bool permisoConexionDB;

        public FormLogin()
        {
            permisoConexionDB = false;
            InitializeComponent();
            usuarios = Usuario.DeserializarUsuarios();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += PanelNavBar_MouseDown;
            panelNavbar.MouseUp += PanelNavBar_MouseUp;
            panelNavbar.MouseMove += PanelNavBar_MouseMove;
        }
        private void PanelNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void PanelNavBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void PanelNavBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = PointToScreen(p1);
                Point p3 = new Point(p2.X - startPoint.X, p2.Y - startPoint.Y);
                Location = p3;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            bool validar = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.correo == this.txtCorreo.Text && usuario.clave == this.txtContrasenia.Text)
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
                MostrarNotificacion += MensajeDatosInvalidos;
                MostrarNotificacion.Invoke("Usuario y/o contraseña invalido/s");
                MostrarNotificacion -= MensajeDatosInvalidos;
            }
            txtCorreo.Clear();
            txtContrasenia.Clear();
        }

        private void MensajeDatosInvalidos(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}
