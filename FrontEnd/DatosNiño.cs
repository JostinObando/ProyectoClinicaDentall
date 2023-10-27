
using AngleSharp.Dom;
using Negocios;
using Newtonsoft.Json;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace FrontEnd
{
    public partial class DatosNiño : Form
    {

        private List<Ninno> listaNiño = new List<Ninno>();
        private List<Padre> listaPadre = new List<Padre>();
        private PantallaPrincipal principal;
        private PantallaPrincipal ventanaPrincipal;
        private Mantenimiento mantenimiento;
        DataTable dataTable = new DataTable("Servisios");
        private List<string> servicios = new List<string>();

        public DatosNiño(PantallaPrincipal ventanaPrincipal)

        {
            InitializeComponent();
            // this.principal = principal;
            CargarServicios();
            CrearDataTable();
            this.ventanaPrincipal = ventanaPrincipal;
            //  this.mantenimiento = mantenimiento;
        }

        public void CrearDataTable()
        {
            dataTable = new DataTable("Servicios");

            dataTable.Columns.Add("Servicio", typeof(string));
            dataTable.Columns.Add("Costo", typeof(string));

        }
        public void CargarServicios()
        {
            try
            {
                ServicioModel servicio = new ServicioModel();
                ServicioModelList ser = new ServicioModelList();

                servicio.Nombre = "Limpieza Dental";
                servicio.Precio = 50000.00m;

                ser.listServicioModel.Add(servicio);
                servicio = new ServicioModel();
                servicio.Nombre = "Extracción de muelas";
                servicio.Precio = 40000.00m;

                ser.listServicioModel.Add(servicio);

                servicio = new ServicioModel();
                servicio.Nombre = "Extracción de dientes";
                servicio.Precio = 35000.00m;

                ser.listServicioModel.Add(servicio);

                servicio = new ServicioModel();
                servicio.Nombre = "Cirugía de cordales";
                servicio.Precio = 110000.00m;

                ser.listServicioModel.Add(servicio);

                servicio = new ServicioModel();
                servicio.Nombre = "Ortodoncial";
                servicio.Precio = 650000.00m;
                ser.listServicioModel.Add(servicio);

                try
                {
                    comboBoxServicios.DataSource = ser.listServicioModel;
                    comboBoxServicios.DisplayMember = "Nombre";
                    comboBoxServicios.ValueMember = "Precio";
                }
                catch (Exception ex)
                {
                    string a = ex.Message;
                }
            }
            catch (Exception)
            {

                throw;
            }



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
                    Ninno nuevoNiño = new Ninno();
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
            foreach (Ninno niño in listaNiño)
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



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();


        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {




            if (comboBoxServicios.SelectedItem != null)
            {
                servicios.Add(comboBoxServicios.Text.ToString());
                ActualizarDataGridView(comboBoxServicios.Text.ToString(), comboBoxServicios.SelectedValue.ToString());
            }
        }

        private void ActualizarDataGridView(string nombre, string valor)
        {
            //dataGridViewServicio.Rows.Clear();

            DataRow fila1 = dataTable.NewRow();
            fila1["Servicio"] = nombre;
            fila1["Costo"] = valor;

            // Agregar la fila a la tabla
            dataTable.Rows.Add(fila1);
            double costoTotal = 0.0;

            dataGridViewServicio.DataSource = dataTable;
            double costoTotalConIVA = Convert.ToDouble(valor) * 0.13;
            if (string.IsNullOrEmpty(lblCosroTotal.Text))
                costoTotal = Convert.ToDouble(valor);
            else
                costoTotal = Convert.ToDouble(lblCosroTotal.Text) + Convert.ToDouble(valor);


            lblCosroTotal.Text = (costoTotal + costoTotalConIVA).ToString();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fecha de nacimiento del niño
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                // Calcular la edad en años y meses
                TimeSpan edad = DateTime.Now - fechaNacimiento;
                int años = edad.Days / 365;
                int meses = (edad.Days % 365) / 30;

                if (años >= 1 && (años < 14 || (años == 14 && meses == 0)))
                {
                    NinnoXML ninnoXML = new NinnoXML();
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string subfolder = "XMLFiles";
                    string filename = "ninnno.xml";
                    string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);

                    if (File.Exists(xmlFilePath))
                    {
                        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(NinnoXML));
                            ninnoXML = (NinnoXML)serializer.Deserialize(fileStream);
                        }
                    }

                    Ninno ninnoEncontrado = new Ninno();

                    ninnoEncontrado.Nombre = txtNombreNiño.Text;
                    ninnoEncontrado.Apellido = txtApellido.Text;
                    ninnoEncontrado.Identificacion = txtIdendificacionNiño.Text;
                    ninnoEncontrado.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechaNacimiento.Text);
                    ninnoEncontrado.Sexo = comboBoxServicios.Text;
                    ninnoEncontrado.IdentificacionPadre = txtIDPadre.Text;
                    ninnoEncontrado.costoTotal = lblCosroTotal.Text;
                    List<Servicio> servicios = new List<Servicio>();
                    ninnoXML.ninnoxml.Add(ninnoEncontrado);


                    DatosNiños bldatos = new DatosNiños();


                    DataTable dt = new DataTable();
                    Servicio servicioNinio = new Servicio();



                    bldatos.RegistroNinio(ninnoXML);

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Hide();
            ventanaPrincipal.Show();

        }

        private void lblServicio_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }//fin del  main
}//fin de la clase
