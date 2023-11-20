
using BaseDeDatos;
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
    public partial class FormMenuPrincipal : Form
    {
        private FormLogin login;
        private Usuario usuario;
        private ColeccionGenerica<Alimento> coleccionGenerica;
        private List<USuarioLog>? listUsuariosLog;
        private USuarioLog usuarioLog;
        private FormActividadUsuarios frmMostrarRegistroActividad;
        private string ubicacionArchivo;
        private bool serializarAutomatico;
        private BaseDeDatosAlimentos conexionBD;
        private bool dragging;
        private Point startPoint;
        //private bool permisoConexionDB;

        private delegate void NotificarConexionBaseDeDatos(string mensaje);
        private event NotificarConexionBaseDeDatos mensajeConexionBD;


        public FormMenuPrincipal()
        {
            conexionBD = new BaseDeDatosAlimentos();
            ubicacionArchivo = Directory.GetCurrentDirectory();
            coleccionGenerica = new ColeccionGenerica<Alimento>();
            listUsuariosLog = new List<USuarioLog>();
            frmMostrarRegistroActividad = new FormActividadUsuarios();
            InitializeComponent();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += PanelNavBar_MouseDown;
            panelNavbar.MouseUp += PanelNavBar_MouseUp;
            panelNavbar.MouseMove += PanelNavBar_MouseMove;
        }
        public FormMenuPrincipal(FormLogin login, Usuario usuario) : this()
        {
            this.login = login;
            this.usuario = usuario;
            usuarioLog = new USuarioLog(this.usuario.nombre, this.usuario.apellido, Alimento.MostrarFechaHora(), Alimento.MostrarFechaHora("hora"));
            MostrarUsuario();
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
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarUsuario()
        {
            lblSaludo.Text = $"Bievenido {usuario.nombre} {usuario.apellido}";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Podria agregar un task
            Task hiloObtenerListaDeLaBaseDeDatos = new Task(ObtenerListaDeLaBaseDeDatos);
            hiloObtenerListaDeLaBaseDeDatos.Start();

            FormAgregarOModificarAlimentos winFormAgregar = new FormAgregarOModificarAlimentos(this, coleccionGenerica);
            this.Hide();
            winFormAgregar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            coleccionGenerica.listaAlimentos.Clear();
            coleccionGenerica.listaAlimentos = conexionBD.CrearListaGenerica(coleccionGenerica.listaAlimentos);

            FormMenuMostrarAlimentos formMostrar = new FormMenuMostrarAlimentos(this, coleccionGenerica, conexionBD);
            this.Hide();
            formMostrar.Show();
        }
        private void ObtenerListaDeLaBaseDeDatos()
        {
            coleccionGenerica.listaAlimentos = conexionBD.CrearListaGenerica(coleccionGenerica.listaAlimentos);
        }

        private void MostrarMensajeConexionBD(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void MetodoAsincronoMensajeConexionBD()
        {
            Thread.Sleep(50);
            if (conexionBD.PruebaConexion())
            {
                mensajeConexionBD += MostrarMensajeConexionBD;
                mensajeConexionBD.Invoke("Conexion exitosa con la base de datos!");
                mensajeConexionBD -= MostrarMensajeConexionBD;
            }
            else
                MessageBox.Show(conexionBD.mensajeError.ToString());
        }
        private void WinFormPrincipal_Load(object sender, EventArgs e)
        {
            if(login.permisoConexionDB == false)
            { 
                Task hiloMensajeConexionBD = new Task(MetodoAsincronoMensajeConexionBD);
                hiloMensajeConexionBD.Start();
                login.permisoConexionDB = true;
            }
            string rutaRegistroUsuarios = ubicacionArchivo + @"\registroActividad.json";

            if (File.Exists(rutaRegistroUsuarios))
            {
                listUsuariosLog = USuarioLog.DeserializarUsuariosLog();
            }
            else
            {
                listUsuariosLog.Add(usuarioLog);
                USuarioLog.SerializarRegistroActividad(listUsuariosLog);
            }
        }
        private void WinFormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serializarAutomatico == false)
            {
                listUsuariosLog = listUsuariosLog = USuarioLog.DeserializarUsuariosLog();
                listUsuariosLog.Add(usuarioLog);
            }

            USuarioLog.SerializarRegistroActividad(listUsuariosLog);
            login.Show();

        }
        private void btnHistorialDeActividad_Click(object sender, EventArgs e)
        {
            serializarAutomatico = true;
            frmMostrarRegistroActividad = new FormActividadUsuarios(listUsuariosLog, usuarioLog, this);
            this.Hide();
            if (frmMostrarRegistroActividad.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.Show();
                if (frmMostrarRegistroActividad.listaActualizada.Count > 0)
                {
                    listUsuariosLog = frmMostrarRegistroActividad.listaActualizada;
                }
                else
                {
                    serializarAutomatico = false;
                }
                frmMostrarRegistroActividad.Close();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
