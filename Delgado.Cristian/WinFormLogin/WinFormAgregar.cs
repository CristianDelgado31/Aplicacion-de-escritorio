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
using BaseDeDatos;

namespace WinFormLogin
{
    public partial class WinFormAgregar : Form
    {
        private WinFormPrincipal winPrincipal;
        private Alimento alimentoAModificar;
        public Alimento alimentoNuevo;
        private ColeccionGenerica<Alimento> listaGenerica;
        private bool modificar;
        private AccesoDatos conexionBD;

        public WinFormAgregar()
        {
            conexionBD = new AccesoDatos();
            InitializeComponent();
        }
        public WinFormAgregar(WinFormPrincipal winFormPrincipal, ColeccionGenerica<Alimento> listaGenerica) : this()
        {
            this.winPrincipal = winFormPrincipal;
            this.listaGenerica = listaGenerica;
        }
        public WinFormAgregar(Alimento alimentoSeleccionado, bool modificar) : this()
        {
            this.alimentoAModificar = alimentoSeleccionado;
            this.modificar = modificar;
        }

        private void Verificar()
        {
            int unidad;
            bool verificarUnidad = int.TryParse(txtUnidad.Text, out unidad);
            Color[] arrColores = (Color[])Enum.GetValues(typeof(Color));
            Color color = new Color();
            foreach (Color elemento in arrColores)
            {
                if (elemento.ToString() == cmbColores.Text)
                {
                    color = elemento;
                    break;
                }
            }
            if (rbtnCarne.Checked)
            {
                if (verificarUnidad && unidad > 0)
                {
                    alimentoNuevo = new Carne(txtNombre.Text, color, txtCodigo.Text, unidad, txtEmpresa.Text, txtOrigen.Text, txtUbicacionCorte.Text);
                }
                else
                    MessageBox.Show("Ingrese un numero en el texto Unidad");
            }
            else if (rbtnFruta.Checked)
            {
                bool cascaraComestible = false;
                bool citrico = false;
                if (rbtnSiCitrico.Checked)
                    citrico = true;
                if (rbtnSiComestible.Checked)
                    cascaraComestible = true;
                if (verificarUnidad && unidad > 0)
                {
                    alimentoNuevo = new Fruta(txtNombre.Text, color, txtCodigo.Text, unidad, txtEmpresa.Text, citrico, cascaraComestible);
                }
                else
                    MessageBox.Show("Ingrese un numero en el texto Unidad");
            }
            else
            {
                bool esUnaHoja = false;
                bool seCocina = false;
                if (rbtnSiCocina.Checked)
                    seCocina = true;
                if (rbtnSiHoja.Checked)
                    esUnaHoja = true;
                if (verificarUnidad == true && unidad > 0)
                {
                    alimentoNuevo = new Verdura(txtNombre.Text, color, txtCodigo.Text, unidad, txtEmpresa.Text, seCocina, esUnaHoja);
                }
                else
                    MessageBox.Show("Ingrese un numero en el texto Unidad");
            }

            if (modificar == false && txtNombre.Text != "" && txtCodigo.Text != "" && txtEmpresa.Text != "" && txtUnidad.Text != "" && unidad > 0)
            {
                if (listaGenerica.listaAlimentos.Contains(alimentoNuevo))
                {
                    MessageBox.Show("Este alimento ya se encuentra en la lista");
                }
                else
                {
                    //listaGenerica.listaAlimentos.Add(alimentoNuevo);
                    bool agregar = listaGenerica + alimentoNuevo;
                    if (agregar == true)
                    {
                        if (alimentoNuevo is Fruta fruta)
                            conexionBD.AgregarAlimento(fruta, null, null);
                        else if (alimentoNuevo is Verdura verdura)
                            conexionBD.AgregarAlimento(null, verdura, null);
                        else if (alimentoNuevo is Carne carne)
                            conexionBD.AgregarAlimento(null, null, carne);

                        MessageBox.Show("Se agrego un nuevo alimento");
                    }
                }
            }
            else if (modificar == true && txtNombre.Text != "" && txtCodigo.Text != "" && txtEmpresa.Text != "" && txtUnidad.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Verificar();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            winPrincipal.Show();
        }


        private void rbtnCarne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCarne.Checked)
            {
                gbVerdura.Enabled = false;
                rbtnSiCocina.Checked = false;
                rbtnNoCocina.Checked = false;
                rbtnSiHoja.Checked = false;
                rbtnNoHoja.Checked = false;

                gbFruta.Enabled = false;
                rbtnSiCitrico.Checked = false;
                rbtnNoCitrico.Checked = false;
                rbtnSiComestible.Checked = false;
                rbtnNoComestible.Checked = false;

                gbCarne.Enabled = true;

            }
        }
        private void rbtnVerdura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVerdura.Checked)
            {
                gbCarne.Enabled = false;
                txtOrigen.Text = string.Empty;
                txtUbicacionCorte.Text = string.Empty;

                gbFruta.Enabled = false;
                rbtnSiCitrico.Checked = false;
                rbtnNoCitrico.Checked = false;
                rbtnSiComestible.Checked = false;
                rbtnNoComestible.Checked = false;

                gbVerdura.Enabled = true;
            }
        }

        private void rbtnFruta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFruta.Checked)
            {
                gbVerdura.Enabled = false;
                rbtnSiCocina.Checked = false;
                rbtnNoCocina.Checked = false;
                rbtnSiHoja.Checked = false;
                rbtnNoHoja.Checked = false;

                gbCarne.Enabled = false;
                txtOrigen.Text = string.Empty;
                txtUbicacionCorte.Text = string.Empty;

                gbFruta.Enabled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Verificar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void WinFormAgregar_Load(object sender, EventArgs e)
        {
            if (this.modificar == true)
            {
                btnAgregar.Visible = false;
                btnVolver.Visible = false;
                txtCodigo.Enabled = false;
                btnConfirmar.Visible = true;
                btnCancelar.Visible = true;
                txtCodigo.Text = alimentoAModificar.MostrarCodigo();
                txtEmpresa.Enabled = false;
                txtEmpresa.Text = alimentoAModificar.Empresa;
            }
        }
    }
}
