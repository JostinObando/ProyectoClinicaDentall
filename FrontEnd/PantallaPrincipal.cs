using System;
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
            DatosPadres datosPadres = new DatosPadres(this);
            datosPadres.Show();
        }

        private void datosNinioToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            DatosNiño datosNiño = new DatosNiño(this);
            datosNiño.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento(this);
            mantenimiento.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //PantallaPrincipal ipantalla = new PantallaPrincipal();
            //ipantalla.MdiParent = this;
            //ipantalla.Show();               
        }

        private void listaServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroNinios registroNinios = new RegistroNinios();
            registroNinios.Show();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
        }
    }
}
