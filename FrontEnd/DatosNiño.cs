
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
        //Inicio de listas
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
           
            CargarServicios();
            CrearDataTable();
            this.ventanaPrincipal = ventanaPrincipal;
             this.mantenimiento = mantenimiento;
        }

        public void CrearDataTable()
        {
            //Crea da
            dataTable = new DataTable("Servicios");

            dataTable.Columns.Add("Servicio", typeof(string));
            dataTable.Columns.Add("Costo", typeof(string));

        }
        public void CargarServicios()
        {
            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {






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
            //Limpiar
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
        }

        private void ActualizarDataGridView(string nombre, string valor)
        {
            
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
                    //Inicio xml
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

                    //Se carga toda la informacion
                    ninnoEncontrado.Nombre = txtNombreNiño.Text;
                    ninnoEncontrado.Apellido = txtApellido.Text;
                    ninnoEncontrado.Identificacion = txtIdendificacionNiño.Text;
                    ninnoEncontrado.Sexo = comboBoxSexoNiño.Text;
                    ninnoEncontrado.FechaNacimiento = Convert.ToDateTime(dateTimePickerFechaNacimiento.Text);
                   
                    ninnoEncontrado.IdentificacionPadre = txtIDPadre.Text;
                
                    List<Servicio> servicios = new List<Servicio>();
                    ninnoXML.ninnoxml.Add(ninnoEncontrado);


                    DatosNiños bldatos = new DatosNiños();


                    DataTable dt = new DataTable();
                    Servicio servicioNinio = new Servicio();



                    bldatos.RegistroNinio(ninnoXML);
                    Limpiar();

                }
                else
                {
                    //Validacion de edad
                    MessageBox.Show("El niño debe tener más de 6 meses y menos de 14 años para ser registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("este es el error: " + ex);
            }//fin del try
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
