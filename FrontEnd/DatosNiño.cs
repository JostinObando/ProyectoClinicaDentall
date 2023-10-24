
using Negocios;
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
    public partial class DatosNiño : Form
    {

        private List<Niño> listaNiño = new List<Niño>();
        private List<Padre> listaPadre = new List<Padre>();
        private PantallaPrincipal principal;
        private Mantenimiento mantenimiento;

        private List<string> servicios = new List<string>();
        private Dictionary<string, decimal> precios = new Dictionary<string, decimal>
    {
        { "Limpieza Dental", 50000.00m },
        { "Extracción de muelas", 40000.00m },
        { "Extracción de dientes", 35000.00m },
        { "Cirugía de cordales", 110000.00m },
        { "Ortodoncia", 650000.00m }
    };
      
        public DatosNiño(PantallaPrincipal principal, Mantenimiento mantenimiento)

        {
            InitializeComponent();
            this.principal = principal;
            comboBoxServicios.Items.AddRange(precios.Keys.ToArray());
            this.mantenimiento = mantenimiento;
            this.mantenimiento.ServicioCambiados += MantenimientoDeDatos;
        }
        private void MantenimientoDeDatos(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void DatosNiño_Load(object sender, EventArgs e)
        {
            // Agrega las columnas al DataGridView
            dataGridViewServicio.Columns.Add("Servicio", "Servicio");
            dataGridViewServicio.Columns.Add("Costo", "Costo");

            // Configura el DataGridView para que no genere automáticamente columnas
            dataGridViewServicio.AutoGenerateColumns = false;

            // Asigna el ancho de las columnas
            dataGridViewServicio.Columns["Servicio"].Width = 200;
            dataGridViewServicio.Columns["Costo"].Width = 100;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosNiños datos = new DatosNiños();




            try
            {
                // Obtener la fecha de nacimiento del niño
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;

                // Calcular la edad en años y meses
                TimeSpan edad = DateTime.Now - fechaNacimiento;
                int años = edad.Days / 365;
                int meses = (edad.Days % 365) / 30;
                //Valida datos ninio
                if (años >= 1 && (años < 14 || (años == 14 && meses == 0)))
                {
                    // Registro válido, procede con el registro del niño
                    datos.RegistroNinio(txtNombreNiño.Text, txtApellido.Text, txtIdendificacionNiño.Text, fechaNacimiento.ToString(), comboBoxSexoNiño.Text, txtIDPadre.Text);
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("El niño debe tener más de 6 meses y menos de 14 años para ser registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("este es el error: " + ex);
            }





        }
        private bool IdentificacionExistente(string identificacion)
        {
            foreach (Niño niño in listaNiño)
            {
                if
                    (niño.Identificacion == identificacion)
                {
                    return true;

                }

            }
            return false;


        }
        private void Limpiar()
        {
            txtNombreNiño.Clear();
            txtApellido.Clear();
            txtIdendificacionNiño.Clear();
            txtIDPadre.Clear();

        }



        private void comboBoxSexoNiño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblSexo_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();


        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblApellidoDelNiño_Click(object sender, EventArgs e)
        {
        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {
        }

        private void lblIDPadre_Click(object sender, EventArgs e)
        {
        }

        private void lblIdentificacionPadre_Click(object sender, EventArgs e)
        {
        }

        private void lblNombreNiño_Click(object sender, EventArgs e)
        {
        }

        private void txtIDPadre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdendificacionNiño_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombreNiño_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedItem != null)
            {
                string servicio = comboBoxServicios.SelectedItem.ToString();
                servicios.Add(servicio);
                ActualizarDataGridView();
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridViewServicio.Rows.Clear();
            decimal costoTotal = 0.0m;

            foreach (string servicio in servicios)
            {
                decimal costo = precios[servicio];
                costoTotal += costo;
                dataGridViewServicio.Rows.Add(servicio, costo.ToString("C"));
            }

            decimal costoTotalConIVA = costoTotal * 1.0013m;
            lblCosroTotal.Text = costoTotalConIVA.ToString("C");
        }
    }
}
