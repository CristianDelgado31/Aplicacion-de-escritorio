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
    public partial class FormMostrar : Form
    {
        private WinFormPrincipal principal;
        private ColeccionGenerica listaGenerica;
        public FormMostrar()
        {
            InitializeComponent();
        }
        public FormMostrar(WinFormPrincipal principal, ColeccionGenerica listaGenerica) : this()
        {
            this.principal = principal;
            this.listaGenerica = listaGenerica;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void ActualizarListBox()
        {
            this.lstMostrarLista.Items.Clear();
            foreach (Alimento producto in listaGenerica.listaAlimentos)
            {
                lstMostrarLista.Items.Add(producto.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstMostrarLista.SelectedIndex;
            if (indice == -1)
            {
                return;
            }
            Alimento p = this.listaGenerica.listaAlimentos[indice];
            WinFormAgregar frmModificar = new WinFormAgregar(p, true);
            frmModificar.ShowDialog();
            if (frmModificar.DialogResult == DialogResult.OK)
            {
                this.listaGenerica.listaAlimentos[indice] = frmModificar.alimentoNuevo;
                this.ActualizarListBox();
            }
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Aca deberia crear una ventana que diga si desea confirmar la eliminacion de dicho elemento de la lista

            int indice = this.lstMostrarLista.SelectedIndex;
            if (indice == -1)
            {
                return;
            }
            Alimento p = this.listaGenerica.listaAlimentos[indice];
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar este elemento?", "Ventana eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool eliminar = listaGenerica - p;
                if (eliminar == true)
                {
                    MessageBox.Show("Se elimino el elemento exitosamente!");
                }
                ActualizarListBox();
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            FormOrdenar frmOrdenar = new FormOrdenar();
            frmOrdenar.ShowDialog();
            if (frmOrdenar.DialogResult == DialogResult.OK)
            {
                if (frmOrdenar.ordenamiento == "ascendente")
                {
                    if (frmOrdenar.claveOrden == "nombre")
                    {
                        listaGenerica.listaAlimentos = listaGenerica.OrdenarEnFormaCreciente("nombre");
                    }
                    else
                    {
                        listaGenerica.listaAlimentos = listaGenerica.OrdenarEnFormaCreciente("unidad");
                    }
                }
                else if (frmOrdenar.ordenamiento == "descendente")
                {
                    if (frmOrdenar.claveOrden == "nombre")
                    {
                        listaGenerica.listaAlimentos = listaGenerica.OrdenarEnFormaDecreciente("nombre");
                    }
                    else
                    {
                        listaGenerica.listaAlimentos = listaGenerica.OrdenarEnFormaDecreciente("unidad");
                    }
                }
                ActualizarListBox();
            }
        }
    }
}
