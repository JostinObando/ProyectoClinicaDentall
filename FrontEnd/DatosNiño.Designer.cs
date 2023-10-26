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
            lblApellidoDelNiño = new Label();
            lblFechaNacimiento = new Label();
            lblIDPadre = new Label();
            lblIdentificacionPadre = new Label();
            lblNombreNiño = new Label();
            txtIDPadre = new TextBox();
            txtIdendificacionNiño = new TextBox();
            txtApellido = new TextBox();
            txtNombreNiño = new TextBox();
            dataGridViewServicio = new DataGridView();
            lblCosroTotal = new Label();
            comboBoxServicios = new ComboBox();
            btnAgregar = new Button();
            lblServicio = new Label();
            btnServicios = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(227, 212);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(300, 31);
            dateTimePickerFechaNacimiento.TabIndex = 54;
            // 
            // comboBoxSexoNiño
            // 
            comboBoxSexoNiño.FormattingEnabled = true;
            comboBoxSexoNiño.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxSexoNiño.Location = new Point(227, 160);
            comboBoxSexoNiño.Name = "comboBoxSexoNiño";
            comboBoxSexoNiño.Size = new Size(300, 33);
            comboBoxSexoNiño.TabIndex = 53;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(13, 173);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 25);
            lblSexo.TabIndex = 52;
            lblSexo.Text = "Sexo";
            // 
            // lblApellidoDelNiño
            // 
            lblApellidoDelNiño.AutoSize = true;
            lblApellidoDelNiño.Location = new Point(13, 83);
            lblApellidoDelNiño.Name = "lblApellidoDelNiño";
            lblApellidoDelNiño.Size = new Size(86, 25);
            lblApellidoDelNiño.TabIndex = 49;
            lblApellidoDelNiño.Text = "Apellidos";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(13, 212);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(177, 25);
            lblFechaNacimiento.TabIndex = 48;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblIDPadre
            // 
            lblIDPadre.AutoSize = true;
            lblIDPadre.Location = new Point(14, 260);
            lblIDPadre.Name = "lblIDPadre";
            lblIDPadre.Size = new Size(197, 25);
            lblIDPadre.TabIndex = 47;
            lblIDPadre.Text = "Identificacion del padre";
            // 
            // lblIdentificacionPadre
            // 
            lblIdentificacionPadre.AutoSize = true;
            lblIdentificacionPadre.Location = new Point(13, 130);
            lblIdentificacionPadre.Name = "lblIdentificacionPadre";
            lblIdentificacionPadre.Size = new Size(117, 25);
            lblIdentificacionPadre.TabIndex = 46;
            lblIdentificacionPadre.Text = "Identificacion";
            // 
            // lblNombreNiño
            // 
            lblNombreNiño.AutoSize = true;
            lblNombreNiño.Location = new Point(13, 38);
            lblNombreNiño.Name = "lblNombreNiño";
            lblNombreNiño.Size = new Size(147, 25);
            lblNombreNiño.TabIndex = 45;
            lblNombreNiño.Text = "Nombre del niño";
            // 
            // txtIDPadre
            // 
            txtIDPadre.Location = new Point(227, 253);
            txtIDPadre.Name = "txtIDPadre";
            txtIDPadre.Size = new Size(300, 31);
            txtIDPadre.TabIndex = 44;
            // 
            // txtIdendificacionNiño
            // 
            txtIdendificacionNiño.Location = new Point(227, 117);
            txtIdendificacionNiño.Name = "txtIdendificacionNiño";
            txtIdendificacionNiño.Size = new Size(300, 31);
            txtIdendificacionNiño.TabIndex = 43;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(227, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 31);
            txtApellido.TabIndex = 42;
            // 
            // txtNombreNiño
            // 
            txtNombreNiño.Location = new Point(227, 27);
            txtNombreNiño.Name = "txtNombreNiño";
            txtNombreNiño.Size = new Size(300, 31);
            txtNombreNiño.TabIndex = 41;
            // 
            // dataGridViewServicio
            // 
            dataGridViewServicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicio.Location = new Point(13, 387);
            dataGridViewServicio.Name = "dataGridViewServicio";
            dataGridViewServicio.RowHeadersWidth = 62;
            dataGridViewServicio.RowTemplate.Height = 33;
            dataGridViewServicio.Size = new Size(749, 248);
            dataGridViewServicio.TabIndex = 60;
            dataGridViewServicio.CellContentClick += dataGridViewServicio_CellContentClick;
            // 
            // lblCosroTotal
            // 
            lblCosroTotal.AutoSize = true;
            lblCosroTotal.Location = new Point(654, 665);
            lblCosroTotal.Name = "lblCosroTotal";
            lblCosroTotal.Size = new Size(0, 25);
            lblCosroTotal.TabIndex = 59;
            // 
            // comboBoxServicios
            // 
            comboBoxServicios.FormattingEnabled = true;
            comboBoxServicios.Location = new Point(227, 307);
            comboBoxServicios.Name = "comboBoxServicios";
            comboBoxServicios.Size = new Size(300, 33);
            comboBoxServicios.TabIndex = 58;
            comboBoxServicios.SelectedIndexChanged += comboBoxServicios_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(543, 308);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(219, 45);
            btnAgregar.TabIndex = 56;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(13, 317);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(73, 25);
            lblServicio.TabIndex = 62;
            lblServicio.Text = "Servicio";
            lblServicio.Click += lblServicio_Click;
            // 
            // btnServicios
            // 
            btnServicios.Location = new Point(153, 735);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(219, 92);
            btnServicios.TabIndex = 64;
            btnServicios.Text = "Registrar Servicio";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(453, 735);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(219, 92);
            btnCerrar.TabIndex = 67;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 665);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 69;
            label1.Text = "Costo Total : ";
            // 
            // DatosNiño
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 908);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnServicios);
            Controls.Add(lblServicio);
            Controls.Add(dataGridViewServicio);
            Controls.Add(lblCosroTotal);
            Controls.Add(comboBoxServicios);
            Controls.Add(btnAgregar);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(comboBoxSexoNiño);
            Controls.Add(lblSexo);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerFechaNacimiento;
        private ComboBox comboBoxSexoNiño;
        private Label lblSexo;
        private Label lblApellidoDelNiño;
        private Label lblFechaNacimiento;
        private Label lblIDPadre;
        private Label lblIdentificacionPadre;
        private Label lblNombreNiño;
        private TextBox txtIDPadre;
        private TextBox txtIdendificacionNiño;
        private TextBox txtApellido;
        private TextBox txtNombreNiño;
        private DataGridView dataGridViewServicio;
        private Label lblCosroTotal;
        private ComboBox comboBoxServicios;
        private Button btnAgregar;
        private Label lblServicio;
        private Button btnServicios;
        private Button btnCerrar;
        private Label label1;
    }
}