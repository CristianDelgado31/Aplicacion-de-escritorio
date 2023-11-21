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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenarAlimentos));
            label1 = new Label();
            btnAscendente = new Button();
            btnDescendente = new Button();
            rbtnNombre = new RadioButton();
            rbtnUnidad = new RadioButton();
            gbOrdenamiento = new GroupBox();
            panelNavbar = new Panel();
            btnMax = new Button();
            btnMin = new Button();
            label2 = new Label();
            btnSalir = new Button();
            gbOrdenamiento.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(88, 77);
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
            rbtnNombre.BackColor = Color.Peru;
            rbtnNombre.ForeColor = SystemColors.HighlightText;
            rbtnNombre.Location = new Point(85, 139);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(69, 19);
            rbtnNombre.TabIndex = 3;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombre";
            rbtnNombre.UseVisualStyleBackColor = false;
            // 
            // rbtnUnidad
            // 
            rbtnUnidad.AutoSize = true;
            rbtnUnidad.BackColor = Color.Peru;
            rbtnUnidad.ForeColor = SystemColors.HighlightText;
            rbtnUnidad.Location = new Point(85, 180);
            rbtnUnidad.Name = "rbtnUnidad";
            rbtnUnidad.Size = new Size(63, 19);
            rbtnUnidad.TabIndex = 4;
            rbtnUnidad.TabStop = true;
            rbtnUnidad.Text = "Unidad";
            rbtnUnidad.UseVisualStyleBackColor = false;
            // 
            // gbOrdenamiento
            // 
            gbOrdenamiento.BackColor = Color.Tan;
            gbOrdenamiento.Controls.Add(btnAscendente);
            gbOrdenamiento.Controls.Add(btnDescendente);
            gbOrdenamiento.Location = new Point(188, 117);
            gbOrdenamiento.Name = "gbOrdenamiento";
            gbOrdenamiento.Size = new Size(144, 100);
            gbOrdenamiento.TabIndex = 5;
            gbOrdenamiento.TabStop = false;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Black;
            panelNavbar.Controls.Add(btnMax);
            panelNavbar.Controls.Add(btnMin);
            panelNavbar.Controls.Add(label2);
            panelNavbar.Controls.Add(btnSalir);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(393, 47);
            panelNavbar.TabIndex = 16;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.Black;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.ForeColor = Color.Black;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(283, 1);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(47, 46);
            btnMax.TabIndex = 22;
            btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.Black;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(234, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(46, 46);
            btnMin.TabIndex = 21;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 21);
            label2.TabIndex = 1;
            label2.Text = "FORM ORDENAR ALIMENTOS";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(336, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 44);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormOrdenarAlimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(393, 270);
            Controls.Add(panelNavbar);
            Controls.Add(rbtnUnidad);
            Controls.Add(rbtnNombre);
            Controls.Add(gbOrdenamiento);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrdenarAlimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrdenar";
            gbOrdenamiento.ResumeLayout(false);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
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
        private Panel panelNavbar;
        private Label label2;
        private Button btnSalir;
        private Button btnMin;
        private Button btnMax;
    }
}