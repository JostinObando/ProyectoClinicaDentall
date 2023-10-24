
using Negocios;
using System.Data;

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

                // Obtener los datos ingresados por el usuario
                string nombre = txtNombreNiño.Text;
                string apellido = txtApellido.Text;
                string identificacion = txtIdendificacionNiño.Text;
                DateTime fechaNacimient = dateTimePickerFechaNacimiento.Value;
                string sexo = comboBoxSexoNiño.Text;
                string identificacionPadre = txtIDPadre.Text;
                //Valida datos ninio
                if (años >= 1 && (años < 14 || (años == 14 && meses == 0)))
                {
                    // Crear un nuevo objeto Niño con los datos ingresados
                    Niño nuevoNiño = new Niño();
                    nuevoNiño.Nombre = nombre;
                    nuevoNiño.Apellido = apellido;
                    nuevoNiño.IdentificacionPadre = identificacion;
                    nuevoNiño.FechaNacimiento = Convert.ToDateTime(fechaNacimiento);
                    nuevoNiño.Sexo = sexo;
                    nuevoNiño.IdentificacionPadre = identificacionPadre;

                    // Agregar el nuevo niño a la lista en memoria
                    listaNiño.Add(nuevoNiño);

                    // Limpiar los campos después de guardar la información
                    Limpiar();
                    // Registro válido, procede con el registro del niño
                    //datos.RegistroNinio(txtNombreNiño.Text, txtApellido.Text, txtIdendificacionNiño.Text, fechaNacimiento.ToString(), comboBoxSexoNiño.Text, txtIDPadre.Text);
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

            decimal costoTotalConIVA = costoTotal * 0.13m;
            lblCosroTotal.Text = costoTotalConIVA.ToString("C");
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            //string identificacion = txtIdendificacionNiño.Text; // Obtener la cédula ingresada

            try
            {
                // Obtener la fecha de nacimiento del niño
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;

                // Calcular la edad en años y meses
                TimeSpan edad = DateTime.Now - fechaNacimiento;
                int años = edad.Days / 365;
                int meses = (edad.Days % 365) / 30;

                // Obtener los datos ingresados por el usuario
                string nombre = txtNombreNiño.Text;
                string apellido = txtApellido.Text;
                string identificacion = txtIdendificacionNiño.Text;
                DateTime fechaNacimient = dateTimePickerFechaNacimiento.Value;
                string sexo = comboBoxSexoNiño.Text;
                string identificacionPadre = txtIDPadre.Text;
                //Valida datos ninio
                if (años >= 1 && (años < 14 || (años == 14 && meses == 0)))
                {
                    // Crear un nuevo objeto Niño con los datos ingresados
                    Niño nuevoNiño = new Niño();
                    nuevoNiño.Nombre = nombre;
                    nuevoNiño.Apellido = apellido;
                    nuevoNiño.IdentificacionPadre = identificacion;
                    nuevoNiño.FechaNacimiento = Convert.ToDateTime(fechaNacimiento);
                    nuevoNiño.Sexo = sexo;
                    nuevoNiño.IdentificacionPadre = identificacionPadre;

                    // Agregar el nuevo niño a la lista en memoria
                    listaNiño.Add(nuevoNiño);

                    // Limpiar los campos después de guardar la información
                    Limpiar();
                    // Registro válido, procede con el registro del niño
                    //datos.RegistroNinio(txtNombreNiño.Text, txtApellido.Text, txtIdendificacionNiño.Text, fechaNacimiento.ToString(), comboBoxSexoNiño.Text, txtIDPadre.Text);
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
            Niño niñoEncontrado = new Niño();

            niñoEncontrado.Nombre = txtNombreNiño.Text;
            niñoEncontrado.Apellido = txtApellido.Text;
            niñoEncontrado.Identificacion = txtIdendificacionNiño.Text;
            niñoEncontrado.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechaNacimiento.Text);
            niñoEncontrado.Sexo = comboBoxServicios.Text;
            niñoEncontrado.IdentificacionPadre = txtIDPadre.Text;
            niñoEncontrado.costoTotal = lblCosroTotal.Text;
            List<Servicio> servicios = new List<Servicio>();

           
           

            DatosNiños bldatos = new DatosNiños();

            DataTable dt = new DataTable();
            Servicio servicioNinio = new Servicio();

            int rowsNumer = 1;
            foreach (DataGridViewRow dgvRow in dataGridViewServicio.Rows)
            {

                while (rowsNumer < dataGridViewServicio.Rows.Count)
                {
                    rowsNumer = rowsNumer + 1;
                    DataRow newRow = dt.NewRow();

                    // Asigna los valores de las celdas del DataGridView a las columnas del DataTable
                    servicioNinio.Nombre = dgvRow.Cells["servicio"].Value.ToString();
                    servicioNinio.CostonSinIva = dgvRow.Cells["costo"].Value.ToString();
                    servicios.Add(servicioNinio);
                }
            }
            niñoEncontrado.servicios = servicios;

            bldatos.RegistroNinio(niñoEncontrado);

            //if (niñoEncontrado != null)
            //{
            //    // El niño fue encontrado, ahora puedes abrir la ventana "RegistrarNiñoForm" y pasar la cédula
            //    RegistroNinios registrarNiñoForm = new RegistroNinios();
            //    registrarNiñoForm.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("No se encontró ningún niño con la cédula proporcionada.");
            //}
        }


    }
}
