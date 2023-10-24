using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class RegistroNinios : Form
    {
        private List<Padre> listapadres = new List<Padre>();
        private List<DatosPadre> datosPadres = new List<DatosPadre>();

        private PantallaPrincipal ventana;
        public RegistroNinios(PantallaPrincipal ventana)
        {
            InitializeComponent();
            this.ventana = ventana;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //   int idNinio = (int)comboBoxID.SelectedValue;
            //string descripcion = txtDescripcion.Text;
            //   DateTime fecha = dateTimePickerFecha.Value;
            // double costo = double.Parse(txtCosto.Text);
            //var ServcioNinio = new ServicioNinios();

            // ServcioNinio.
            
            //string cedulaPadre =TX.Text;

            // Busca el padre por la cédula
           /// Padre padres;
            //Padre padre = listapadres.FirstOrDefault(p => p.Identicacion == cedulaPadre);

            //if (padre != null)
            //{
               // dataGridView1.DataSource = padre.Hijos;
            //}
            //else
            //{
             //   dataGridView1.DataSource = null;
             //   MessageBox.Show("Padre no encontrado.");
            //}
        }
    

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.Show();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
        }

        private void lblidNinio_Click(object sender, EventArgs e)
        {
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblcosto_Click(object sender, EventArgs e)
        {
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
