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
            btnGuardar = new Button();
            btnSalir = new Button();
            comboBoxServicios = new ComboBox();
            listViewServicios = new ListView();
            colServicio = new ColumnHeader();
            colCosto = new ColumnHeader();
            lblCosroTotal = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(393, 31);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(393, 90);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // comboBoxServicios
            // 
            comboBoxServicios.FormattingEnabled = true;
            comboBoxServicios.Location = new Point(98, 62);
            comboBoxServicios.Name = "comboBoxServicios";
            comboBoxServicios.Size = new Size(182, 33);
            comboBoxServicios.TabIndex = 3;
            // 
            // listViewServicios
            // 
            listViewServicios.BackColor = SystemColors.ActiveCaption;
            listViewServicios.Columns.AddRange(new ColumnHeader[] { colServicio, colCosto });
            listViewServicios.Dock = DockStyle.Bottom;
            listViewServicios.GridLines = true;
            listViewServicios.Location = new Point(0, 160);
            listViewServicios.Name = "listViewServicios";
            listViewServicios.Size = new Size(800, 290);
            listViewServicios.TabIndex = 4;
            listViewServicios.UseCompatibleStateImageBehavior = false;
            listViewServicios.View = View.Details;
            // 
            // colServicio
            // 
            colServicio.Text = "Servicios";
            colServicio.Width = 300;
            // 
            // colCosto
            // 
            colCosto.Text = "Monto";
            colCosto.Width = 300;
            // 
            // lblCosroTotal
            // 
            lblCosroTotal.AutoSize = true;
            lblCosroTotal.Location = new Point(563, 50);
            lblCosroTotal.Name = "lblCosroTotal";
            lblCosroTotal.Size = new Size(115, 25);
            lblCosroTotal.TabIndex = 6;
            lblCosroTotal.Text = "Costo Total : ";
            // 
            // ListaServicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCosroTotal);
            Controls.Add(listViewServicios);
            Controls.Add(comboBoxServicios);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            ForeColor = Color.Black;
            IsMdiContainer = true;
            Name = "ListaServicios";
            Text = "ListaServicios";
            Load += ListaServicios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnSalir;
        private ComboBox comboBoxServicios;
        private ListView listViewServicios;
        private ColumnHeader colServicio;
        private ColumnHeader colCosto;
        private Label lblCosroTotal;
    }
}