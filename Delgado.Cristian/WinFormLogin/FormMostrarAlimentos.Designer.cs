namespace WinFormLogin
{
    partial class FormMostrarAlimentos
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
            ((System.ComponentModel.ISupportInitialize)dtvListaAlimentos).BeginInit();
            SuspendLayout();
            // 
            // dtvListaAlimentos
            // 
            dtvListaAlimentos.BackgroundColor = Color.Peru;
            dtvListaAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvListaAlimentos.Location = new Point(205, 39);
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
            btnVerduras.Location = new Point(59, 94);
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
            btnFrutas.Location = new Point(59, 172);
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
            label1.Location = new Point(7, 49);
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
            // FormMostrarAlimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(881, 520);
            Controls.Add(btnGenerico);
            Controls.Add(label1);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCarnes);
            Controls.Add(btnFrutas);
            Controls.Add(btnVerduras);
            Controls.Add(dtvListaAlimentos);
            Name = "FormMostrarAlimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMostrarAlimentos";
            FormClosing += FormMostrarAlimentos_FormClosing;
            Load += FormMostrarAlimentos_Load;
            ((System.ComponentModel.ISupportInitialize)dtvListaAlimentos).EndInit();
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
    }
}