using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace FrontEnd
{
    public partial class Mantenimiento : Form
    {
        private List<Servicio> listaServicios = new List<Servicio>();
        private Servicio servicioSeleccionado = null;
        DataTable dataTable = new DataTable();
        private PantallaPrincipal ventana;
        public event EventHandler ServicioCambiados;

        public Mantenimiento(PantallaPrincipal ventana)
        {
            InitializeComponent();
            crearDataTable();
            ConfigurarGridE();
            comboBoxServicio.Items.Add("Limpieza Dental | ¢ 50.000.00");
            comboBoxServicio.Items.Add("Extracción de muelas | ¢ 40.000.00");
            comboBoxServicio.Items.Add("Extracción de dientes | ¢ 35.000.00");
            comboBoxServicio.Items.Add("Cirugía de cordales | ¢ 110.000.00 ");
            comboBoxServicio.Items.Add("Ortodoncia | ¢ 650.000.00");
            this.ventana = ventana;
        }
        private void CambiarServicio() 
        {



            Servicios(EventArgs.Empty);
        }
        protected virtual void Servicios(EventArgs e) 
        {
        
        ServicioCambiados?.Invoke( this, e);
        
        }
        private void ConfigurarGridE()
        {
            this.dataGridViewServicios.DataSource = null;
            this.dataGridViewServicios.AutoGenerateColumns = true;

            Font Letra = new Font(FontFamily.GenericSansSerif, 8);
        }
        private void ActualizarDataGridView()
        {
            dataGridViewServicios.DataSource = null; // Desasociar cualquier origen de datos existente
            dataGridViewServicios.DataSource = dataTable; // Asociar la lista de servicios al DataGridView
        }


        public void crearDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("NombreServicio", typeof(string));
            dataTable.Columns.Add("PrecioSinIVA", typeof(double));
        }
        private void InicializarDataGridView()
        {
            // Configurar el DataGridView
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.Dock = DockStyle.Fill;
            // Agregar el DataGridView al formulario
            this.Controls.Add(dataGridViewServicios);

            // Crear las columnas
            DataGridViewColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.HeaderText = "Nombre del Servicio";
            columnaNombre.Name = "NombreServicio"; // Nombre único de la columna
            dataGridViewServicios.Columns.Add(columnaNombre);

            DataGridViewColumn columnaCosto = new DataGridViewTextBoxColumn();
            columnaCosto.HeaderText = "Costo sin IVA";
            columnaCosto.Name = "CostoSinIVA"; // Nombre único de la columna
            dataGridViewServicios.Columns.Add(columnaCosto);
        }



        private void comboBoxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string NombreServicio = txtServicio.Text;
                if (string.IsNullOrWhiteSpace(NombreServicio))
                {
                    MessageBox.Show("Por favor ingrese el servicio que desea, debe estar en la lista de servicios de la clínica happy teeth");
                    return;
                }

                if (double.TryParse(txtPrecioSinIva.Text, out double costoSinIva) && costoSinIva > 0)
                {
                    if (servicioSeleccionado == null)
                    {
                        // Agregar el nuevo servicio al ComboBox
                        string newService = $"{NombreServicio} ¢ {costoSinIva:F2}";
                        comboBoxServicio.Items.Add(newService);


                    }
                    // Resto del código para agregar a dataTable o lista de servicios si es necesario
                }
                else
                {
                    MessageBox.Show("El costo debe estar entre los valores decimales válidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo una excepción: " + ex.Message);
                // Puedes agregar más lógica de manejo de excepciones aquí si es necesario.
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreServicio = txtServicio.Text;
            if (string.IsNullOrWhiteSpace(NombreServicio))
            {
                MessageBox.Show("Por favor ingrese el servicio que desea, debe estar en la lista de servicios de la clínica happy teeth");
                return;
            }

            if (double.TryParse(txtPrecioSinIva.Text, out double costoSinIva) && costoSinIva > 0)
            {
                if (servicioSeleccionado == null)
                {
                    // Agregar el nuevo servicio al ComboBox
                    string newService = $"{NombreServicio} ¢ {costoSinIva:F2}";
                    comboBoxServicio.Items.Add(newService);
                    dataTable.Rows.Add(NombreServicio, costoSinIva);

                    // Limpiar campos y ComboBox seleccionado
                    // limpiar();
                }
                // Resto del código para agregar a dataTable o lista de servicios si es necesario
            }
            else
            {
                //Aqui se modifica el servicio existente
                servicioSeleccionado.Nombre = NombreServicio;
                servicioSeleccionado.CostonSinIva = costoSinIva;
                servicioSeleccionado = null;
                // Actualizar la fila en el DataGridView con los datos modificados
                int indiceSeleccionado = dataGridViewServicios.SelectedRows[0].Index;
                dataGridViewServicios[0, indiceSeleccionado].Value = NombreServicio;
                dataGridViewServicios[1, indiceSeleccionado].Value = costoSinIva;
                MessageBox.Show("El costo debe estar entre los valores decimales válidos");
            }
            dataGridViewServicios.DataSource = dataTable;
            dataGridViewServicios.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            this.Hide();
            ventana.Show();

        }
    }

}
