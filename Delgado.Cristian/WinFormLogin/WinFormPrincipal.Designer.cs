namespace WinFormLogin
{
    partial class WinFormPrincipal
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
            gbUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(640, 35);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(102, 23);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(59, 132);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 32);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(59, 220);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(81, 34);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaludo.Location = new Point(52, 32);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(182, 30);
            lblSaludo.TabIndex = 4;
            lblSaludo.Text = "¡Bienvenido Juan!";
            // 
            // gbUsuario
            // 
            gbUsuario.Controls.Add(lblPerfil);
            gbUsuario.Controls.Add(lblSaludo);
            gbUsuario.Location = new Point(255, 68);
            gbUsuario.Name = "gbUsuario";
            gbUsuario.Size = new Size(313, 240);
            gbUsuario.TabIndex = 5;
            gbUsuario.TabStop = false;
            gbUsuario.Visible = false;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.Location = new Point(52, 89);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(187, 28);
            lblPerfil.TabIndex = 5;
            lblPerfil.Text = "Perfil: administrador";
            // 
            // btnHistorialDeActividad
            // 
            btnHistorialDeActividad.Location = new Point(640, 168);
            btnHistorialDeActividad.Name = "btnHistorialDeActividad";
            btnHistorialDeActividad.Size = new Size(84, 49);
            btnHistorialDeActividad.TabIndex = 6;
            btnHistorialDeActividad.Text = "Historial de actividad";
            btnHistorialDeActividad.UseVisualStyleBackColor = true;
            btnHistorialDeActividad.Click += btnHistorialDeActividad_Click;
            // 
            // WinFormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHistorialDeActividad);
            Controls.Add(gbUsuario);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCerrarSesion);
            Name = "WinFormPrincipal";
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
    }
}