using Datos;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FrontEnd
{
    public partial class RegistroNinios : Form
    {
        // private List<Padre> listapadres = new List<Padre>();
        private List<DatosPadre> datosPadres = new List<DatosPadre>();
        public List<DatosNiño> datosNiños = new List<DatosNiño> { };
        public List<DatosNiños> dat = new List<DatosNiños> { };
        private List<string> serviciosAgregados = new List<string>();



        private PantallaPrincipal ventana;
        public RegistroNinios(PantallaPrincipal ventana)
        {
            //InitializeComponent();
            this.ventana = ventana;
            // Mostrar la cédula en el formulario
            //  textBox1.Text = ;

            // Agregar los servicios al DataGridView
            // foreach (string servicio in servicios)
            {
                //     dataGridViewRegistro.Rows.Add(servicio);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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




            DataTable dtServicios = new DataTable();
            dtServicios.Columns.Add("Servicio", typeof(string));
            dtServicios.Columns.Add("Costo", typeof(string));



            // Realizar una consulta SELECT utilizando LINQ
            var resultado = from persona in ninnoXML.ninnoxml
                            where persona.Identificacion.ToString() == txtIdentificacionNinno.Text.ToString()
                            select new { persona.Identificacion, persona.Nombre };

            foreach (var persona in resultado)
            {
                //string a = persona.Identificacion.ToString();
                //string b = persona.Nombre.ToString();
                //foreach (var item in persona.servicios)
                //{

              //dtServicios.Rows.Add(fila1);

                //}
            }

            //dataGridViewRegistro.DataSource = dtServicios;
            //string cargar = txtDireccionamiento.Text;

            //if (!string.IsNullOrEmpty(cargar) && System.IO.File.Exists(cargar))
            //{
            //    // Crea un nuevo DataSet para almacenar los datos del XML.
            //    DataSet dataSet = new DataSet();

            //    // Lee el archivo XML en el DataSet.
            //    try
            //    {
            //        dataSet.ReadXml(cargar);
            //        if (dataSet.Tables.Count > 0)
            //        {
            //            // Asigna la tabla al DataGridView.
            //            dataGridViewRegistro.DataSource = dataSet.Tables[0];
            //        }
            //        else
            //        {
            //            MessageBox.Show("El archivo XML no contiene datos.", "Aviso");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Ocurrió un error al leer el archivo XML: " + ex.Message, "Error");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, ingresa una dirección de archivo XML válida.", "Aviso");
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

        private void RegistroNinios_Load(object sender, EventArgs e)
        {

        }
    }
}
