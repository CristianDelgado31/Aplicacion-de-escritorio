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
            SuspendLayout();
            // 
            // lstListaGenerica
            // 
            lstListaGenerica.FormattingEnabled = true;
            lstListaGenerica.ItemHeight = 15;
            lstListaGenerica.Location = new Point(49, 46);
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
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista genérica";
            // 
            // FormMostrarListaGenerica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(507, 450);
            Controls.Add(label1);
            Controls.Add(lstListaGenerica);
            Name = "FormMostrarListaGenerica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMostrarListaGenerica";
            Load += FormMostrarListaGenerica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstListaGenerica;
        private Label label1;
    }
}