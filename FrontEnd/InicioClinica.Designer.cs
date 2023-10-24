namespace FrontEnd
{
    partial class InicioClinica
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
            btnIngresar = new Button();
            btnSalir = new Button();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            txtUsuarioNuevo = new TextBox();
            TxtContra = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(191, 253);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 34);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(397, 253);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(179, 65);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(168, 148);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(105, 25);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contrasenia";
            lblContrasenia.Click += lblContrasenia_Click;
            // 
            // txtUsuarioNuevo
            // 
            txtUsuarioNuevo.Location = new Point(335, 65);
            txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            txtUsuarioNuevo.Size = new Size(150, 31);
            txtUsuarioNuevo.TabIndex = 5;
            txtUsuarioNuevo.Text = "Admin";
            txtUsuarioNuevo.TextChanged += txtUsuarioNuevo_TextChanged;
            // 
            // TxtContra
            // 
            TxtContra.Location = new Point(332, 142);
            TxtContra.Name = "TxtContra";
            TxtContra.PasswordChar = '*';
            TxtContra.Size = new Size(150, 31);
            TxtContra.TabIndex = 6;
            TxtContra.Text = "Admin";
            TxtContra.TextChanged += TxtContra_TextChanged;
            // 
            // InicioClinica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtContra);
            Controls.Add(txtUsuarioNuevo);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            IsMdiContainer = true;
            Name = "InicioClinica";
            Text = "InicioClinica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnSalir;
        private Label lblUsuario;
        private Label lblContrasenia;
        private TextBox txtUsuarioNuevo;
        private TextBox TxtContra;
    }
}