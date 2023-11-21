using LibreriaDeClases;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios;

namespace WinFormLogin
{
    public partial class FormRegistroActividadUsuarios : Form, IPanelNavbar
    {
        public List<USuarioLog> listaRegistroUsuarios;
        public List<USuarioLog> listaActualizada;
        private USuarioLog usuarioLog;
        private FormMenuPrincipal formMenuPrincipal;
        private string rutaArchivo;
        private bool accesoBtnGuardar;
        private bool dragging;
        private Point startPoint;
        public FormRegistroActividadUsuarios()
        {
            listaActualizada = new List<USuarioLog>();
            InitializeComponent();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += ((IPanelNavbar)this).PanelNavBar_MouseDown;
            panelNavbar.MouseUp += ((IPanelNavbar)this).PanelNavBar_MouseUp;
            panelNavbar.MouseMove += ((IPanelNavbar)this).PanelNavBar_MouseMove;
        }
        public FormRegistroActividadUsuarios(List<USuarioLog> ListaUsuariosLog, USuarioLog usuarioLog, FormMenuPrincipal formMenuPrincipal) : this()
        {
            this.listaRegistroUsuarios = ListaUsuariosLog;
            this.usuarioLog = usuarioLog;
            this.formMenuPrincipal = formMenuPrincipal;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accesoBtnGuardar == true)
            {
                if (sfdGuardarArchivo.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfdGuardarArchivo.FileName))
                    {
                        string rutaArchivo = sfdGuardarArchivo.FileName;
                        this.rutaArchivo = rutaArchivo;
                        // Convertir la lista a formato JSON y guardar en el archivo
                        GuardarListaEnJson(listaActualizada, rutaArchivo);

                    }
                }
            }
            else
            {
                MessageBox.Show("Abrir el archivo registroActividad para cargar la lista");
            }
        }
        private void GuardarListaEnJson(List<USuarioLog> lista, string rutaArchivo)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);

            File.WriteAllText(rutaArchivo, json);
        }
        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                string texto = openFileDialog1.FileName;
                TextReader Leer = new StreamReader(texto);
                string textoJson = Leer.ReadToEnd();
                Leer.Close();


                dynamic? obj = JsonConvert.DeserializeObject(textoJson);
                listaActualizada = obj.ToObject(typeof(List<USuarioLog>));

                //if(formMenuPrincipal.usuarioNoNuevo == false)
                //{

                //}
                bool usuarioRepetido = false;
                foreach (USuarioLog item in listaActualizada)
                {
                    if (item.Hora == usuarioLog.Hora && item.Fecha == usuarioLog.Fecha)
                    {
                        usuarioRepetido = true;
                    }
                    else
                    {
                        usuarioRepetido = false;
                    }

                }
                if (usuarioRepetido == false)
                    listaActualizada.Add(usuarioLog);


                dataGridView1.DataSource = listaActualizada;
                accesoBtnGuardar = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
