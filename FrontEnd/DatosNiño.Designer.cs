namespace FrontEnd
{
    partial class DatosNiño
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
            dateTimePickerFechaNacimiento = new DateTimePicker();
            comboBoxSexoNiño = new ComboBox();
            lblSexo = new Label();
            btnSalir = new Button();
            btnRegistrar = new Button();
            lblApellidoDelNiño = new Label();
            lblFechaNacimiento = new Label();
            lblIDPadre = new Label();
            lblIdentificacionPadre = new Label();
            lblNombreNiño = new Label();
            txtIDPadre = new TextBox();
            txtIdendificacionNiño = new TextBox();
            txtApellido = new TextBox();
            txtNombreNiño = new TextBox();
            SuspendLayout();
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(356, 245);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(300, 31);
            dateTimePickerFechaNacimiento.TabIndex = 54;
            dateTimePickerFechaNacimiento.ValueChanged += dateTimePickerFechaNacimiento_ValueChanged;
            // 
            // comboBoxSexoNiño
            // 
            comboBoxSexoNiño.FormattingEnabled = true;
            comboBoxSexoNiño.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxSexoNiño.Location = new Point(356, 194);
            comboBoxSexoNiño.Name = "comboBoxSexoNiño";
            comboBoxSexoNiño.Size = new Size(182, 33);
            comboBoxSexoNiño.TabIndex = 53;
            comboBoxSexoNiño.SelectedIndexChanged += comboBoxSexoNiño_SelectedIndexChanged;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(238, 194);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 25);
            lblSexo.TabIndex = 52;
            lblSexo.Text = "Sexo";
            lblSexo.Click += lblSexo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(410, 355);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 51;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(229, 355);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 50;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblApellidoDelNiño
            // 
            lblApellidoDelNiño.AutoSize = true;
            lblApellidoDelNiño.Location = new Point(226, 104);
            lblApellidoDelNiño.Name = "lblApellidoDelNiño";
            lblApellidoDelNiño.Size = new Size(86, 25);
            lblApellidoDelNiño.TabIndex = 49;
            lblApellidoDelNiño.Text = "Apellidos";
            lblApellidoDelNiño.Click += lblApellidoDelNiño_Click;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(155, 245);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(177, 25);
            lblFechaNacimiento.TabIndex = 48;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            lblFechaNacimiento.Click += lblFechaNacimiento_Click;
            // 
            // lblIDPadre
            // 
            lblIDPadre.AutoSize = true;
            lblIDPadre.Location = new Point(144, 294);
            lblIDPadre.Name = "lblIDPadre";
            lblIDPadre.Size = new Size(197, 25);
            lblIDPadre.TabIndex = 47;
            lblIDPadre.Text = "Identificacion del padre";
            lblIDPadre.Click += lblIDPadre_Click;
            // 
            // lblIdentificacionPadre
            // 
            lblIdentificacionPadre.AutoSize = true;
            lblIdentificacionPadre.Location = new Point(205, 151);
            lblIdentificacionPadre.Name = "lblIdentificacionPadre";
            lblIdentificacionPadre.Size = new Size(117, 25);
            lblIdentificacionPadre.TabIndex = 46;
            lblIdentificacionPadre.Text = "Identificacion";
            lblIdentificacionPadre.Click += lblIdentificacionPadre_Click;
            // 
            // lblNombreNiño
            // 
            lblNombreNiño.AutoSize = true;
            lblNombreNiño.Location = new Point(194, 67);
            lblNombreNiño.Name = "lblNombreNiño";
            lblNombreNiño.Size = new Size(147, 25);
            lblNombreNiño.TabIndex = 45;
            lblNombreNiño.Text = "Nombre del niño";
            lblNombreNiño.Click += lblNombreNiño_Click;
            // 
            // txtIDPadre
            // 
            txtIDPadre.Location = new Point(356, 294);
            txtIDPadre.Name = "txtIDPadre";
            txtIDPadre.Size = new Size(166, 31);
            txtIDPadre.TabIndex = 44;
            txtIDPadre.TextChanged += txtIDPadre_TextChanged;
            // 
            // txtIdendificacionNiño
            // 
            txtIdendificacionNiño.Location = new Point(356, 151);
            txtIdendificacionNiño.Name = "txtIdendificacionNiño";
            txtIdendificacionNiño.Size = new Size(166, 31);
            txtIdendificacionNiño.TabIndex = 43;
            txtIdendificacionNiño.TextChanged += txtIdendificacionNiño_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(356, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(166, 31);
            txtApellido.TabIndex = 42;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtNombreNiño
            // 
            txtNombreNiño.Location = new Point(356, 61);
            txtNombreNiño.Name = "txtNombreNiño";
            txtNombreNiño.Size = new Size(166, 31);
            txtNombreNiño.TabIndex = 41;
            txtNombreNiño.TextChanged += txtNombreNiño_TextChanged;
            // 
            // DatosNiño
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(comboBoxSexoNiño);
            Controls.Add(lblSexo);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(lblApellidoDelNiño);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblIDPadre);
            Controls.Add(lblIdentificacionPadre);
            Controls.Add(lblNombreNiño);
            Controls.Add(txtIDPadre);
            Controls.Add(txtIdendificacionNiño);
            Controls.Add(txtApellido);
            Controls.Add(txtNombreNiño);
            IsMdiContainer = true;
            Name = "DatosNiño";
            Text = "DatosNiño";
            Load += DatosNiño_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerFechaNacimiento;
        private ComboBox comboBoxSexoNiño;
        private Label lblSexo;
        private Button btnSalir;
        private Button btnRegistrar;
        private Label lblApellidoDelNiño;
        private Label lblFechaNacimiento;
        private Label lblIDPadre;
        private Label lblIdentificacionPadre;
        private Label lblNombreNiño;
        private TextBox txtIDPadre;
        private TextBox txtIdendificacionNiño;
        private TextBox txtApellido;
        private TextBox txtNombreNiño;
    }
}