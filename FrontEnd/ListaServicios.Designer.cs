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
            btnGuardar = new Button();
            btnSalir = new Button();
            comboBoxServicios = new ComboBox();
            lblCosroTotal = new Label();
            dataGridViewServicio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(393, 31);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(393, 99);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // comboBoxServicios
            // 
            comboBoxServicios.FormattingEnabled = true;
            comboBoxServicios.Location = new Point(98, 62);
            comboBoxServicios.Name = "comboBoxServicios";
            comboBoxServicios.Size = new Size(182, 33);
            comboBoxServicios.TabIndex = 3;
            comboBoxServicios.SelectedIndexChanged += comboBoxServicios_SelectedIndexChanged;
            // 
            // lblCosroTotal
            // 
            lblCosroTotal.AutoSize = true;
            lblCosroTotal.Location = new Point(563, 50);
            lblCosroTotal.Name = "lblCosroTotal";
            lblCosroTotal.Size = new Size(115, 25);
            lblCosroTotal.TabIndex = 6;
            lblCosroTotal.Text = "Costo Total : ";
            // 
            // dataGridViewServicio
            // 
            dataGridViewServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicio.Location = new Point(12, 190);
            dataGridViewServicio.Name = "dataGridViewServicio";
            dataGridViewServicio.RowHeadersWidth = 62;
            dataGridViewServicio.RowTemplate.Height = 33;
            dataGridViewServicio.Size = new Size(791, 248);
            dataGridViewServicio.TabIndex = 8;
            // 
            // ListaServicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewServicio);
            Controls.Add(lblCosroTotal);
            Controls.Add(comboBoxServicios);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
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

        private Button btnGuardar;
        private Button btnSalir;
        private ComboBox comboBoxServicios;
        private Label lblCosroTotal;
        private DataGridView dataGridViewServicio;
    }
}