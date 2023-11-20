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
    public partial class FormOrdenarAlimentos : Form, IPanelNavbar
    {
        public string claveOrden;
        public string ordenamiento;
        private bool dragging;
        private Point startPoint;
        public FormOrdenarAlimentos()
        {
            InitializeComponent();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += ((IPanelNavbar)this).PanelNavBar_MouseDown;
            panelNavbar.MouseUp += ((IPanelNavbar)this).PanelNavBar_MouseUp;
            panelNavbar.MouseMove += ((IPanelNavbar)this).PanelNavBar_MouseMove;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
