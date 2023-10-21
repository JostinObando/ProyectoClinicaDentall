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
        //private ListaServicios servicioMan;
        ListaServicio servicioMan = new ListaServicio();
        private PantallaPrincipal ventanaPrincipal;

        public ListaServicios(PantallaPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {

                string servicioSeleccionado = comboBoxServicios.SelectedItem.ToString();
                servicioMan.AgregarServicio(servicioSeleccionado);

                // Agregar el servicio al DataGridView
                double costo = servicioMan.CalcularCostoTotal();
                dataGridViewServicio.Rows.Add(servicioSeleccionado, costo);

                // Calcular y mostrar el costo total
                double costoTotal = servicioMan.CalcularCostoTotal();
                lblCosroTotal.Text = "Costo Total: " + costoTotal.ToString("C"); // Formatear como moneda
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListaServicios_Load(object sender, EventArgs e)
        {
            // Cargar los servicios disponibles en el ComboBox
            foreach (string servicio in servicioMan.GetServiciosDisponibles())
            {
                comboBoxServicios.Items.Add(servicio);
            }
            //  {
            //comboBoxServicios.Items.Add(servicio);
            //}

            // Configurar las columnas del DataGridView
            dataGridViewServicio.Columns.Add("Nombre", "Nombre");
            dataGridViewServicio.Columns.Add("Costo", "Costo");
        }

        private void comboBoxServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaPrincipal.Show();

        }
    }
}
