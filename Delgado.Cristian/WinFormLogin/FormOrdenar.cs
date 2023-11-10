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
    public partial class FormOrdenar : Form
    {
        public string claveOrden;
        public string ordenamiento;
        public FormOrdenar()
        {
            InitializeComponent();
        }
        private void btnAscendente_Click(object sender, EventArgs e)
        {
            ordenamiento = "ascendente";
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

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            ordenamiento = "descendente";
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
