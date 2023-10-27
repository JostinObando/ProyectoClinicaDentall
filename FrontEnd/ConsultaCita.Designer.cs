namespace FrontEnd
{
    partial class ConsultaCita
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
            dataGridViewFactura = new DataGridView();
            txtIdentificacionNinno = new TextBox();
            btnSalir = new Button();
            btnGuardar = new Button();
            lblidNinio = new Label();
            btnPagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFactura
            // 
            dataGridViewFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFactura.Location = new Point(12, 120);
            dataGridViewFactura.Name = "dataGridViewFactura";
            dataGridViewFactura.RowHeadersWidth = 62;
            dataGridViewFactura.RowTemplate.Height = 33;
            dataGridViewFactura.Size = new Size(711, 225);
            dataGridViewFactura.TabIndex = 28;
            // 
            // txtIdentificacionNinno
            // 
            txtIdentificacionNinno.Location = new Point(297, 39);
            txtIdentificacionNinno.Name = "txtIdentificacionNinno";
            txtIdentificacionNinno.Size = new Size(150, 31);
            txtIdentificacionNinno.TabIndex = 27;
            txtIdentificacionNinno.TextChanged += txtIdentificacionNinno_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(422, 351);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(628, 36);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Consultar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblidNinio
            // 
            lblidNinio.AutoSize = true;
            lblidNinio.Location = new Point(171, 42);
            lblidNinio.Name = "lblidNinio";
            lblidNinio.Size = new Size(117, 25);
            lblidNinio.TabIndex = 24;
            lblidNinio.Text = "Identificacion";
            lblidNinio.Click += lblidNinio_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(186, 351);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(112, 34);
            btnPagar.TabIndex = 30;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // ConsultaCita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 687);
            Controls.Add(btnPagar);
            Controls.Add(dataGridViewFactura);
            Controls.Add(txtIdentificacionNinno);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(lblidNinio);
            IsMdiContainer = true;
            Name = "ConsultaCita";
            Text = "ConsultaCita";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFactura;
        private TextBox txtIdentificacionNinno;
        private Button btnSalir;
        private Button btnGuardar;
        private Label lblidNinio;
        private Button btnPagar;
    }
}