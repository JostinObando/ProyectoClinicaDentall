namespace FrontEnd
{
    partial class Funcionario
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
            SuspendLayout();
            // 
            // lblNombreFuncionario
            // 
            lblNombreFuncionario.AutoSize = true;
            lblNombreFuncionario.Location = new Point(91, 48);
            lblNombreFuncionario.Name = "lblNombreFuncionario";
            lblNombreFuncionario.Size = new Size(204, 25);
            lblNombreFuncionario.TabIndex = 1;
            lblNombreFuncionario.Text = "Nombre del Funcionario";
            // 
            // lblApellidoDelFuncionario
            // 
            lblApellidoDelFuncionario.AutoSize = true;
            lblApellidoDelFuncionario.Location = new Point(156, 109);
            lblApellidoDelFuncionario.Name = "lblApellidoDelFuncionario";
            lblApellidoDelFuncionario.Size = new Size(86, 25);
            lblApellidoDelFuncionario.TabIndex = 2;
            lblApellidoDelFuncionario.Text = "Apellidos";
            // 
            // lblIdentificacionFuncionario
            // 
            lblIdentificacionFuncionario.AutoSize = true;
            lblIdentificacionFuncionario.Location = new Point(146, 175);
            lblIdentificacionFuncionario.Name = "lblIdentificacionFuncionario";
            lblIdentificacionFuncionario.Size = new Size(117, 25);
            lblIdentificacionFuncionario.TabIndex = 3;
            lblIdentificacionFuncionario.Text = "Identificacion";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(183, 238);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 25);
            lblSexo.TabIndex = 4;
            lblSexo.Text = "Sexo";
            // 
            // txtIdendificacionFuncionario
            // 
            txtIdendificacionFuncionario.Location = new Point(309, 175);
            txtIdendificacionFuncionario.Name = "txtIdendificacionFuncionario";
            txtIdendificacionFuncionario.Size = new Size(150, 31);
            txtIdendificacionFuncionario.TabIndex = 5;
            // 
            // txtApellidoFuncionario
            // 
            txtApellidoFuncionario.Location = new Point(309, 109);
            txtApellidoFuncionario.Name = "txtApellidoFuncionario";
            txtApellidoFuncionario.Size = new Size(150, 31);
            txtApellidoFuncionario.TabIndex = 6;
            // 
            // txtNombreFuncionario
            // 
            txtNombreFuncionario.Location = new Point(309, 45);
            txtNombreFuncionario.Name = "txtNombreFuncionario";
            txtNombreFuncionario.Size = new Size(150, 31);
            txtNombreFuncionario.TabIndex = 7;
            txtNombreFuncionario.TextChanged += textBox3_TextChanged;
            // 
            // comboBoxSexoFuncioario
            // 
            comboBoxSexoFuncioario.FormattingEnabled = true;
            comboBoxSexoFuncioario.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxSexoFuncioario.Location = new Point(309, 238);
            comboBoxSexoFuncioario.Name = "comboBoxSexoFuncioario";
            comboBoxSexoFuncioario.Size = new Size(182, 33);
            comboBoxSexoFuncioario.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(183, 335);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(360, 335);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(112, 34);
            Cancelar.TabIndex = 10;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Funcionario";
            Text = "Funcionario";
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
    }
}