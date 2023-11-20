namespace WinFormLogin
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            btnCerrarSesion = new Button();
            btnAgregar = new Button();
            btnMostrar = new Button();
            lblSaludo = new Label();
            pictureBox1 = new PictureBox();
            btnHistorialDeActividad = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panelNavbar = new Panel();
            label3 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Red;
            btnCerrarSesion.ForeColor = SystemColors.Control;
            btnCerrarSesion.Location = new Point(764, 65);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(90, 35);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.OrangeRed;
            btnAgregar.ForeColor = SystemColors.HighlightText;
            btnAgregar.Location = new Point(60, 169);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 41);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.OrangeRed;
            btnMostrar.ForeColor = SystemColors.HighlightText;
            btnMostrar.Location = new Point(60, 264);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(98, 41);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.Chocolate;
            lblSaludo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaludo.ForeColor = SystemColors.HighlightText;
            lblSaludo.Location = new Point(338, 63);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(182, 30);
            lblSaludo.TabIndex = 4;
            lblSaludo.Text = "¡Bienvenido Juan!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnHistorialDeActividad
            // 
            btnHistorialDeActividad.BackColor = Color.OrangeRed;
            btnHistorialDeActividad.ForeColor = SystemColors.HighlightText;
            btnHistorialDeActividad.Location = new Point(734, 411);
            btnHistorialDeActividad.Name = "btnHistorialDeActividad";
            btnHistorialDeActividad.Size = new Size(120, 49);
            btnHistorialDeActividad.TabIndex = 6;
            btnHistorialDeActividad.Text = "Historial de actividad";
            btnHistorialDeActividad.UseVisualStyleBackColor = false;
            btnHistorialDeActividad.Click += btnHistorialDeActividad_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "registroActividad";
            openFileDialog1.Filter = "registroActividad.(*json)|*.json";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "registroActividad";
            saveFileDialog1.Filter = "registroActividad.(*json)|*.json";
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Black;
            panelNavbar.Controls.Add(label3);
            panelNavbar.Controls.Add(btnSalir);
            panelNavbar.Location = new Point(-2, 1);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(868, 50);
            panelNavbar.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(196, 26);
            label3.TabIndex = 1;
            label3.Text = "FORM MENU PRINCIPAL";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(811, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 46);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(866, 472);
            Controls.Add(lblSaludo);
            Controls.Add(pictureBox1);
            Controls.Add(panelNavbar);
            Controls.Add(btnHistorialDeActividad);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCerrarSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormPrincipal";
            FormClosing += WinFormPrincipal_FormClosing;
            Load += WinFormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrarSesion;
        private Button btnAgregar;
        private Button btnMostrar;
        private Label lblSaludo;
        private Button btnHistorialDeActividad;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panelNavbar;
        private Label label3;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}