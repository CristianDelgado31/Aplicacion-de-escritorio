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
    public partial class FormMostrarListaGenerica : Form, IPanelNavbar
    {
        private FormMenuMostrarAlimentos formMostrarAlimentos;
        private ColeccionGenerica<Alimento> coleccionGenerica;
        private bool dragging;
        private Point startPoint;
        public FormMostrarListaGenerica()
        {
            InitializeComponent();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += ((IPanelNavbar)this).PanelNavBar_MouseDown;
            panelNavbar.MouseUp += ((IPanelNavbar)this).PanelNavBar_MouseUp;
            panelNavbar.MouseMove += ((IPanelNavbar)this).PanelNavBar_MouseMove;
        }
        public FormMostrarListaGenerica(ColeccionGenerica<Alimento> coleccionGenerica) : this()
        {
            this.coleccionGenerica = coleccionGenerica;
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
        private void FormMostrarListaGenerica_Load(object sender, EventArgs e)
        {
            foreach (Alimento item in coleccionGenerica.listaAlimentos)
            {
                lstListaGenerica.Items.Add(item.ToString());
            }
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
