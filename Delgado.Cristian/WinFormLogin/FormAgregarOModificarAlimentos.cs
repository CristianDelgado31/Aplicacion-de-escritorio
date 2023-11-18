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

namespace WinFormLogin
{
    public partial class FormAgregarOModificarAlimentos : Form
    {
        private FormMenuPrincipal winPrincipal;
        private Alimento alimentoAModificar;
        public Alimento alimentoNuevo;
        private ColeccionGenerica<Alimento> listaGenerica;
        private bool modificar;
        private BaseDeDatosAlimentos conexionBD;

        public FormAgregarOModificarAlimentos()
        {
            conexionBD = new BaseDeDatosAlimentos();
            InitializeComponent();
        }
        public FormAgregarOModificarAlimentos(FormMenuPrincipal winFormPrincipal, ColeccionGenerica<Alimento> listaGenerica) : this()
        {
            this.winPrincipal = winFormPrincipal;
            this.listaGenerica = listaGenerica;
        }
        public FormAgregarOModificarAlimentos(Alimento alimentoSeleccionado, bool modificar) : this()
        {
            this.alimentoAModificar = alimentoSeleccionado;
            this.modificar = modificar;
        }

        private void VerificarDatos()
        {
            int unidad;
            bool verificarUnidad = int.TryParse(txtUnidad.Text, out unidad);
            ColorAlimento[] arrColores = (ColorAlimento[])Enum.GetValues(typeof(ColorAlimento));
            ColorAlimento color = new ColorAlimento();
            foreach (ColorAlimento elemento in arrColores)
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
                    AlertaDatoIncorrecto("unidad");
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
                    AlertaDatoIncorrecto("unidad");
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
                    AlertaDatoIncorrecto("unidad");
            }

            if (modificar == false && txtNombre.Text != "" && txtCodigo.Text != "" && txtEmpresa.Text != "" && txtUnidad.Text != "" && unidad > 0)
            {
                if (listaGenerica.listaAlimentos.Contains(alimentoNuevo))
                {
                    AlertaDatoIncorrecto("alimento repetido");
                }
                else
                {
                    bool agregar = listaGenerica + alimentoNuevo;
                    if (agregar == true)
                    {
                        AlertaDatoIncorrecto("nuevo alimento");
                        if (alimentoNuevo is Fruta fruta)
                            conexionBD.AgregarAlimento(fruta, null, null);
                        else if (alimentoNuevo is Verdura verdura)
                            conexionBD.AgregarAlimento(null, verdura, null);
                        else if (alimentoNuevo is Carne carne)
                            conexionBD.AgregarAlimento(null, null, carne);

                        this.Close();
                        winPrincipal.Show();

                    }
                }
            }
            else if (modificar == true && txtNombre.Text != "" && txtCodigo.Text != "" && txtEmpresa.Text != "" && txtUnidad.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            }

        }
        private void AlertaDatoIncorrecto(string claveError)
        {
            string mensaje = string.Empty;
            if (claveError == "unidad")
            {
                mensaje = "Ingrese un numero en el texto Unidad";
            }
            else if (claveError == "alimento repetido")
            {
                mensaje = "Ya existe un alimento con mismo codigo y empresa";
            }
            else if(claveError == "nuevo alimento")
            {
                mensaje = "Se agrego un nuevo alimento";
            }
            MessageBox.Show(mensaje);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VerificarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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
            VerificarDatos();
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
                txtEmpresa.Enabled = false;


                txtCodigo.Text = alimentoAModificar.Codigo;
                txtNombre.Text = alimentoAModificar.Nombre;
                txtEmpresa.Text = alimentoAModificar.Empresa;
                txtUnidad.Text = alimentoAModificar.Unidades.ToString();
                cmbColores.Text = alimentoAModificar.ColorDelAlimento.ToString();

                if (alimentoAModificar is Fruta alimentoFruta)
                {
                    rbtnCarne.Enabled = false;
                    rbtnVerdura.Enabled = false;

                    if (alimentoFruta.CascaraComestible == true)
                    {
                        rbtnSiComestible.Checked = true;
                    }
                    else rbtnNoComestible.Checked = true;
                    if (alimentoFruta.EsCitrico == true)
                    {
                        rbtnSiCitrico.Checked = true;
                    }
                    else rbtnNoCitrico.Checked = true;
                }
                else if (alimentoAModificar is Verdura verdura)
                {
                    rbtnFruta.Enabled = false;
                    rbtnCarne.Enabled = false;

                    rbtnFruta.Checked = false;
                    rbtnCarne.Checked = false;
                    rbtnVerdura.Checked = true;
                    if (verdura.SeCocina == true)
                    {
                        rbtnSiCocina.Checked = true;
                    }
                    else rbtnNoCocina.Checked = true;
                    if (verdura.EsUnaHoja == true)
                    {
                        rbtnSiHoja.Checked = true;
                    }
                    else rbtnNoHoja.Checked = true;
                }
                else if (alimentoAModificar is Carne carne)
                {
                    rbtnFruta.Enabled = false;
                    rbtnVerdura.Enabled = false;

                    rbtnFruta.Checked = false;
                    rbtnCarne.Checked = true;
                    rbtnVerdura.Checked = false;

                    txtOrigen.Text = carne.OrigenDeLaCarne;
                    txtUbicacionCorte.Text = carne.UbicacionDelCorte;
                }

            }

        }

        private void WinFormAgregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modificar == false)
            {
                winPrincipal.Show();
            }
        }

    }
}
