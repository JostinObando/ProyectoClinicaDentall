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
    public partial class AcercaDe : Form
    {
        private PantallaPrincipal principal;
        private PantallaPrincipal ventanaPrincipal;

        public AcercaDe(PantallaPrincipal ventanaPrincipla)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaPrincipal.Show();


        }
    }
}
