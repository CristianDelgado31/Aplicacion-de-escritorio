namespace WinFormLogin
{
    partial class FormLogin
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
            gbLogin = new GroupBox();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.Control;
            lblLogin.Location = new Point(240, 68);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(95, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = SystemColors.Control;
            lblCorreo.Location = new Point(138, 136);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.ForeColor = SystemColors.Control;
            lblContrasenia.Location = new Point(138, 214);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 2;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(138, 241);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(277, 23);
            txtClave.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(138, 165);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(277, 23);
            txtCorreo.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.OrangeRed;
            btnLogin.ForeColor = SystemColors.HighlightText;
            btnLogin.Location = new Point(222, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 57);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // gbLogin
            // 
            gbLogin.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            gbLogin.Controls.Add(lblLogin);
            gbLogin.Controls.Add(lblCorreo);
            gbLogin.Controls.Add(txtClave);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(txtCorreo);
            gbLogin.Controls.Add(lblContrasenia);
            gbLogin.Location = new Point(33, 23);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(545, 401);
            gbLogin.TabIndex = 7;
            gbLogin.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Peru;
            ClientSize = new Size(608, 450);
            Controls.Add(gbLogin);
            ForeColor = SystemColors.ControlText;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLogin;
        private Label lblCorreo;
        private Label lblContrasenia;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private Button btnLogin;
        private GroupBox gbLogin;
    }
}