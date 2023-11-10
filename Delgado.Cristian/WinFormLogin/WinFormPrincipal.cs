
using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios;

namespace WinFormLogin
{
    public partial class WinFormPrincipal : Form
    {
        private Login login;
        private UsuarioLogin usuario;
        private ColeccionGenerica listaGenerica;
        private List<UsuarioLogin>? registroActividad;
        private DateTime dateTime;
        private DateOnly fecha;
        public WinFormPrincipal()
        {
            listaGenerica = new ColeccionGenerica();
            registroActividad = new List<UsuarioLogin>();
            dateTime = DateTime.Now;
            fecha = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
            InitializeComponent();
        }
        public WinFormPrincipal(Login login, UsuarioLogin usuario) : this()
        {
            this.login = login;
            this.usuario = usuario;
            MostrarUsuario();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            UsuarioLogin.SerializarRegistroActividad(registroActividad);
            this.Close();
            login.Show();
        }
        private void MostrarUsuario()
        {
            lblSaludo.Text = $"Bievenido {usuario.nombre} {usuario.apellido}";
            lblPerfil.Text = $"Perfil: {usuario.perfil}";
            gbUsuario.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            WinFormAgregar winFormAgregar = new WinFormAgregar(this, listaGenerica);
            this.Hide();
            winFormAgregar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormMostrar formMostrar = new FormMostrar(this, listaGenerica);
            this.Hide();
            formMostrar.ShowDialog();
        }

        private void WinFormPrincipal_Load(object sender, EventArgs e)
        {
            string ubicacionArchivo = Directory.GetCurrentDirectory();
            string rutaAlimentos = ubicacionArchivo + @"\alimentos.json";
            if (File.Exists(rutaAlimentos))
                listaGenerica.listaAlimentos = ColeccionGenerica.DeserializarListaAlimentos(rutaAlimentos);


            string rutaRegistroUsuarios = ubicacionArchivo + @"\registroActividad.json";

            usuario.fecha = fecha;
            if (File.Exists(rutaRegistroUsuarios))
            {
                registroActividad = UsuarioLogin.DeserializarUsuarios("RegistroActividad");
                registroActividad = UsuarioLogin.LimpiarRegistroActividad(registroActividad, usuario);
            }
            else
            {
                registroActividad.Add(usuario);
            }
        }
        private void WinFormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ColeccionGenerica.SerializarListaAlimentos(listaGenerica.listaAlimentos);
            UsuarioLogin.SerializarRegistroActividad(registroActividad);
        }
        private void btnHistorialDeActividad_Click(object sender, EventArgs e)
        {
            FormHistorialActividad winFormHistorialActividad = new FormHistorialActividad(registroActividad);
            winFormHistorialActividad.Show();


        }
    }
}
