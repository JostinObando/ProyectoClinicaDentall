namespace FrontEnd
{
    partial class DatosPadres
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
            lblNombrePadre = new Label();
            lblIdentificacionPadre = new Label();
            lblDireccion = new Label();
            lblCorreoElectronico = new Label();
            lblTelefono = new Label();
            txtNombrePadre = new TextBox();
            txtIdendificacion = new TextBox();
            txtDireccion = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtTelefono = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNombrePadre
            // 
            lblNombrePadre.AutoSize = true;
            lblNombrePadre.Location = new Point(151, 46);
            lblNombrePadre.Name = "lblNombrePadre";
            lblNombrePadre.Size = new Size(156, 25);
            lblNombrePadre.TabIndex = 19;
            lblNombrePadre.Text = "Nombre del Padre";
            // 
            // lblIdentificacionPadre
            // 
            lblIdentificacionPadre.AutoSize = true;
            lblIdentificacionPadre.Location = new Point(167, 95);
            lblIdentificacionPadre.Name = "lblIdentificacionPadre";
            lblIdentificacionPadre.Size = new Size(117, 25);
            lblIdentificacionPadre.TabIndex = 20;
            lblIdentificacionPadre.Text = "Identificacion";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(180, 143);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(85, 25);
            lblDireccion.TabIndex = 21;
            lblDireccion.Text = "Direccion";
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(151, 199);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(157, 25);
            lblCorreoElectronico.TabIndex = 22;
            lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(186, 254);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombrePadre
            // 
            txtNombrePadre.Location = new Point(381, 46);
            txtNombrePadre.Name = "txtNombrePadre";
            txtNombrePadre.Size = new Size(166, 31);
            txtNombrePadre.TabIndex = 24;
            // 
            // txtIdendificacion
            // 
            txtIdendificacion.Location = new Point(381, 92);
            txtIdendificacion.Name = "txtIdendificacion";
            txtIdendificacion.Size = new Size(166, 31);
            txtIdendificacion.TabIndex = 25;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(381, 143);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(166, 31);
            txtDireccion.TabIndex = 26;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(381, 199);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(166, 31);
            txtCorreoElectronico.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(381, 254);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(166, 31);
            txtTelefono.TabIndex = 28;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(172, 330);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 29;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(417, 330);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // DatosPadres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtDireccion);
            Controls.Add(txtIdendificacion);
            Controls.Add(txtNombrePadre);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(lblDireccion);
            Controls.Add(lblIdentificacionPadre);
            Controls.Add(lblNombrePadre);
            IsMdiContainer = true;
            Name = "DatosPadres";
            Text = "DatosPadres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombrePadre;
        private Label lblIdentificacionPadre;
        private Label lblDireccion;
        private Label lblCorreoElectronico;
        private Label lblTelefono;
        private TextBox txtNombrePadre;
        private TextBox txtIdendificacion;
        private TextBox txtDireccion;
        private TextBox txtCorreoElectronico;
        private TextBox txtTelefono;
        private Button btnRegistrar;
        private Button btnSalir;
    }
}