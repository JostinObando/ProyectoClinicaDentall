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
            btnSalir = new Button();
            btnGuardar = new Button();
            lblidNinio = new Label();
            txtIdentificacionNinno = new TextBox();
            dataGridViewRegistro = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistro).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(298, 389);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(528, 52);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(67, 34);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "...";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblidNinio
            // 
            lblidNinio.AutoSize = true;
            lblidNinio.Location = new Point(91, 57);
            lblidNinio.Name = "lblidNinio";
            lblidNinio.Size = new Size(160, 25);
            lblidNinio.TabIndex = 16;
            lblidNinio.Text = "Identificacion Niño";
            lblidNinio.Click += lblidNinio_Click;
            // 
            // txtIdentificacionNinno
            // 
            txtIdentificacionNinno.Location = new Point(257, 54);
            txtIdentificacionNinno.Name = "txtIdentificacionNinno";
            txtIdentificacionNinno.Size = new Size(190, 31);
            txtIdentificacionNinno.TabIndex = 22;
            // 
            // dataGridViewRegistro
            // 
            dataGridViewRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegistro.Location = new Point(12, 142);
            dataGridViewRegistro.Name = "dataGridViewRegistro";
            dataGridViewRegistro.RowHeadersWidth = 62;
            dataGridViewRegistro.RowTemplate.Height = 33;
            dataGridViewRegistro.Size = new Size(776, 225);
            dataGridViewRegistro.TabIndex = 23;
            // 
            // RegistroNinios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewRegistro);
            Controls.Add(txtIdentificacionNinno);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(lblidNinio);
            IsMdiContainer = true;
            Name = "RegistroNinios";
            Text = "RegistroNinios";
            Load += RegistroNinios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private Button btnGuardar;
        private Label lblidNinio;
        private TextBox txtIdentificacionNinno;
        private DataGridView dataGridViewRegistro;
    }
}