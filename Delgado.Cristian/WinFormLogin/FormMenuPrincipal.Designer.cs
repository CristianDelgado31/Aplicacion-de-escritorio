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
            btnCerrarSesion = new Button();
            btnAgregar = new Button();
            btnMostrar = new Button();
            lblSaludo = new Label();
            gbUsuario = new GroupBox();
            lblPerfil = new Label();
            btnHistorialDeActividad = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            gbUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Red;
            btnCerrarSesion.ForeColor = SystemColors.Control;
            btnCerrarSesion.Location = new Point(686, 29);
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
            btnAgregar.Location = new Point(59, 137);
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
            btnMostrar.Location = new Point(59, 233);
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
            lblSaludo.Location = new Point(53, 38);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(182, 30);
            lblSaludo.TabIndex = 4;
            lblSaludo.Text = "¡Bienvenido Juan!";
            // 
            // gbUsuario
            // 
            gbUsuario.BackColor = Color.Peru;
            gbUsuario.Controls.Add(lblPerfil);
            gbUsuario.Controls.Add(lblSaludo);
            gbUsuario.Location = new Point(253, 68);
            gbUsuario.Name = "gbUsuario";
            gbUsuario.Size = new Size(350, 226);
            gbUsuario.TabIndex = 5;
            gbUsuario.TabStop = false;
            gbUsuario.Visible = false;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.Chocolate;
            lblPerfil.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = SystemColors.HighlightText;
            lblPerfil.Location = new Point(110, 106);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(187, 28);
            lblPerfil.TabIndex = 5;
            lblPerfil.Text = "Perfil: administrador";
            // 
            // btnHistorialDeActividad
            // 
            btnHistorialDeActividad.BackColor = Color.OrangeRed;
            btnHistorialDeActividad.ForeColor = SystemColors.HighlightText;
            btnHistorialDeActividad.Location = new Point(668, 373);
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
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(800, 450);
            Controls.Add(btnHistorialDeActividad);
            Controls.Add(gbUsuario);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCerrarSesion);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormPrincipal";
            FormClosing += WinFormPrincipal_FormClosing;
            Load += WinFormPrincipal_Load;
            gbUsuario.ResumeLayout(false);
            gbUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesion;
        private Button btnAgregar;
        private Button btnMostrar;
        private Label lblSaludo;
        private GroupBox gbUsuario;
        private Label lblPerfil;
        private Button btnHistorialDeActividad;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}