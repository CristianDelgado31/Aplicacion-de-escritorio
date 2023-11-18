namespace WinFormLogin
{
    partial class FormAgregarOModificarAlimentos
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
            groupbox = new GroupBox();
            label1 = new Label();
            rbtnCarne = new RadioButton();
            rbtnVerdura = new RadioButton();
            rbtnFruta = new RadioButton();
            btnVolver = new Button();
            gbFormulario = new GroupBox();
            txtEmpresa = new TextBox();
            lblEmpresa = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            lblColor = new Label();
            cmbColores = new ComboBox();
            gbCarne = new GroupBox();
            label5 = new Label();
            txtOrigen = new TextBox();
            txtUbicacionCorte = new TextBox();
            label4 = new Label();
            gbVerdura = new GroupBox();
            gbCocina = new GroupBox();
            rbtnNoCocina = new RadioButton();
            rbtnSiCocina = new RadioButton();
            gbhoja = new GroupBox();
            rbtnNoHoja = new RadioButton();
            rbtnSiHoja = new RadioButton();
            gbFruta = new GroupBox();
            gbCitrico = new GroupBox();
            rbtnNoCitrico = new RadioButton();
            rbtnSiCitrico = new RadioButton();
            gbCascaraComestible = new GroupBox();
            rbtnNoComestible = new RadioButton();
            rbtnSiComestible = new RadioButton();
            txtUnidad = new TextBox();
            lblTamanio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnAgregar = new Button();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            groupbox.SuspendLayout();
            gbFormulario.SuspendLayout();
            gbCarne.SuspendLayout();
            gbVerdura.SuspendLayout();
            gbCocina.SuspendLayout();
            gbhoja.SuspendLayout();
            gbFruta.SuspendLayout();
            gbCitrico.SuspendLayout();
            gbCascaraComestible.SuspendLayout();
            SuspendLayout();
            // 
            // groupbox
            // 
            groupbox.BackColor = Color.Peru;
            groupbox.Controls.Add(label1);
            groupbox.Controls.Add(rbtnCarne);
            groupbox.Controls.Add(rbtnVerdura);
            groupbox.Controls.Add(rbtnFruta);
            groupbox.ForeColor = SystemColors.Control;
            groupbox.Location = new Point(54, 84);
            groupbox.Name = "groupbox";
            groupbox.Size = new Size(175, 167);
            groupbox.TabIndex = 0;
            groupbox.TabStop = false;
            groupbox.Text = "Seleccione el tipo de alimento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // rbtnCarne
            // 
            rbtnCarne.AutoSize = true;
            rbtnCarne.ForeColor = SystemColors.ControlText;
            rbtnCarne.Location = new Point(35, 122);
            rbtnCarne.Name = "rbtnCarne";
            rbtnCarne.Size = new Size(56, 19);
            rbtnCarne.TabIndex = 2;
            rbtnCarne.TabStop = true;
            rbtnCarne.Text = "Carne";
            rbtnCarne.UseVisualStyleBackColor = true;
            rbtnCarne.CheckedChanged += rbtnCarne_CheckedChanged;
            // 
            // rbtnVerdura
            // 
            rbtnVerdura.AutoSize = true;
            rbtnVerdura.ForeColor = SystemColors.ControlText;
            rbtnVerdura.Location = new Point(35, 88);
            rbtnVerdura.Name = "rbtnVerdura";
            rbtnVerdura.Size = new Size(65, 19);
            rbtnVerdura.TabIndex = 1;
            rbtnVerdura.TabStop = true;
            rbtnVerdura.Text = "Verdura";
            rbtnVerdura.UseVisualStyleBackColor = true;
            rbtnVerdura.CheckedChanged += rbtnVerdura_CheckedChanged;
            // 
            // rbtnFruta
            // 
            rbtnFruta.AutoSize = true;
            rbtnFruta.ForeColor = SystemColors.ControlText;
            rbtnFruta.Location = new Point(35, 52);
            rbtnFruta.Name = "rbtnFruta";
            rbtnFruta.Size = new Size(52, 19);
            rbtnFruta.TabIndex = 0;
            rbtnFruta.TabStop = true;
            rbtnFruta.Text = "Fruta";
            rbtnFruta.UseVisualStyleBackColor = true;
            rbtnFruta.CheckedChanged += rbtnFruta_CheckedChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Red;
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(21, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // gbFormulario
            // 
            gbFormulario.BackColor = Color.Peru;
            gbFormulario.Controls.Add(txtEmpresa);
            gbFormulario.Controls.Add(lblEmpresa);
            gbFormulario.Controls.Add(txtCodigo);
            gbFormulario.Controls.Add(label2);
            gbFormulario.Controls.Add(lblColor);
            gbFormulario.Controls.Add(cmbColores);
            gbFormulario.Controls.Add(gbCarne);
            gbFormulario.Controls.Add(gbVerdura);
            gbFormulario.Controls.Add(gbFruta);
            gbFormulario.Controls.Add(txtUnidad);
            gbFormulario.Controls.Add(lblTamanio);
            gbFormulario.Controls.Add(txtNombre);
            gbFormulario.Controls.Add(lblNombre);
            gbFormulario.ForeColor = SystemColors.Control;
            gbFormulario.Location = new Point(314, 12);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(387, 527);
            gbFormulario.TabIndex = 2;
            gbFormulario.TabStop = false;
            gbFormulario.Text = "Formulario";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(20, 261);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(136, 23);
            txtEmpresa.TabIndex = 23;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.ForeColor = SystemColors.ControlText;
            lblEmpresa.Location = new Point(21, 243);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(52, 15);
            lblEmpresa.TabIndex = 22;
            lblEmpresa.Text = "Empresa";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(21, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(135, 23);
            txtCodigo.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(20, 21);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 20;
            label2.Text = "Codigo";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.ForeColor = SystemColors.ControlText;
            lblColor.Location = new Point(21, 135);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 19;
            lblColor.Text = "Color";
            // 
            // cmbColores
            // 
            cmbColores.FormattingEnabled = true;
            cmbColores.Items.AddRange(new object[] { "Rojo", "Naranja", "Verde", "Amarillo", "Rosa", "Gris" });
            cmbColores.Location = new Point(20, 156);
            cmbColores.Name = "cmbColores";
            cmbColores.Size = new Size(134, 23);
            cmbColores.TabIndex = 4;
            // 
            // gbCarne
            // 
            gbCarne.BackColor = Color.Tan;
            gbCarne.Controls.Add(label5);
            gbCarne.Controls.Add(txtOrigen);
            gbCarne.Controls.Add(txtUbicacionCorte);
            gbCarne.Controls.Add(label4);
            gbCarne.Location = new Point(198, 296);
            gbCarne.Name = "gbCarne";
            gbCarne.Size = new Size(168, 124);
            gbCarne.TabIndex = 3;
            gbCarne.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(14, 19);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 14;
            label5.Text = "Animal de origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(14, 37);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(133, 23);
            txtOrigen.TabIndex = 15;
            // 
            // txtUbicacionCorte
            // 
            txtUbicacionCorte.Location = new Point(14, 85);
            txtUbicacionCorte.Name = "txtUbicacionCorte";
            txtUbicacionCorte.Size = new Size(133, 23);
            txtUbicacionCorte.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(14, 67);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 16;
            label4.Text = "Ubicacion del corte";
            // 
            // gbVerdura
            // 
            gbVerdura.BackColor = Color.Peru;
            gbVerdura.Controls.Add(gbCocina);
            gbVerdura.Controls.Add(gbhoja);
            gbVerdura.Location = new Point(198, 37);
            gbVerdura.Name = "gbVerdura";
            gbVerdura.Size = new Size(168, 223);
            gbVerdura.TabIndex = 18;
            gbVerdura.TabStop = false;
            // 
            // gbCocina
            // 
            gbCocina.BackColor = Color.Tan;
            gbCocina.Controls.Add(rbtnNoCocina);
            gbCocina.Controls.Add(rbtnSiCocina);
            gbCocina.ForeColor = SystemColors.ControlText;
            gbCocina.Location = new Point(14, 22);
            gbCocina.Name = "gbCocina";
            gbCocina.Size = new Size(113, 81);
            gbCocina.TabIndex = 18;
            gbCocina.TabStop = false;
            gbCocina.Text = "¿Se cocina?";
            // 
            // rbtnNoCocina
            // 
            rbtnNoCocina.AutoSize = true;
            rbtnNoCocina.ForeColor = SystemColors.ControlText;
            rbtnNoCocina.Location = new Point(17, 56);
            rbtnNoCocina.Name = "rbtnNoCocina";
            rbtnNoCocina.Size = new Size(41, 19);
            rbtnNoCocina.TabIndex = 4;
            rbtnNoCocina.TabStop = true;
            rbtnNoCocina.Text = "No";
            rbtnNoCocina.UseVisualStyleBackColor = true;
            // 
            // rbtnSiCocina
            // 
            rbtnSiCocina.AutoSize = true;
            rbtnSiCocina.ForeColor = SystemColors.ControlText;
            rbtnSiCocina.Location = new Point(17, 22);
            rbtnSiCocina.Name = "rbtnSiCocina";
            rbtnSiCocina.Size = new Size(34, 19);
            rbtnSiCocina.TabIndex = 3;
            rbtnSiCocina.TabStop = true;
            rbtnSiCocina.Text = "Si";
            rbtnSiCocina.UseVisualStyleBackColor = true;
            // 
            // gbhoja
            // 
            gbhoja.BackColor = Color.Tan;
            gbhoja.Controls.Add(rbtnNoHoja);
            gbhoja.Controls.Add(rbtnSiHoja);
            gbhoja.ForeColor = SystemColors.ControlText;
            gbhoja.Location = new Point(14, 128);
            gbhoja.Name = "gbhoja";
            gbhoja.Size = new Size(141, 79);
            gbhoja.TabIndex = 19;
            gbhoja.TabStop = false;
            gbhoja.Text = "¿Es una hoja?";
            // 
            // rbtnNoHoja
            // 
            rbtnNoHoja.AutoSize = true;
            rbtnNoHoja.ForeColor = SystemColors.ControlText;
            rbtnNoHoja.Location = new Point(17, 56);
            rbtnNoHoja.Name = "rbtnNoHoja";
            rbtnNoHoja.Size = new Size(41, 19);
            rbtnNoHoja.TabIndex = 4;
            rbtnNoHoja.TabStop = true;
            rbtnNoHoja.Text = "No";
            rbtnNoHoja.UseVisualStyleBackColor = true;
            // 
            // rbtnSiHoja
            // 
            rbtnSiHoja.AutoSize = true;
            rbtnSiHoja.ForeColor = SystemColors.ControlText;
            rbtnSiHoja.Location = new Point(17, 22);
            rbtnSiHoja.Name = "rbtnSiHoja";
            rbtnSiHoja.Size = new Size(34, 19);
            rbtnSiHoja.TabIndex = 3;
            rbtnSiHoja.TabStop = true;
            rbtnSiHoja.Text = "Si";
            rbtnSiHoja.UseVisualStyleBackColor = true;
            // 
            // gbFruta
            // 
            gbFruta.Controls.Add(gbCitrico);
            gbFruta.Controls.Add(gbCascaraComestible);
            gbFruta.Location = new Point(6, 296);
            gbFruta.Name = "gbFruta";
            gbFruta.Size = new Size(160, 223);
            gbFruta.TabIndex = 3;
            gbFruta.TabStop = false;
            // 
            // gbCitrico
            // 
            gbCitrico.BackColor = Color.Tan;
            gbCitrico.Controls.Add(rbtnNoCitrico);
            gbCitrico.Controls.Add(rbtnSiCitrico);
            gbCitrico.ForeColor = SystemColors.ControlText;
            gbCitrico.Location = new Point(14, 27);
            gbCitrico.Name = "gbCitrico";
            gbCitrico.Size = new Size(113, 81);
            gbCitrico.TabIndex = 18;
            gbCitrico.TabStop = false;
            gbCitrico.Text = "¿Es citrico?";
            // 
            // rbtnNoCitrico
            // 
            rbtnNoCitrico.AutoSize = true;
            rbtnNoCitrico.ForeColor = SystemColors.ControlText;
            rbtnNoCitrico.Location = new Point(17, 56);
            rbtnNoCitrico.Name = "rbtnNoCitrico";
            rbtnNoCitrico.Size = new Size(41, 19);
            rbtnNoCitrico.TabIndex = 4;
            rbtnNoCitrico.TabStop = true;
            rbtnNoCitrico.Text = "No";
            rbtnNoCitrico.UseVisualStyleBackColor = true;
            // 
            // rbtnSiCitrico
            // 
            rbtnSiCitrico.AutoSize = true;
            rbtnSiCitrico.ForeColor = SystemColors.ControlText;
            rbtnSiCitrico.Location = new Point(17, 22);
            rbtnSiCitrico.Name = "rbtnSiCitrico";
            rbtnSiCitrico.Size = new Size(34, 19);
            rbtnSiCitrico.TabIndex = 3;
            rbtnSiCitrico.TabStop = true;
            rbtnSiCitrico.Text = "Si";
            rbtnSiCitrico.UseVisualStyleBackColor = true;
            // 
            // gbCascaraComestible
            // 
            gbCascaraComestible.BackColor = Color.Tan;
            gbCascaraComestible.Controls.Add(rbtnNoComestible);
            gbCascaraComestible.Controls.Add(rbtnSiComestible);
            gbCascaraComestible.ForeColor = SystemColors.ControlText;
            gbCascaraComestible.Location = new Point(14, 128);
            gbCascaraComestible.Name = "gbCascaraComestible";
            gbCascaraComestible.Size = new Size(136, 79);
            gbCascaraComestible.TabIndex = 19;
            gbCascaraComestible.TabStop = false;
            gbCascaraComestible.Text = "¿Cascara comestible?";
            // 
            // rbtnNoComestible
            // 
            rbtnNoComestible.AutoSize = true;
            rbtnNoComestible.ForeColor = SystemColors.ControlText;
            rbtnNoComestible.Location = new Point(17, 56);
            rbtnNoComestible.Name = "rbtnNoComestible";
            rbtnNoComestible.Size = new Size(41, 19);
            rbtnNoComestible.TabIndex = 4;
            rbtnNoComestible.TabStop = true;
            rbtnNoComestible.Text = "No";
            rbtnNoComestible.UseVisualStyleBackColor = true;
            // 
            // rbtnSiComestible
            // 
            rbtnSiComestible.AutoSize = true;
            rbtnSiComestible.ForeColor = SystemColors.ControlText;
            rbtnSiComestible.Location = new Point(17, 22);
            rbtnSiComestible.Name = "rbtnSiComestible";
            rbtnSiComestible.Size = new Size(34, 19);
            rbtnSiComestible.TabIndex = 3;
            rbtnSiComestible.TabStop = true;
            rbtnSiComestible.Text = "Si";
            rbtnSiComestible.UseVisualStyleBackColor = true;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(21, 208);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(133, 23);
            txtUnidad.TabIndex = 5;
            // 
            // lblTamanio
            // 
            lblTamanio.AutoSize = true;
            lblTamanio.ForeColor = SystemColors.ControlText;
            lblTamanio.Location = new Point(20, 190);
            lblTamanio.Name = "lblTamanio";
            lblTamanio.Size = new Size(56, 15);
            lblTamanio.TabIndex = 4;
            lblTamanio.Text = "Unidades";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(20, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.OrangeRed;
            btnAgregar.ForeColor = SystemColors.HighlightText;
            btnAgregar.Location = new Point(89, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 38);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.OrangeRed;
            btnConfirmar.ForeColor = SystemColors.HighlightText;
            btnConfirmar.Location = new Point(89, 308);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 43);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.ForeColor = SystemColors.HighlightText;
            btnCancelar.Location = new Point(89, 401);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAgregarOModificarAlimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(722, 560);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAgregar);
            Controls.Add(gbFormulario);
            Controls.Add(btnVolver);
            Controls.Add(groupbox);
            Name = "FormAgregarOModificarAlimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormAgregar";
            FormClosing += WinFormAgregar_FormClosing;
            Load += WinFormAgregar_Load;
            groupbox.ResumeLayout(false);
            groupbox.PerformLayout();
            gbFormulario.ResumeLayout(false);
            gbFormulario.PerformLayout();
            gbCarne.ResumeLayout(false);
            gbCarne.PerformLayout();
            gbVerdura.ResumeLayout(false);
            gbCocina.ResumeLayout(false);
            gbCocina.PerformLayout();
            gbhoja.ResumeLayout(false);
            gbhoja.PerformLayout();
            gbFruta.ResumeLayout(false);
            gbCitrico.ResumeLayout(false);
            gbCitrico.PerformLayout();
            gbCascaraComestible.ResumeLayout(false);
            gbCascaraComestible.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupbox;
        private Label label1;
        private RadioButton rbtnCarne;
        private RadioButton rbtnVerdura;
        private RadioButton rbtnFruta;
        private Button btnVolver;
        private GroupBox gbFormulario;
        private TextBox txtUbicacionCorte;
        private Label label4;
        private TextBox txtOrigen;
        private Label label5;
        private TextBox txtUnidad;
        private Label lblTamanio;
        private TextBox txtNombre;
        private Label lblNombre;
        private GroupBox gbCascaraComestible;
        private RadioButton rbtnNoComestible;
        private RadioButton rbtnSiComestible;
        private GroupBox gbCitrico;
        private RadioButton rbtnNoCitrico;
        private RadioButton rbtnSiCitrico;
        private GroupBox gbVerdura;
        private GroupBox gbCocina;
        private RadioButton rbtnNoCocina;
        private RadioButton rbtnSiCocina;
        private GroupBox gbhoja;
        private RadioButton rbtnNoHoja;
        private RadioButton rbtnSiHoja;
        private GroupBox gbFruta;
        private GroupBox gbCarne;
        private Button btnAgregar;
        private ComboBox cmbColores;
        private Label lblColor;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtEmpresa;
        private Label lblEmpresa;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}