using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
namespace FrontEnd
{
    public partial class ListaServicios : Form
    {
        private ListaServicios servicioMan;
        public ListaServicios()
        {
            InitializeComponent();
            servicioMan = new ListaServicios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               // string servicioSeleccionado = comboBoxServicios.SelectedItem.ToString();
               // servicioMan.AgregarServicio(servicioSeleccionado);

                // Agregar el servicio a la lista de servicios seleccionados
               /// listBoxServiciosSeleccionados.Items.Add(servicioSeleccionado);
//
             //   // Calcular y mostrar el costo total
             //   double costoTotal = servicioMan.CalcualarCostoTotal();
              //  lblCosroTotal.Text = "Costo Total: " + costoTotal.ToString("C"); // Formatear como moneda
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListaServicios_Load(object sender, EventArgs e)
        {
            //foreach (string servicio in servicioMan.GetListas())
            {
              //  comboBoxServicios.Items.Add(servicio);
            }
        }
    }
}
