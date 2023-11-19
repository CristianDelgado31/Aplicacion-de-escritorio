namespace WinFormLogin
{
    partial class FormActividadUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            sfdGuardarArchivo = new SaveFileDialog();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            btnAbrirArchivo = new Button();
            label1 = new Label();
            panelNavbar = new Panel();
            label2 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.OrangeRed;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(301, 437);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 35);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar manual";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // sfdGuardarArchivo
            // 
            sfdGuardarArchivo.FileName = "registroActividad";
            sfdGuardarArchivo.Filter = "registroActividad.(*json)|*.json";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PapayaWhip;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(437, 317);
            dataGridView1.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "registroActividad";
            openFileDialog1.Filter = "registroActividad.(*json)|*.json";
            // 
            // btnAbrirArchivo
            // 
            btnAbrirArchivo.BackColor = Color.OrangeRed;
            btnAbrirArchivo.ForeColor = SystemColors.ButtonHighlight;
            btnAbrirArchivo.Location = new Point(122, 437);
            btnAbrirArchivo.Name = "btnAbrirArchivo";
            btnAbrirArchivo.Size = new Size(108, 35);
            btnAbrirArchivo.TabIndex = 6;
            btnAbrirArchivo.Text = "Abrir";
            btnAbrirArchivo.UseVisualStyleBackColor = false;
            btnAbrirArchivo.Click += btnAbrirArchivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(66, 66, 66);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(190, 60);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 7;
            label1.Text = "Lista registro de usuarios";
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Black;
            panelNavbar.Controls.Add(label2);
            panelNavbar.Controls.Add(btnSalir);
            panelNavbar.Location = new Point(0, -3);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(534, 47);
            panelNavbar.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 1;
            label2.Text = "HISTORIAL USUARIOS";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(473, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 44);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMostrarRegistroActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(533, 503);
            Controls.Add(panelNavbar);
            Controls.Add(label1);
            Controls.Add(btnAbrirArchivo);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMostrarRegistroActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrueba";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private SaveFileDialog sfdGuardarArchivo;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Button btnAbrirArchivo;
        private Label label1;
        private Panel panelNavbar;
        private Label label2;
        private Button btnSalir;
    }
}