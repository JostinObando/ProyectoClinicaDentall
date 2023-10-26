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
            menuStripPrincipal = new MenuStrip();
            datosPadreToolStripMenuItem = new ToolStripMenuItem();
            datosNinioToolStripMenuItem = new ToolStripMenuItem();
            listaServiciosToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            listaServicioToolStripMenuItem = new ToolStripMenuItem();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.ImageScalingSize = new Size(24, 24);
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { datosPadreToolStripMenuItem, datosNinioToolStripMenuItem, listaServiciosToolStripMenuItem, mantenimientoToolStripMenuItem, facturaToolStripMenuItem, facturaToolStripMenuItem1, acercaDeToolStripMenuItem, salirToolStripMenuItem, listaServicioToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(1189, 33);
            menuStripPrincipal.TabIndex = 1;
            menuStripPrincipal.Text = "menuStrip1";
            menuStripPrincipal.ItemClicked += menuStripPrincipal_ItemClicked;
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
            listaServiciosToolStripMenuItem.Size = new Size(133, 29);
            listaServiciosToolStripMenuItem.Text = "Registro niño";
            listaServiciosToolStripMenuItem.Click += listaServiciosToolStripMenuItem_Click;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(217, 29);
            mantenimientoToolStripMenuItem.Text = "MantenimientoServicios";
            mantenimientoToolStripMenuItem.Click += mantenimientoToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(120, 29);
            facturaToolStripMenuItem.Text = "Funcionario";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem1
            // 
            facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            facturaToolStripMenuItem1.Size = new Size(84, 29);
            facturaToolStripMenuItem1.Text = "Factura";
            facturaToolStripMenuItem1.Click += facturaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(105, 29);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // listaServicioToolStripMenuItem
            // 
            listaServicioToolStripMenuItem.Name = "listaServicioToolStripMenuItem";
            listaServicioToolStripMenuItem.Size = new Size(129, 29);
            listaServicioToolStripMenuItem.Text = "Lista Servicio";
            listaServicioToolStripMenuItem.Click += listaServicioToolStripMenuItem_Click;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 450);
            Controls.Add(menuStripPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menuStripPrincipal;
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            Load += PantallaPrincipal_Load;
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem datosPadreToolStripMenuItem;
        private ToolStripMenuItem datosNinioToolStripMenuItem;
        private ToolStripMenuItem listaServiciosToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem1;
        private ToolStripMenuItem listaServicioToolStripMenuItem;
    }
}