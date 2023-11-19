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
    public partial class FormActividadUsuarios : Form
    {
        public List<USuarioLog> listaRegistroUsuarios;
        public List<USuarioLog> listaActualizada;
        private USuarioLog usuarioLog;
        private FormMenuPrincipal formMenuPrincipal;
        private string rutaArchivo;
        private bool accesoBtnGuardar;
        private bool dragging;
        private Point startPoint;
        public FormActividadUsuarios()
        {
            listaActualizada = new List<USuarioLog>();
            InitializeComponent();
            dragging = false;
            startPoint = new Point(0, 0);
            panelNavbar.MouseDown += PanelNavBar_MouseDown;
            panelNavbar.MouseUp += PanelNavBar_MouseUp;
            panelNavbar.MouseMove += PanelNavBar_MouseMove;
        }
        public FormActividadUsuarios(List<USuarioLog> ListaUsuariosLog, USuarioLog usuarioLog, FormMenuPrincipal formMenuPrincipal) : this()
        {
            this.listaRegistroUsuarios = ListaUsuariosLog;
            this.usuarioLog = usuarioLog;
            this.formMenuPrincipal = formMenuPrincipal;
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
            // Convertir la lista a formato JSON
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);

            // Escribir el JSON en el archivo
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

                foreach (USuarioLog item in listaActualizada)
                {
                    if (item.Hora != usuarioLog.Hora)
                    {
                        listaActualizada.Add(usuarioLog);
                        break;
                    }

                }
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
