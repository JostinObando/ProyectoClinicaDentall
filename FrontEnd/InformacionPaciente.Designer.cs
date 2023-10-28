namespace FrontEnd
{
    partial class InformacionPaciente
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
            dataGridViewRegistro = new DataGridView();
            txtIdentificacionNinno = new TextBox();
            btnSalir = new Button();
            btnGuardar = new Button();
            lblidNinio = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistro).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRegistro
            // 
            dataGridViewRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegistro.Location = new Point(12, 130);
            dataGridViewRegistro.Name = "dataGridViewRegistro";
            dataGridViewRegistro.RowHeadersWidth = 62;
            dataGridViewRegistro.RowTemplate.Height = 33;
            dataGridViewRegistro.Size = new Size(776, 225);
            dataGridViewRegistro.TabIndex = 28;
            // 
            // txtIdentificacionNinno
            // 
            txtIdentificacionNinno.Location = new Point(281, 43);
            txtIdentificacionNinno.Name = "txtIdentificacionNinno";
            txtIdentificacionNinno.Size = new Size(190, 31);
            txtIdentificacionNinno.TabIndex = 27;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(298, 377);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(528, 40);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(67, 34);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "...";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblidNinio
            // 
            lblidNinio.AutoSize = true;
            lblidNinio.Location = new Point(91, 45);
            lblidNinio.Name = "lblidNinio";
            lblidNinio.Size = new Size(160, 25);
            lblidNinio.TabIndex = 24;
            lblidNinio.Text = "Identificacion Niño";
            // 
            // InformacionPaciente
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
            Name = "InformacionPaciente";
            Text = "InformacionPaciente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRegistro;
        private TextBox txtIdentificacionNinno;
        private Button btnSalir;
        private Button btnGuardar;
        private Label lblidNinio;
    }
}