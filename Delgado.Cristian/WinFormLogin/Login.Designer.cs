namespace WinFormLogin
{
    partial class Login
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
            lblLogin = new Label();
            lblCorreo = new Label();
            lblContrasenia = new Label();
            txtClave = new TextBox();
            txtCorreo = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(261, 74);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(95, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(167, 146);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(167, 235);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 2;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(167, 265);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(277, 23);
            txtClave.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(167, 181);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(278, 23);
            txtCorreo.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(252, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 57);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(lblCorreo);
            Controls.Add(btnLogin);
            Controls.Add(lblContrasenia);
            Controls.Add(txtCorreo);
            Controls.Add(lblLogin);
            Controls.Add(txtClave);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblCorreo;
        private Label lblContrasenia;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private Button btnLogin;
    }
}