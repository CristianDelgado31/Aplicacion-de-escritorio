
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
    public partial class FormMenuPrincipal : Form, IPanelNavbar
    {
        private FormLogin login;
        public Usuario usuario;
        private ColeccionGenerica<Alimento> coleccionGenerica;
        private List<USuarioLog>? listUsuariosLog;
        private USuarioLog usuarioLog;
        private FormRegistroActividadUsuarios frmMostrarRegistroActividad;
        private string ubicacionArchivo;
        private bool serializarAutomatico;
        private BaseDeDatosAlimentos conexionBD;
        private bool dragging;
        private Point startPoint;
        private delegate void NotificarConexionBaseDeDatos(string mensaje);
        private event NotificarConexionBaseDeDatos mensajeConexionBD;
        public bool usuarioNoNuevo;

        public FormMenuPrincipal()
        {
            conexionBD = new BaseDeDatosAlimentos();
            ubicacionArchivo = Directory.GetCurrentDirectory();
            coleccionGenerica = new ColeccionGenerica<Alimento>();
            listUsuariosLog = new List<USuarioLog>();
            frmMostrarRegistroActividad = new FormRegistroActividadUsuarios();
            InitializeComponent();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += ((IPanelNavbar)this).PanelNavBar_MouseDown;
            panelNavbar.MouseUp += ((IPanelNavbar)this).PanelNavBar_MouseUp;
            panelNavbar.MouseMove += ((IPanelNavbar)this).PanelNavBar_MouseMove;

        }
        public FormMenuPrincipal(FormLogin login, Usuario usuario) : this()
        {
            this.login = login;
            this.usuario = usuario;
            usuarioLog = new USuarioLog(this.usuario.nombre, this.usuario.apellido, Alimento.MostrarFechaHora(), Alimento.MostrarFechaHora("hora"));
            MostrarUsuario();
        }

        private async Task ActualizarHora()
        {
            while (true)
            {
                // Usa Task.Delay para esperar un segundo
                await Task.Delay(1000);
                // Actualiza el texto del Label con la hora actual
                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }
        void IPanelNavbar.PanelNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        void IPanelNavbar.PanelNavBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void IPanelNavbar.PanelNavBar_MouseMove(object sender, MouseEventArgs e)
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (usuario.perfil == "vendedor")
            {
                btnAgregar.Enabled = false;
                MessageBox.Show("Su perfil no permite agregar/registrar alimentos");
            }
            else
            {
                coleccionGenerica.listaAlimentos = await ObtenerListaGenericaDeLaBaseDeDatos();

                FormAgregarOModificarAlimentos winFormAgregar = new FormAgregarOModificarAlimentos(this, coleccionGenerica);
                this.Hide();
                winFormAgregar.ShowDialog();
            }
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            coleccionGenerica.listaAlimentos.Clear();
            coleccionGenerica.listaAlimentos = await ObtenerListaGenericaDeLaBaseDeDatos();

            FormMenuMostrarAlimentos formMostrar = new FormMenuMostrarAlimentos(this, coleccionGenerica, conexionBD);
            this.Hide();
            formMostrar.Show();
        }
        private async Task<List<Alimento>> ObtenerListaGenericaDeLaBaseDeDatos()
        {
            var task = new Task<List<Alimento>>(() => conexionBD.CrearListaGenerica(coleccionGenerica.listaAlimentos));
            task.Start();
            List<Alimento> lista = await task;

            return lista;

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
        private async void WinFormPrincipal_Load(object sender, EventArgs e)
        {
            if (login.permisoConexionDB == false)
            {
                Task hiloMensajeConexionBD = new Task(MetodoAsincronoMensajeConexionBD);
                hiloMensajeConexionBD.Start();
                login.permisoConexionDB = true;
            }
            string rutaRegistroUsuarios = ubicacionArchivo + @"\registroActividad.json";

            if (!File.Exists(rutaRegistroUsuarios))
            {
                listUsuariosLog.Add(usuarioLog);
                USuarioLog.SerializarRegistroActividad(listUsuariosLog);
            }
            await ActualizarHora();

        }
        private void WinFormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serializarAutomatico == false)
            {
                listUsuariosLog = USuarioLog.DeserializarUsuariosLog();
                listUsuariosLog.Add(usuarioLog);
            }

            USuarioLog.SerializarRegistroActividad(listUsuariosLog);
            login.Show();

        }
        private void btnHistorialDeActividad_Click(object sender, EventArgs e)
        {
            serializarAutomatico = true;
            frmMostrarRegistroActividad = new FormRegistroActividadUsuarios(listUsuariosLog, usuarioLog, this);

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

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
    }
}
