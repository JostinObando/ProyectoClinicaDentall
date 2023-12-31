﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void datosPadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPadres datosPadres = new DatosPadres();
            datosPadres.Show();
        }

        private void datosNinioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosNiño datosNiño = new DatosNiño();
            datosNiño.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();  
            mantenimiento.Show();
        }
    }
}
