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
    public partial class FormHistorialActividad : Form
    {
        private List<UsuarioLogin> registroActividad;
        public FormHistorialActividad()
        {
            registroActividad = new List<UsuarioLogin>();
            InitializeComponent();
        }
        public FormHistorialActividad(List<UsuarioLogin> registroActividad) : this()
        {
            this.registroActividad = registroActividad;
        }

        private void FormHistorialActividad_Load(object sender, EventArgs e)
        {
            lstListaActividad.Items.Clear();
            foreach (UsuarioLogin usuario in registroActividad)
            {
                StringBuilder registro = new StringBuilder();
                registro.Append($"{usuario.nombre} - {usuario.apellido} - {usuario.fecha}");
                lstListaActividad.Items.Add(registro.ToString());
            }
        }
    }
}
