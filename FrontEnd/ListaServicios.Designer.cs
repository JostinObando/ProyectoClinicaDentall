namespace FrontEnd
{
    partial class ListaServicios
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
            lblServicio = new Label();
            dataGridViewServicio = new DataGridView();
            comboBoxServicios = new ComboBox();
            btnAgregar = new Button();
            lblCostoTotall = new Label();
            label1 = new Label();
            lblEstadoServicio = new Label();
            lblSubtotal = new Label();
            btnPagar = new Button();
            btnSalir = new Button();
            txtNombre = new TextBox();
            lblNombreNinio = new Label();
            btnGuardar = new Button();
            txtApellido = new TextBox();
            label2 = new Label();
            txtIdentificacion = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).BeginInit();
            SuspendLayout();
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(25, 176);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(73, 25);
            lblServicio.TabIndex = 66;
            lblServicio.Text = "Servicio";
            // 
            // dataGridViewServicio
            // 
            dataGridViewServicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicio.Location = new Point(25, 224);
            dataGridViewServicio.Name = "dataGridViewServicio";
            dataGridViewServicio.RowHeadersWidth = 62;
            dataGridViewServicio.RowTemplate.Height = 33;
            dataGridViewServicio.Size = new Size(749, 248);
            dataGridViewServicio.TabIndex = 65;
            // 
            // comboBoxServicios
            // 
            comboBoxServicios.FormattingEnabled = true;
            comboBoxServicios.Location = new Point(182, 173);
            comboBoxServicios.Name = "comboBoxServicios";
            comboBoxServicios.Size = new Size(300, 33);
            comboBoxServicios.TabIndex = 64;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(556, 173);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(219, 45);
            btnAgregar.TabIndex = 63;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblCostoTotall
            // 
            lblCostoTotall.AutoSize = true;
            lblCostoTotall.Location = new Point(994, 514);
            lblCostoTotall.Name = "lblCostoTotall";
            lblCostoTotall.Size = new Size(0, 25);
            lblCostoTotall.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(878, 510);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 72;
            label1.Text = "CostoTotal : ";
            // 
            // lblEstadoServicio
            // 
            lblEstadoServicio.AutoSize = true;
            lblEstadoServicio.Location = new Point(542, 595);
            lblEstadoServicio.Name = "lblEstadoServicio";
            lblEstadoServicio.Size = new Size(132, 25);
            lblEstadoServicio.TabIndex = 77;
            lblEstadoServicio.Text = "Estado Servicio";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(569, 510);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(79, 25);
            lblSubtotal.TabIndex = 76;
            lblSubtotal.Text = "Subtotal";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(111, 505);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(112, 34);
            btnPagar.TabIndex = 75;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(345, 505);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 74;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(252, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 81;
            // 
            // lblNombreNinio
            // 
            lblNombreNinio.AutoSize = true;
            lblNombreNinio.Location = new Point(26, 18);
            lblNombreNinio.Name = "lblNombreNinio";
            lblNombreNinio.Size = new Size(118, 25);
            lblNombreNinio.TabIndex = 79;
            lblNombreNinio.Text = "Nombre niño";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(589, 30);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 80;
            btnGuardar.Text = "Consultar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(252, 66);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 83;
            label2.Text = "Apellido niño";
            label2.Click += label2_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(252, 119);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(150, 31);
            txtIdentificacion.TabIndex = 86;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 119);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 85;
            label3.Text = "Identificacion";
            // 
            // ListaServicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 671);
            Controls.Add(txtIdentificacion);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(lblNombreNinio);
            Controls.Add(lblEstadoServicio);
            Controls.Add(lblSubtotal);
            Controls.Add(btnPagar);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(lblCostoTotall);
            Controls.Add(lblServicio);
            Controls.Add(dataGridViewServicio);
            Controls.Add(comboBoxServicios);
            Controls.Add(btnAgregar);
            ForeColor = Color.Black;
            IsMdiContainer = true;
            Name = "ListaServicios";
            Text = "ListaServicios";
            Load += ListaServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServicio;
        private DataGridView dataGridViewServicio;
        private ComboBox comboBoxServicios;
        private Button btnAgregar;
        private Label lblCostoTotall;
        private Label label1;
        private Label lblEstadoServicio;
        private Label lblSubtotal;
        private Button btnPagar;
        private Button btnSalir;
        private TextBox txtNombre;
        private Label lblNombreNinio;
        private Button btnGuardar;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtIdentificacion;
        private Label label3;
    }
}