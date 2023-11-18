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

namespace WinFormLogin
{
    public partial class FormOrdenarAlimentos : Form
    {
        public string claveOrden;
        public string ordenamiento;
        public FormOrdenarAlimentos()
        {
            InitializeComponent();
        }
        private void btnAscendente_Click(object sender, EventArgs e)
        {
            ordenamiento = "ascendente";
            VerificarDatos();
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            ordenamiento = "descendente";
            VerificarDatos();
        }

        private void VerificarDatos()
        {
            if (rbtnNombre.Checked)
            {
                claveOrden = "nombre";
            }
            else if (rbtnUnidad.Checked)
            {
                claveOrden = "unidad";
            }
            if (claveOrden != "")
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
