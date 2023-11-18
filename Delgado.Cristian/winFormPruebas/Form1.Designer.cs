namespace winFormPruebas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIniciarSesion = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblContrasenia = new Label();
            lblCorreo = new Label();
            panelNavbar = new Panel();
            label3 = new Label();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Black;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.LavenderBlush;
            btnIniciarSesion.Location = new Point(320, 334);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(156, 32);
            btnIniciarSesion.TabIndex = 9;
            btnIniciarSesion.Text = "INICIAR SESION";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.LavenderBlush;
            textBox2.Location = new Point(296, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 24);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.LavenderBlush;
            textBox1.Location = new Point(296, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 24);
            textBox1.TabIndex = 7;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.Transparent;
            lblContrasenia.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.LavenderBlush;
            lblContrasenia.Location = new Point(296, 197);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(75, 17);
            lblContrasenia.TabIndex = 6;
            lblContrasenia.Text = "CONTRASEÑA";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.LavenderBlush;
            lblCorreo.Location = new Point(296, 109);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 17);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "USUARIO";
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Black;
            panelNavbar.Controls.Add(label3);
            panelNavbar.Controls.Add(btnSalir);
            panelNavbar.Location = new Point(-1, -1);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(803, 49);
            panelNavbar.TabIndex = 10;
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
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(741, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 46);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 396);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelNavbar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblContrasenia);
            Controls.Add(lblCorreo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
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

        private Button btnIniciarSesion;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblContrasenia;
        private Label lblCorreo;
        private Panel panelNavbar;
        private Button btnSalir;
        private Label label3;
        private PictureBox pictureBox1;
    }
}