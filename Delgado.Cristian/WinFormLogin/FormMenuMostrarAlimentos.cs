﻿using BaseDeDatos;
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
    public partial class FormMenuMostrarAlimentos : Form, IPanelNavbar
    {
        private FormMenuPrincipal menuPrincipal;
        private ColeccionGenerica<Alimento> coleccionGenerica;
        List<Fruta> listFrutas;
        List<Verdura> listaVerduras;
        List<Carne> listaCarnes;
        private bool botonFrutas;
        private bool botonVerduras;
        private bool botonCarnes;
        private Alimento? alimentoSeleccionado;
        private FormMostrarListaGenerica formlistaGenerica;
        private BaseDeDatosAlimentos conexionBD;
        private bool dragging;
        private Point startPoint;

        public FormMenuMostrarAlimentos()
        {
            conexionBD = new BaseDeDatosAlimentos();
            listFrutas = new List<Fruta>();
            listaVerduras = new List<Verdura>();
            listaCarnes = new List<Carne>();
            InitializeComponent();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += ((IPanelNavbar)this).PanelNavBar_MouseDown;
            panelNavbar.MouseUp += ((IPanelNavbar)this).PanelNavBar_MouseUp;
            panelNavbar.MouseMove += ((IPanelNavbar)this).PanelNavBar_MouseMove;

        }
        public FormMenuMostrarAlimentos(FormMenuPrincipal principal, ColeccionGenerica<Alimento> coleccionGenerica, BaseDeDatosAlimentos conexionBD) : this()
        {
            this.menuPrincipal = principal;
            this.coleccionGenerica = coleccionGenerica;
            this.conexionBD = conexionBD;
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

        private void FormMostrarAlimentos_Load(object sender, EventArgs e)
        {
            ActualizarListaGenerica();
        }

        private void FormMostrarAlimentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal.Show();
        }

        private void btnFrutas_Click(object sender, EventArgs e)
        {
            dtvListaAlimentos.Visible = true;
            dtvListaAlimentos.DataSource = listFrutas;
            AjustarColumnas();
            botonFrutas = true;
            botonVerduras = false;
            botonCarnes = false;
        }

        private void btnVerduras_Click(object sender, EventArgs e)
        {
            dtvListaAlimentos.Visible = true;
            dtvListaAlimentos.DataSource = listaVerduras;
            AjustarColumnas();
            botonVerduras = true;
            botonFrutas = false;
            botonCarnes = false;
        }

        private void btnCarnes_Click(object sender, EventArgs e)
        {
            dtvListaAlimentos.Visible = true;
            dtvListaAlimentos.DataSource = listaCarnes;
            AjustarColumnas();
            botonFrutas = false;
            botonVerduras = false;
            botonCarnes = true;
        }

        private void AjustarColumnas()
        {
            dtvListaAlimentos.AutoResizeColumnHeadersHeight();
            dtvListaAlimentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtvListaAlimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dtvListaAlimentos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.dtvListaAlimentos.Rows[e.RowIndex];

                string empresa = (string)fila.Cells[6].Value;
                string codigo = (string)fila.Cells[2].Value;

                foreach (var item in coleccionGenerica.listaAlimentos)
                {
                    if (item.Empresa == empresa && item.Codigo == codigo)
                    {
                        alimentoSeleccionado = item;
                        break;
                    }
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (menuPrincipal.usuario.perfil != "vendedor")
            {
                if (alimentoSeleccionado is not null)
                {
                    FormAgregarOModificarAlimentos frmModificar = new FormAgregarOModificarAlimentos(alimentoSeleccionado, true);
                    frmModificar.ShowDialog();
                    if (frmModificar.DialogResult == DialogResult.OK)
                    {
                        if (frmModificar.alimentoNuevo is Fruta fruta)
                        {
                            conexionBD.ModificarAlimento(fruta, null, null);
                        }
                        else if (frmModificar.alimentoNuevo is Verdura verdura)
                        {
                            conexionBD.ModificarAlimento(null, verdura, null);
                        }
                        else if (frmModificar.alimentoNuevo is Carne carne)
                        {
                            conexionBD.ModificarAlimento(null, null, carne);
                        }

                        coleccionGenerica.listaAlimentos.Clear();
                        coleccionGenerica.listaAlimentos = conexionBD.CrearListaGenerica(coleccionGenerica.listaAlimentos);
                        ActualizarListaGenerica();
                        dtvListaAlimentos.Visible = false;
                        MessageBox.Show("Un elemento ha sido modificado!");
                    }
                    else
                    {
                        alimentoSeleccionado = null;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un alimento para modificar");
                }
            }
            else
            {
                MessageBox.Show("Su perfil no tiene permitido modificar registros");
                btnModificar.Enabled = false;
            }
        }

        private void ActualizarListaGenerica()
        {
            listaCarnes.Clear();
            listFrutas.Clear();
            listaVerduras.Clear();
            foreach (Alimento item in coleccionGenerica.listaAlimentos)
            {
                if (item is Fruta fruta)
                {
                    listFrutas.Add(fruta);
                }
                else if (item is Verdura verdura)
                {
                    listaVerduras.Add(verdura);
                }
                else if (item is Carne carne)
                {
                    listaCarnes.Add(carne);
                }
            }
            dtvListaAlimentos.DataSource = listFrutas;
            dtvListaAlimentos.DataSource = listaCarnes;
            dtvListaAlimentos.DataSource = listaVerduras;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (menuPrincipal.usuario.perfil == "administrador")
            {
                if (alimentoSeleccionado is not null)
                {
                    DialogResult dialogResult = MessageBox.Show($"¿Desea eliminar el registro alimento:\n Nombre: {alimentoSeleccionado.Nombre} - Codigo: {alimentoSeleccionado.Codigo} - " +
                        $"Empresa: {alimentoSeleccionado.Empresa}?", "Ventana eliminar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        conexionBD.EliminarRegistroAlimento(alimentoSeleccionado);
                        coleccionGenerica.listaAlimentos.Clear();
                        coleccionGenerica.listaAlimentos = conexionBD.CrearListaGenerica(coleccionGenerica.listaAlimentos);
                        ActualizarListaGenerica();
                        dtvListaAlimentos.Visible = false;
                        MessageBox.Show("Se elimino el elemento exitosamente!");
                    }
                    else
                    {
                        alimentoSeleccionado = null;
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un elemento para eliminar");
                }
            }
            else
            {
                MessageBox.Show("Su perfil no tiene permitido eliminar registros");
                btnEliminar.Enabled = false;
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            FormOrdenarAlimentos frmOrdenar = new FormOrdenarAlimentos();
            frmOrdenar.ShowDialog();
            if (frmOrdenar.DialogResult == DialogResult.OK)
            {
                VerificarClaveOrdenYOrdenamiento(frmOrdenar.claveOrden, frmOrdenar.ordenamiento);
                ActualizarListaGenerica();
                dtvListaAlimentos.Visible = false;
                MessageBox.Show($"Listas ordenadas por {frmOrdenar.claveOrden} en forma {frmOrdenar.ordenamiento}");
            }
        }

        private void VerificarClaveOrdenYOrdenamiento(string claveOrden, string ordenamiento)
        {
            if (claveOrden == "nombre")
            {
                if (ordenamiento == "ascendente")
                    coleccionGenerica.listaAlimentos = coleccionGenerica.OrdenarEnFormaCreciente("nombre");
                else
                    coleccionGenerica.listaAlimentos = coleccionGenerica.OrdenarEnFormaDecreciente("nombre");
            }
            else//claveOrden == "unidad"
            {
                if (ordenamiento == "descendente")
                    coleccionGenerica.listaAlimentos = coleccionGenerica.OrdenarEnFormaDecreciente("unidad");
                else
                    coleccionGenerica.listaAlimentos = coleccionGenerica.OrdenarEnFormaCreciente("unidad");
            }
        }

        private void btnGenerico_Click(object sender, EventArgs e)
        {
            formlistaGenerica = new FormMostrarListaGenerica(coleccionGenerica);
            formlistaGenerica.ShowDialog();
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
