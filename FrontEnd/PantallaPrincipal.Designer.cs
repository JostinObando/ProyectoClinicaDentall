namespace FrontEnd
{
    partial class PantallaPrincipal
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
            menuStrip1 = new MenuStrip();
            datosPadreToolStripMenuItem = new ToolStripMenuItem();
            datosNinioToolStripMenuItem = new ToolStripMenuItem();
            listaServiciosToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { datosPadreToolStripMenuItem, datosNinioToolStripMenuItem, listaServiciosToolStripMenuItem, mantenimientoToolStripMenuItem, facturaToolStripMenuItem, acercaDeToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(991, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // datosPadreToolStripMenuItem
            // 
            datosPadreToolStripMenuItem.Name = "datosPadreToolStripMenuItem";
            datosPadreToolStripMenuItem.Size = new Size(124, 29);
            datosPadreToolStripMenuItem.Text = "Datos Padre";
            datosPadreToolStripMenuItem.Click += datosPadreToolStripMenuItem_Click;
            // 
            // datosNinioToolStripMenuItem
            // 
            datosNinioToolStripMenuItem.Name = "datosNinioToolStripMenuItem";
            datosNinioToolStripMenuItem.Size = new Size(115, 29);
            datosNinioToolStripMenuItem.Text = "Datos niño";
            datosNinioToolStripMenuItem.Click += datosNinioToolStripMenuItem_Click;
            // 
            // listaServiciosToolStripMenuItem
            // 
            listaServiciosToolStripMenuItem.Name = "listaServiciosToolStripMenuItem";
            listaServiciosToolStripMenuItem.Size = new Size(137, 29);
            listaServiciosToolStripMenuItem.Text = "Lista Servicios";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(148, 29);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            mantenimientoToolStripMenuItem.Click += mantenimientoToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(84, 29);
            facturaToolStripMenuItem.Text = "Factura";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(105, 29);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 29);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem datosPadreToolStripMenuItem;
        private ToolStripMenuItem datosNinioToolStripMenuItem;
        private ToolStripMenuItem listaServiciosToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}