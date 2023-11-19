namespace WinFormLogin
{
    partial class FormMostrarListaGenerica
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
            lstListaGenerica = new ListBox();
            label1 = new Label();
            panelNavbar = new Panel();
            label2 = new Label();
            btnSalir = new Button();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // lstListaGenerica
            // 
            lstListaGenerica.FormattingEnabled = true;
            lstListaGenerica.ItemHeight = 15;
            lstListaGenerica.Location = new Point(69, 108);
            lstListaGenerica.Name = "lstListaGenerica";
            lstListaGenerica.Size = new Size(423, 379);
            lstListaGenerica.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(66, 66, 66);
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(214, 64);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista genérica";
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Black;
            panelNavbar.Controls.Add(label2);
            panelNavbar.Controls.Add(btnSalir);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(564, 47);
            panelNavbar.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 1;
            label2.Text = "FORM LISTA GENÉRICA";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(507, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 44);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMostrarListaGenerica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(565, 540);
            Controls.Add(panelNavbar);
            Controls.Add(label1);
            Controls.Add(lstListaGenerica);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMostrarListaGenerica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMostrarListaGenerica";
            Load += FormMostrarListaGenerica_Load;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstListaGenerica;
        private Label label1;
        private Panel panelNavbar;
        private Label label2;
        private Button btnSalir;
    }
}