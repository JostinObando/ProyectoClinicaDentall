namespace FrontEnd
{
    partial class Funcionarios
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
            lblNombreFuncionario = new Label();
            lblApellidoDelFuncionario = new Label();
            lblIdentificacionFuncionario = new Label();
            lblSexo = new Label();
            txtIdendificacionFuncionario = new TextBox();
            txtApellidoFuncionario = new TextBox();
            txtNombreFuncionario = new TextBox();
            comboBoxSexoFuncioario = new ComboBox();
            btnRegistrar = new Button();
            Cancelar = new Button();
            comboBoxEstado = new ComboBox();
            txtNombreFUncncionario = new TextBox();
            txtCodigo = new TextBox();
            txtContrasenia = new TextBox();
            lblEstado = new Label();
            lblContrasenia = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreFuncionario
            // 
            lblNombreFuncionario.AutoSize = true;
            lblNombreFuncionario.Location = new Point(23, 10);
            lblNombreFuncionario.Name = "lblNombreFuncionario";
            lblNombreFuncionario.Size = new Size(204, 25);
            lblNombreFuncionario.TabIndex = 1;
            lblNombreFuncionario.Text = "Nombre del Funcionario";
            // 
            // lblApellidoDelFuncionario
            // 
            lblApellidoDelFuncionario.AutoSize = true;
            lblApellidoDelFuncionario.Location = new Point(88, 71);
            lblApellidoDelFuncionario.Name = "lblApellidoDelFuncionario";
            lblApellidoDelFuncionario.Size = new Size(86, 25);
            lblApellidoDelFuncionario.TabIndex = 2;
            lblApellidoDelFuncionario.Text = "Apellidos";
            // 
            // lblIdentificacionFuncionario
            // 
            lblIdentificacionFuncionario.AutoSize = true;
            lblIdentificacionFuncionario.Location = new Point(78, 137);
            lblIdentificacionFuncionario.Name = "lblIdentificacionFuncionario";
            lblIdentificacionFuncionario.Size = new Size(117, 25);
            lblIdentificacionFuncionario.TabIndex = 3;
            lblIdentificacionFuncionario.Text = "Identificacion";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(115, 200);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 25);
            lblSexo.TabIndex = 4;
            lblSexo.Text = "Sexo";
            // 
            // txtIdendificacionFuncionario
            // 
            txtIdendificacionFuncionario.Location = new Point(241, 137);
            txtIdendificacionFuncionario.Name = "txtIdendificacionFuncionario";
            txtIdendificacionFuncionario.Size = new Size(150, 31);
            txtIdendificacionFuncionario.TabIndex = 5;
            // 
            // txtApellidoFuncionario
            // 
            txtApellidoFuncionario.Location = new Point(241, 71);
            txtApellidoFuncionario.Name = "txtApellidoFuncionario";
            txtApellidoFuncionario.Size = new Size(150, 31);
            txtApellidoFuncionario.TabIndex = 6;
            // 
            // txtNombreFuncionario
            // 
            txtNombreFuncionario.Location = new Point(241, 7);
            txtNombreFuncionario.Name = "txtNombreFuncionario";
            txtNombreFuncionario.Size = new Size(150, 31);
            txtNombreFuncionario.TabIndex = 7;
            txtNombreFuncionario.TextChanged += textBox3_TextChanged;
            // 
            // comboBoxSexoFuncioario
            // 
            comboBoxSexoFuncioario.FormattingEnabled = true;
            comboBoxSexoFuncioario.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxSexoFuncioario.Location = new Point(241, 200);
            comboBoxSexoFuncioario.Name = "comboBoxSexoFuncioario";
            comboBoxSexoFuncioario.Size = new Size(182, 33);
            comboBoxSexoFuncioario.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(87, 594);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(296, 594);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(112, 34);
            Cancelar.TabIndex = 10;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "En período de prueba", "Licencia médica", "Vacaciones", "Permiso especial:", "Jubilado ", "Renuncia", "Despedido" });
            comboBoxEstado.Location = new Point(261, 516);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(182, 33);
            comboBoxEstado.TabIndex = 19;
            // 
            // txtNombreFUncncionario
            // 
            txtNombreFUncncionario.Location = new Point(275, 276);
            txtNombreFUncncionario.Name = "txtNombreFUncncionario";
            txtNombreFUncncionario.Size = new Size(150, 31);
            txtNombreFUncncionario.TabIndex = 18;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(275, 359);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 17;
            txtCodigo.TextChanged += textBox2_TextChanged;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(275, 446);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(150, 31);
            txtContrasenia.TabIndex = 16;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(112, 519);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 25);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(82, 446);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(101, 25);
            lblContrasenia.TabIndex = 14;
            lblContrasenia.Text = "Contraseña";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(63, 365);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(136, 25);
            lblCodigo.TabIndex = 13;
            lblCodigo.Text = "Codigo Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 282);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(204, 25);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre del Funcionario";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(509, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(872, 225);
            dataGridView1.TabIndex = 21;
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 705);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxEstado);
            Controls.Add(txtNombreFUncncionario);
            Controls.Add(txtCodigo);
            Controls.Add(txtContrasenia);
            Controls.Add(lblEstado);
            Controls.Add(lblContrasenia);
            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(Cancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(comboBoxSexoFuncioario);
            Controls.Add(txtNombreFuncionario);
            Controls.Add(txtApellidoFuncionario);
            Controls.Add(txtIdendificacionFuncionario);
            Controls.Add(lblSexo);
            Controls.Add(lblIdentificacionFuncionario);
            Controls.Add(lblApellidoDelFuncionario);
            Controls.Add(lblNombreFuncionario);
            IsMdiContainer = true;
            Name = "Funcionarios";
            Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreFuncionario;
        private Label lblApellidoDelFuncionario;
        private Label lblIdentificacionFuncionario;
        private Label lblSexo;
        private TextBox txtIdendificacionFuncionario;
        private TextBox txtApellidoFuncionario;
        private TextBox txtNombreFuncionario;
        private ComboBox comboBoxSexoFuncioario;
        private Button btnRegistrar;
        private Button Cancelar;
        private ComboBox comboBoxEstado;
        private TextBox txtNombreFUncncionario;
        private TextBox txtCodigo;
        private TextBox txtContrasenia;
        private Label lblEstado;
        private Label lblContrasenia;
        private Label lblCodigo;
        private Label lblNombre;
        private DataGridView dataGridView1;
    }
}