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
    public partial class FormMostrarListaGenerica : Form
    {
        private FormMostrarAlimentos formMostrarAlimentos;
        private ColeccionGenerica<Alimento> coleccionGenerica;
        public FormMostrarListaGenerica()
        {
            InitializeComponent();
        }
        public FormMostrarListaGenerica(FormMostrarAlimentos formMostrarAlimentos, ColeccionGenerica<Alimento> coleccionGenerica) : this()
        {
            this.formMostrarAlimentos = formMostrarAlimentos;
            this.coleccionGenerica = coleccionGenerica;
        }

        private void FormMostrarListaGenerica_Load(object sender, EventArgs e)
        {
            foreach (Alimento item in coleccionGenerica.listaAlimentos)
            {
                lstListaGenerica.Items.Add(item.ToString());
            }
        }
    }
}
