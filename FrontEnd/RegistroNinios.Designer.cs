namespace FrontEnd
{
    partial class RegistroNinios
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
            lblFecha = new Label();
            dateTimePickerFecha = new DateTimePicker();
            btnSalir = new Button();
            btnGuardar = new Button();
            lblidNinio = new Label();
            txtDescripcion = new TextBox();
            txtCosto = new TextBox();
            lblcosto = new Label();
            lblDescripcion = new Label();
            comboBoxID = new ComboBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(211, 210);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 20;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(308, 205);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(300, 31);
            dateTimePickerFecha.TabIndex = 19;
            dateTimePickerFecha.ValueChanged += dateTimePickerFecha_ValueChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(394, 328);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(211, 328);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblidNinio
            // 
            lblidNinio.AutoSize = true;
            lblidNinio.Location = new Point(209, 96);
            lblidNinio.Name = "lblidNinio";
            lblidNinio.Size = new Size(30, 25);
            lblidNinio.TabIndex = 16;
            lblidNinio.Text = "ID";
            lblidNinio.Click += lblidNinio_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(321, 158);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 15;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(321, 257);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(150, 31);
            txtCosto.TabIndex = 14;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // lblcosto
            // 
            lblcosto.AutoSize = true;
            lblcosto.Location = new Point(209, 257);
            lblcosto.Name = "lblcosto";
            lblcosto.Size = new Size(59, 25);
            lblcosto.TabIndex = 13;
            lblcosto.Text = "Costo";
            lblcosto.Click += lblcosto_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(193, 158);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 25);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // comboBoxID
            // 
            comboBoxID.FormattingEnabled = true;
            comboBoxID.Location = new Point(308, 88);
            comboBoxID.Name = "comboBoxID";
            comboBoxID.Size = new Size(182, 33);
            comboBoxID.TabIndex = 11;
            comboBoxID.SelectedIndexChanged += comboBoxID_SelectedIndexChanged;
            // 
            // RegistroNinios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFecha);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(lblidNinio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCosto);
            Controls.Add(lblcosto);
            Controls.Add(lblDescripcion);
            Controls.Add(comboBoxID);
            IsMdiContainer = true;
            Name = "RegistroNinios";
            Text = "RegistroNinios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private DateTimePicker dateTimePickerFecha;
        private Button btnSalir;
        private Button btnGuardar;
        private Label lblidNinio;
        private TextBox txtDescripcion;
        private TextBox txtCosto;
        private Label lblcosto;
        private Label lblDescripcion;
        private ComboBox comboBoxID;
    }
}