namespace WinFormLogin
{
    partial class FormMostrar
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
            btnVolver = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lstMostrarLista = new ListBox();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(70, 26);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Atras";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(40, 135);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(40, 201);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstMostrarLista
            // 
            lstMostrarLista.AccessibleName = "";
            lstMostrarLista.FormattingEnabled = true;
            lstMostrarLista.ItemHeight = 15;
            lstMostrarLista.Location = new Point(149, 12);
            lstMostrarLista.Name = "lstMostrarLista";
            lstMostrarLista.Size = new Size(400, 394);
            lstMostrarLista.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(40, 266);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(lstMostrarLista);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnVolver);
            Name = "FormMostrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMostrar";
            Load += FormMostrar_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox lstMostrarLista;
        private Button btnOrdenar;
    }
}