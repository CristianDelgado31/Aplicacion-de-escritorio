namespace WinFormLogin
{
    partial class FormOrdenarAlimentos
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
            label1 = new Label();
            btnAscendente = new Button();
            btnDescendente = new Button();
            rbtnNombre = new RadioButton();
            rbtnUnidad = new RadioButton();
            gbOrdenamiento = new GroupBox();
            gbOrdenamiento.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 21);
            label1.TabIndex = 0;
            label1.Text = "Elija una opción para ordenar:";
            // 
            // btnAscendente
            // 
            btnAscendente.BackColor = Color.OrangeRed;
            btnAscendente.ForeColor = SystemColors.HighlightText;
            btnAscendente.Location = new Point(32, 22);
            btnAscendente.Name = "btnAscendente";
            btnAscendente.Size = new Size(84, 23);
            btnAscendente.TabIndex = 1;
            btnAscendente.Text = "Ascendente";
            btnAscendente.UseVisualStyleBackColor = false;
            btnAscendente.Click += btnAscendente_Click;
            // 
            // btnDescendente
            // 
            btnDescendente.BackColor = Color.OrangeRed;
            btnDescendente.ForeColor = SystemColors.HighlightText;
            btnDescendente.Location = new Point(32, 63);
            btnDescendente.Name = "btnDescendente";
            btnDescendente.Size = new Size(84, 23);
            btnDescendente.TabIndex = 2;
            btnDescendente.Text = "Descendente";
            btnDescendente.UseVisualStyleBackColor = false;
            btnDescendente.Click += btnDescendente_Click;
            // 
            // rbtnNombre
            // 
            rbtnNombre.AutoSize = true;
            rbtnNombre.ForeColor = SystemColors.HighlightText;
            rbtnNombre.Location = new Point(38, 71);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(69, 19);
            rbtnNombre.TabIndex = 3;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombre";
            rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnUnidad
            // 
            rbtnUnidad.AutoSize = true;
            rbtnUnidad.ForeColor = SystemColors.HighlightText;
            rbtnUnidad.Location = new Point(38, 112);
            rbtnUnidad.Name = "rbtnUnidad";
            rbtnUnidad.Size = new Size(63, 19);
            rbtnUnidad.TabIndex = 4;
            rbtnUnidad.TabStop = true;
            rbtnUnidad.Text = "Unidad";
            rbtnUnidad.UseVisualStyleBackColor = true;
            // 
            // gbOrdenamiento
            // 
            gbOrdenamiento.BackColor = Color.Tan;
            gbOrdenamiento.Controls.Add(btnAscendente);
            gbOrdenamiento.Controls.Add(btnDescendente);
            gbOrdenamiento.Location = new Point(141, 49);
            gbOrdenamiento.Name = "gbOrdenamiento";
            gbOrdenamiento.Size = new Size(144, 100);
            gbOrdenamiento.TabIndex = 5;
            gbOrdenamiento.TabStop = false;
            // 
            // FormOrdenarAlimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(315, 168);
            Controls.Add(rbtnUnidad);
            Controls.Add(rbtnNombre);
            Controls.Add(gbOrdenamiento);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
            Name = "FormOrdenarAlimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrdenar";
            gbOrdenamiento.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAscendente;
        private Button btnDescendente;
        private RadioButton rbtnNombre;
        private RadioButton rbtnUnidad;
        private GroupBox gbOrdenamiento;
    }
}