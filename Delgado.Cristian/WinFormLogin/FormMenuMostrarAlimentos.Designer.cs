namespace WinFormLogin
{
    partial class FormMenuMostrarAlimentos
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
            dtvListaAlimentos = new DataGridView();
            btnVerduras = new Button();
            btnFrutas = new Button();
            btnCarnes = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            label1 = new Label();
            btnGenerico = new Button();
            panelNavbar = new Panel();
            label3 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvListaAlimentos).BeginInit();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // dtvListaAlimentos
            // 
            dtvListaAlimentos.BackgroundColor = Color.Peru;
            dtvListaAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvListaAlimentos.Location = new Point(205, 68);
            dtvListaAlimentos.Name = "dtvListaAlimentos";
            dtvListaAlimentos.RowHeadersWidth = 40;
            dtvListaAlimentos.RowTemplate.Height = 25;
            dtvListaAlimentos.Size = new Size(616, 365);
            dtvListaAlimentos.TabIndex = 0;
            dtvListaAlimentos.Visible = false;
            dtvListaAlimentos.CellContentClick += dtvListaAlimentos_CellContentClick_1;
            // 
            // btnVerduras
            // 
            btnVerduras.BackColor = Color.OrangeRed;
            btnVerduras.ForeColor = SystemColors.HighlightText;
            btnVerduras.Location = new Point(59, 109);
            btnVerduras.Name = "btnVerduras";
            btnVerduras.Size = new Size(86, 38);
            btnVerduras.TabIndex = 1;
            btnVerduras.Text = "Verduras";
            btnVerduras.UseVisualStyleBackColor = false;
            btnVerduras.Click += btnVerduras_Click;
            // 
            // btnFrutas
            // 
            btnFrutas.BackColor = Color.OrangeRed;
            btnFrutas.ForeColor = SystemColors.HighlightText;
            btnFrutas.Location = new Point(59, 190);
            btnFrutas.Name = "btnFrutas";
            btnFrutas.Size = new Size(86, 39);
            btnFrutas.TabIndex = 2;
            btnFrutas.Text = "Frutas";
            btnFrutas.UseVisualStyleBackColor = false;
            btnFrutas.Click += btnFrutas_Click;
            // 
            // btnCarnes
            // 
            btnCarnes.BackColor = Color.OrangeRed;
            btnCarnes.ForeColor = SystemColors.HighlightText;
            btnCarnes.Location = new Point(59, 262);
            btnCarnes.Name = "btnCarnes";
            btnCarnes.Size = new Size(86, 39);
            btnCarnes.TabIndex = 3;
            btnCarnes.Text = "Carnes";
            btnCarnes.UseVisualStyleBackColor = false;
            btnCarnes.Click += btnCarnes_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Orange;
            btnModificar.ForeColor = SystemColors.ControlText;
            btnModificar.Location = new Point(736, 466);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 34);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Orange;
            btnEliminar.Location = new Point(603, 466);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 34);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Orange;
            btnOrdenar.ForeColor = SystemColors.InfoText;
            btnOrdenar.Location = new Point(262, 466);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(105, 31);
            btnOrdenar.TabIndex = 13;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 68);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 14;
            label1.Text = "Seleccione un tipo de lista:";
            // 
            // btnGenerico
            // 
            btnGenerico.Location = new Point(59, 339);
            btnGenerico.Name = "btnGenerico";
            btnGenerico.Size = new Size(86, 37);
            btnGenerico.TabIndex = 15;
            btnGenerico.Text = "Generica";
            btnGenerico.UseVisualStyleBackColor = true;
            btnGenerico.Click += btnGenerico_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Black;
            panelNavbar.Controls.Add(label3);
            panelNavbar.Controls.Add(btnSalir);
            panelNavbar.Location = new Point(-2, -2);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(887, 52);
            panelNavbar.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(190, 26);
            label3.TabIndex = 1;
            label3.Text = "FORM MENU MOSTRAR";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(827, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 46);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMenuMostrarAlimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(881, 520);
            Controls.Add(panelNavbar);
            Controls.Add(btnGenerico);
            Controls.Add(label1);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCarnes);
            Controls.Add(btnFrutas);
            Controls.Add(btnVerduras);
            Controls.Add(dtvListaAlimentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuMostrarAlimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMostrarAlimentos";
            FormClosing += FormMostrarAlimentos_FormClosing;
            Load += FormMostrarAlimentos_Load;
            ((System.ComponentModel.ISupportInitialize)dtvListaAlimentos).EndInit();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtvListaAlimentos;
        private Button btnVerduras;
        private Button btnFrutas;
        private Button btnCarnes;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Label label1;
        private Button btnGenerico;
        private Panel panelNavbar;
        private Label label3;
        private Button btnSalir;
    }
}