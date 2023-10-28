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
            dataGridViewInfoPanciente = new DataGridView();
            btnSalir = new Button();
            txtIdentificacion = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            lblNombreNinio = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfoPanciente).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInfoPanciente
            // 
            dataGridViewInfoPanciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInfoPanciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfoPanciente.Location = new Point(12, 207);
            dataGridViewInfoPanciente.Name = "dataGridViewInfoPanciente";
            dataGridViewInfoPanciente.RowHeadersWidth = 62;
            dataGridViewInfoPanciente.RowTemplate.Height = 33;
            dataGridViewInfoPanciente.Size = new Size(776, 225);
            dataGridViewInfoPanciente.TabIndex = 28;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(660, 463);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(206, 20);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(150, 31);
            txtIdentificacion.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 20);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 92;
            label3.Text = "Identificacion";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(206, 127);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 127);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 90;
            label2.Text = "Apellido niño";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(206, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 89;
            // 
            // lblNombreNinio
            // 
            lblNombreNinio.AutoSize = true;
            lblNombreNinio.Location = new Point(33, 74);
            lblNombreNinio.Name = "lblNombreNinio";
            lblNombreNinio.Size = new Size(118, 25);
            lblNombreNinio.TabIndex = 87;
            lblNombreNinio.Text = "Nombre niño";
            // 
            // InformacionPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(txtIdentificacion);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(lblNombreNinio);
            Controls.Add(dataGridViewInfoPanciente);
            Controls.Add(btnSalir);
            IsMdiContainer = true;
            Name = "InformacionPaciente";
            Text = "InformacionPaciente";
            Load += InformacionPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfoPanciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInfoPanciente;
        private Button btnSalir;
        private TextBox txtIdentificacion;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label lblNombreNinio;
    }
}