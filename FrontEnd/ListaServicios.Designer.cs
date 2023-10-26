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
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).BeginInit();
            SuspendLayout();
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(12, 70);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(73, 25);
            lblServicio.TabIndex = 66;
            lblServicio.Text = "Servicio";
            // 
            // dataGridViewServicio
            // 
            dataGridViewServicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicio.Location = new Point(12, 140);
            dataGridViewServicio.Name = "dataGridViewServicio";
            dataGridViewServicio.RowHeadersWidth = 62;
            dataGridViewServicio.RowTemplate.Height = 33;
            dataGridViewServicio.Size = new Size(749, 248);
            dataGridViewServicio.TabIndex = 65;
            // 
            // comboBoxServicios
            // 
            comboBoxServicios.FormattingEnabled = true;
            comboBoxServicios.Location = new Point(188, 61);
            comboBoxServicios.Name = "comboBoxServicios";
            comboBoxServicios.Size = new Size(300, 33);
            comboBoxServicios.TabIndex = 64;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(542, 61);
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
            lblCostoTotall.Location = new Point(556, 402);
            lblCostoTotall.Name = "lblCostoTotall";
            lblCostoTotall.Size = new Size(0, 25);
            lblCostoTotall.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 402);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 72;
            label1.Text = "CostoTotal : ";
            // 
            // ListaServicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}