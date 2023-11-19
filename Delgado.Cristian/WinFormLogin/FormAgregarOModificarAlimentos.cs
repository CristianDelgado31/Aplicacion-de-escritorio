using BaseDeDatos;
using Entidades;
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
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public FormAgregarOModificarAlimentos()
        {
            conexionBD = new BaseDeDatosAlimentos();
            InitializeComponent();
            panelNavbar.MouseDown += PanelNavBar_MouseDown;
            panelNavbar.MouseUp += PanelNavBar_MouseUp;
            panelNavbar.MouseMove += PanelNavBar_MouseMove;
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
        private void PanelNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void PanelNavBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void PanelNavBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = PointToScreen(p1);
                Point p3 = new Point(p2.X - startPoint.X, p2.Y - startPoint.Y);
                Location = p3;
            }
        }
        private void VerificarDatos()
        {
            int unidad;
            try
            {
                bool verificarColor = false;
                ColorAlimento[] arrColores = (ColorAlimento[])Enum.GetValues(typeof(ColorAlimento));
                ColorAlimento color = new ColorAlimento();
                foreach (ColorAlimento elemento in arrColores)
                {
                    if (elemento.ToString() == cmbColores.Text)
                    {
                        color = elemento;
                        verificarColor = true;
                        break;
                    }
                }
                if (txtCodigo.Text.Length == 0)
                {
                    throw new ExcepcionDatos("Complete el campo Codigo", "vacio");
                }

                if (txtNombre.Text.Length < 4 || VerificarDatoIngresado(txtNombre.Text) == false)
                {
                    throw new ExcepcionDatos("Dato invalido en Nombre", txtNombre.Text);
                }

                if (verificarColor == false)
                    throw new ExcepcionDatos("Dato ingresado en color no valido", cmbColores.Text);

                if (int.TryParse(txtUnidad.Text, out unidad) == false)
                {
                    throw new ExcepcionDatos("Dato ingresado no valido en unidades", txtUnidad.Text);
                }

                if (unidad <= 0)
                {
                    throw new ExcepcionDatos("Dato numerico ingresado no valido", unidad.ToString());
                }

                if (txtEmpresa.Text.Length == 0)
                    throw new ExcepcionDatos("No se ingresaron datos en empresa", txtEmpresa.Text);
                if (VerificarDatoIngresado(txtEmpresa.Text) == false)
                    throw new ExcepcionDatos("Dato ingresado no valido en empresa", txtEmpresa.Text);

                if (rbtnCarne.Checked)
                {
                    if (VerificarDatoIngresado(txtUbicacionCorte.Text) == true && VerificarDatoIngresado(txtOrigen.Text) == true && txtUbicacionCorte.Text.Length > 1
                        && txtOrigen.Text.Length > 1)
                        alimentoNuevo = new Carne(txtNombre.Text, color, txtCodigo.Text, unidad, txtEmpresa.Text, txtOrigen.Text, txtUbicacionCorte.Text);
                    else
                        throw new ExcepcionDatos("Complete el/los campo/s restante/s", "");
                }
                else if (rbtnFruta.Checked)
                {
                    bool cascaraComestible = false;
                    bool citrico = false;

                    if (rbtnSiCitrico.Checked == false && rbtnNoCitrico.Checked == false && rbtnSiComestible.Checked == false && rbtnNoComestible.Checked == false)
                        throw new ExcepcionDatos("Complete los campos restantes de fruta", "botones no fueron seleccionados");

                    if (rbtnSiCitrico.Checked == true || rbtnNoCitrico.Checked == true && rbtnSiComestible.Checked == false && rbtnNoComestible.Checked == false)
                        throw new ExcepcionDatos("Seleccione una opción de Cascara comestible", "");

                    if (rbtnSiComestible.Checked == true || rbtnNoComestible.Checked == true && rbtnSiCitrico.Checked == false && rbtnNoCitrico.Checked == false)
                        throw new ExcepcionDatos("Seleccione una opción de Cítrico", "");


                    if (rbtnSiCitrico.Checked)
                        citrico = true;
                    if (rbtnSiComestible.Checked)
                        cascaraComestible = true;

                    alimentoNuevo = new Fruta(txtNombre.Text, color, txtCodigo.Text, unidad, txtEmpresa.Text, citrico, cascaraComestible);
                }
                else
                {
                    bool esUnaHoja = false;
                    bool seCocina = false;

                    if (rbtnSiCocina.Checked == false && rbtnNoCocina.Checked == false && rbtnSiHoja.Checked == false && rbtnNoHoja.Checked == false)
                        throw new ExcepcionDatos("Complete los campos restantes de verdura", "botones no fueron seleccionados");

                    if (rbtnSiCocina.Checked == true || rbtnNoCocina.Checked == true && rbtnSiHoja.Checked == false && rbtnNoHoja.Checked == false)
                        throw new ExcepcionDatos("Seleccione una opción de si es una hoja", "");

                    if (rbtnSiHoja.Checked == true || rbtnNoHoja.Checked == true && rbtnSiCocina.Checked == false && rbtnNoCocina.Checked == false)
                        throw new ExcepcionDatos("Seleccione una opción de si se cocina", "");

                    if (rbtnSiCocina.Checked)
                        seCocina = true;
                    if (rbtnSiHoja.Checked)
                        esUnaHoja = true;

                    alimentoNuevo = new Verdura(txtNombre.Text, color, txtCodigo.Text, unidad, txtEmpresa.Text, seCocina, esUnaHoja);
                }

                if (modificar == false && txtNombre.Text != "" && txtCodigo.Text != "")
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
                else if (modificar == true && txtNombre.Text != "" && txtCodigo.Text != "")
                {
                    this.DialogResult = DialogResult.OK;
                }


            }
            catch (ExcepcionDatos ex)
            {
                MessageBox.Show(ex.Message + $"\nDato: {ex.DatoIngresado}");
            }

        }
        private bool VerificarDatoIngresado(string datoAVerificar)
        {
            foreach (Char letra in datoAVerificar)
            {
                if (!Char.IsLetter(letra))
                {
                    return false;
                }
            }
            return true;
        }

        private void AlertaDatoIncorrecto(string claveError)
        {
            string mensaje = string.Empty;
            if (claveError == "alimento repetido")
            {
                mensaje = "Ya existe un alimento con mismo codigo y empresa";
            }
            else if (claveError == "nuevo alimento")
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
