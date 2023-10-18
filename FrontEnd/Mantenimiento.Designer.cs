namespace FrontEnd
{
    partial class Mantenimiento
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
            comboBoxServicio = new ComboBox();
            dataGridViewServicios = new DataGridView();
            btnSalir = new Button();
            btnGuardar = new Button();
            txtPrecioSinIva = new TextBox();
            txtServicio = new TextBox();
            lblCostoSinIba = new Label();
            lblNombreDeServicio = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).BeginInit();
            SuspendLayout();
            // 
            // comboBoxServicio
            // 
            comboBoxServicio.FormattingEnabled = true;
            comboBoxServicio.Location = new Point(545, 15);
            comboBoxServicio.Name = "comboBoxServicio";
            comboBoxServicio.Size = new Size(182, 33);
            comboBoxServicio.TabIndex = 1;
            comboBoxServicio.SelectedIndexChanged += comboBoxServicio_SelectedIndexChanged;
            // 
            // dataGridViewServicios
            // 
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.Location = new Point(27, 126);
            dataGridViewServicios.Margin = new Padding(4, 5, 4, 5);
            dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewServicios.RowHeadersWidth = 62;
            dataGridViewServicios.RowTemplate.Height = 25;
            dataGridViewServicios.Size = new Size(746, 248);
            dataGridViewServicios.TabIndex = 16;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(449, 382);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 33);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(154, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 33);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPrecioSinIva
            // 
            txtPrecioSinIva.Location = new Point(223, 72);
            txtPrecioSinIva.Name = "txtPrecioSinIva";
            txtPrecioSinIva.Size = new Size(150, 31);
            txtPrecioSinIva.TabIndex = 21;
            // 
            // txtServicio
            // 
            txtServicio.Location = new Point(223, 12);
            txtServicio.Name = "txtServicio";
            txtServicio.Size = new Size(150, 31);
            txtServicio.TabIndex = 20;
            // 
            // lblCostoSinIba
            // 
            lblCostoSinIba.AutoSize = true;
            lblCostoSinIba.Location = new Point(60, 78);
            lblCostoSinIba.Name = "lblCostoSinIba";
            lblCostoSinIba.Size = new Size(114, 25);
            lblCostoSinIba.TabIndex = 19;
            lblCostoSinIba.Text = "Precio sin iva";
            // 
            // lblNombreDeServicio
            // 
            lblNombreDeServicio.AutoSize = true;
            lblNombreDeServicio.Location = new Point(27, 15);
            lblNombreDeServicio.Name = "lblNombreDeServicio";
            lblNombreDeServicio.Size = new Size(167, 25);
            lblNombreDeServicio.TabIndex = 18;
            lblNombreDeServicio.Text = "Nombre de servicio";
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecioSinIva);
            Controls.Add(txtServicio);
            Controls.Add(lblCostoSinIba);
            Controls.Add(lblNombreDeServicio);
            Controls.Add(dataGridViewServicios);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(comboBoxServicio);
            IsMdiContainer = true;
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxServicio;
        private DataGridView dataGridViewServicios;
        private Button btnSalir;
        private Button btnGuardar;
        private TextBox txtPrecioSinIva;
        private TextBox txtServicio;
        private Label lblCostoSinIba;
        private Label lblNombreDeServicio;
    }
}