namespace FrontEnd
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            pictureBox1 = new PictureBox();
            lblInstitucion = new Label();
            lblProfesor = new Label();
            lblProyecto = new Label();
            lblCreador = new Label();
            lblEstudiante = new Label();
            lblClinica = new Label();
            lblProfe = new Label();
            lblU = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblInstitucion
            // 
            lblInstitucion.AutoSize = true;
            lblInstitucion.Location = new Point(441, 62);
            lblInstitucion.Name = "lblInstitucion";
            lblInstitucion.Size = new Size(244, 25);
            lblInstitucion.TabIndex = 2;
            lblInstitucion.Text = "Colegio Universitario Cartago";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(463, 114);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(196, 25);
            lblProfesor.TabIndex = 3;
            lblProfesor.Text = "Roger Rodriguez Lopez";
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(451, 171);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(221, 25);
            lblProyecto.TabIndex = 4;
            lblProyecto.Text = "Clinica Dental Happy teeth";
            // 
            // lblCreador
            // 
            lblCreador.AutoSize = true;
            lblCreador.Location = new Point(463, 232);
            lblCreador.Name = "lblCreador";
            lblCreador.Size = new Size(196, 25);
            lblCreador.TabIndex = 5;
            lblCreador.Text = "Jostin Obando Ramirez";
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(341, 232);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(94, 25);
            lblEstudiante.TabIndex = 6;
            lblEstudiante.Text = "Estudiante";
            // 
            // lblClinica
            // 
            lblClinica.AutoSize = true;
            lblClinica.Location = new Point(341, 171);
            lblClinica.Name = "lblClinica";
            lblClinica.Size = new Size(82, 25);
            lblClinica.TabIndex = 7;
            lblClinica.Text = "Proyecto";
            // 
            // lblProfe
            // 
            lblProfe.AutoSize = true;
            lblProfe.Location = new Point(341, 114);
            lblProfe.Name = "lblProfe";
            lblProfe.Size = new Size(79, 25);
            lblProfe.TabIndex = 8;
            lblProfe.Text = "Profesor";
            // 
            // lblU
            // 
            lblU.AutoSize = true;
            lblU.Location = new Point(330, 62);
            lblU.Name = "lblU";
            lblU.Size = new Size(105, 25);
            lblU.TabIndex = 9;
            lblU.Text = "Universidad";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(676, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // AcercaDe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(btnSalir);
            Controls.Add(lblU);
            Controls.Add(lblProfe);
            Controls.Add(lblClinica);
            Controls.Add(lblEstudiante);
            Controls.Add(lblCreador);
            Controls.Add(lblProyecto);
            Controls.Add(lblProfesor);
            Controls.Add(lblInstitucion);
            Controls.Add(pictureBox1);
            IsMdiContainer = true;
            Name = "AcercaDe";
            Text = "AcercaDe";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblInstitucion;
        private Label lblProfesor;
        private Label lblProyecto;
        private Label lblCreador;
        private Label lblEstudiante;
        private Label lblClinica;
        private Label lblProfe;
        private Label lblU;
        private Button btnSalir;
    }
}