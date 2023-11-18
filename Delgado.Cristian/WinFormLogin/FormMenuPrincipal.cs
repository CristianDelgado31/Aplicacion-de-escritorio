
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
        private DateTime dateTime;
        private DateOnly fecha;
        private List<USuarioLog>? listUsuariosLog;
        private USuarioLog usuarioLog;
        private FormMostrarRegistroActividad frmMostrarRegistroActividad;
        private string ubicacionArchivo;
        private bool serializarAutomatico;
        private BaseDeDatosAlimentos conexionBD;


        public FormMenuPrincipal()
        {
            conexionBD = new BaseDeDatosAlimentos();
            ubicacionArchivo = Directory.GetCurrentDirectory();
            coleccionGenerica = new ColeccionGenerica<Alimento>();
            listUsuariosLog = new List<USuarioLog>();
            frmMostrarRegistroActividad = new FormMostrarRegistroActividad();
            dateTime = DateTime.Now;
            fecha = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
            InitializeComponent();
        }
        public FormMenuPrincipal(FormLogin login, Usuario usuario) : this()
        {
            this.login = login;
            this.usuario = usuario;
            usuarioLog = new USuarioLog(this.usuario.nombre, this.usuario.apellido, Alimento.MostrarFechaHora(), Alimento.MostrarFechaHora("hora"));
            MostrarUsuario();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarUsuario()
        {
            lblSaludo.Text = $"Bievenido {usuario.nombre} {usuario.apellido}";
            lblPerfil.Text = $"Perfil: {usuario.perfil}";
            gbUsuario.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            coleccionGenerica.listaAlimentos = conexionBD.CrearListaGenerica(coleccionGenerica.listaAlimentos);
            FormAgregarOModificarAlimentos winFormAgregar = new FormAgregarOModificarAlimentos(this, coleccionGenerica);
            this.Hide();
            winFormAgregar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            coleccionGenerica.listaAlimentos.Clear();
            coleccionGenerica.listaAlimentos = conexionBD.CrearListaGenerica(coleccionGenerica.listaAlimentos);
            FormMostrarAlimentos formMostrar = new FormMostrarAlimentos(this, coleccionGenerica, conexionBD);
            this.Hide();
            formMostrar.Show();
        }

        private void WinFormPrincipal_Load(object sender, EventArgs e)
        {
            //string rutaAlimentos = ubicacionArchivo + @"\alimentos.json";
            //if (File.Exists(rutaAlimentos))
            //    coleccionGenerica.listaAlimentos = ColeccionGenerica<Alimento>.DeserializarListaAlimentos(rutaAlimentos);


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
            //ColeccionGenerica<Alimento>.SerializarListaAlimentos(coleccionGenerica.listaAlimentos);
            USuarioLog.SerializarRegistroActividad(listUsuariosLog);
            login.Show();

        }
        private void btnHistorialDeActividad_Click(object sender, EventArgs e)
        {
            serializarAutomatico = true;
            frmMostrarRegistroActividad = new FormMostrarRegistroActividad(listUsuariosLog, usuarioLog, this);
            this.Hide();
            if(frmMostrarRegistroActividad.ShowDialog() == DialogResult.OK)
            {
                
            }
            else
            {
                this.Show();
                if(frmMostrarRegistroActividad.listaActualizada.Count > 0) 
                {
                    listUsuariosLog = frmMostrarRegistroActividad.listaActualizada;
                }
                else
                {
                    serializarAutomatico=false;
                }
                frmMostrarRegistroActividad.Close();
            }

        }
    }
}
