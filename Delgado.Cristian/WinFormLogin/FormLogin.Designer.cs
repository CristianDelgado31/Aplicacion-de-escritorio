namespace WinFormLogin
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelNavbar = new Panel();
            label3 = new Label();
            btnSalir = new Button();
            btnIniciarSesion = new Button();
            txtContrasenia = new TextBox();
            txtCorreo = new TextBox();
            lblContrasenia = new Label();
            lblCorreo = new Label();
            pictureBox1 = new PictureBox();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Black;
            panelNavbar.Controls.Add(label3);
            panelNavbar.Controls.Add(btnSalir);
            panelNavbar.Location = new Point(-1, -2);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(843, 49);
            panelNavbar.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(60, 26);
            label3.TabIndex = 1;
            label3.Text = "LOGIN";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(783, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 46);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Black;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.LavenderBlush;
            btnIniciarSesion.Location = new Point(365, 327);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(156, 32);
            btnIniciarSesion.TabIndex = 16;
            btnIniciarSesion.Text = "INICIAR SESION";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.Black;
            txtContrasenia.BorderStyle = BorderStyle.None;
            txtContrasenia.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.ForeColor = Color.LavenderBlush;
            txtContrasenia.Location = new Point(338, 243);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(208, 24);
            txtContrasenia.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Black;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.LavenderBlush;
            txtCorreo.Location = new Point(338, 160);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(208, 24);
            txtCorreo.TabIndex = 14;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.Transparent;
            lblContrasenia.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.LavenderBlush;
            lblContrasenia.Location = new Point(338, 212);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(84, 19);
            lblContrasenia.TabIndex = 13;
            lblContrasenia.Text = "CONTRASEÑA";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.LavenderBlush;
            lblCorreo.Location = new Point(338, 122);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(60, 19);
            lblCorreo.TabIndex = 12;
            lblCorreo.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(693, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(842, 481);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContrasenia);
            Controls.Add(txtCorreo);
            Controls.Add(lblContrasenia);
            Controls.Add(lblCorreo);
            Controls.Add(panelNavbar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLoginNuevo";
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            TransparentLocation(lblCorreo, pictureBox1);
            TransparentLocation(lblContrasenia, pictureBox1);
        }

        private void TransparentLocation(Label label, PictureBox pictureBox)
        {
            label.Location = pictureBox.PointToClient(this.PointToScreen(label.Location));
            label.Parent = pictureBox;
        }
        #endregion

        private Panel panelNavbar;
        private Label label3;
        private Button btnSalir;
        private Button btnIniciarSesion;
        private TextBox txtContrasenia;
        private TextBox txtCorreo;
        private Label lblContrasenia;
        private Label lblCorreo;
        private PictureBox pictureBox1;
    }
}