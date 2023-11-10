namespace WinFormLogin
{
    partial class FormHistorialActividad
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
            lstListaActividad = new ListBox();
            SuspendLayout();
            // 
            // lstListaActividad
            // 
            lstListaActividad.FormattingEnabled = true;
            lstListaActividad.ItemHeight = 15;
            lstListaActividad.Location = new Point(15, 12);
            lstListaActividad.Name = "lstListaActividad";
            lstListaActividad.Size = new Size(192, 364);
            lstListaActividad.TabIndex = 0;
            // 
            // FormHistorialActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 385);
            Controls.Add(lstListaActividad);
            Name = "FormHistorialActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormHistorialActividad_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstListaActividad;
    }
}