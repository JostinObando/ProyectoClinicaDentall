using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using System.Xml.Serialization;

namespace FrontEnd
{
    public partial class DatosPadres : Form
    {
        private List<Padre> listaPadre = new List<Padre>();
        private PantallaPrincipal ventanaPrincipal;
        private HashSet<string> identificaciones = new HashSet<string>();

        public DatosPadres(PantallaPrincipal pantallaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = pantallaPrincipal;


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosPadre datosPadre = new DatosPadre();
                Padre padre = new Padre();
                xmlPadre xml = new xmlPadre();
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string subfolder = "XMLFiles";
                string filename = "Padre.xml";
                string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);

                if (File.Exists(xmlFilePath))
                {
                    using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(xmlPadre));
                        xml = (xmlPadre)serializer.Deserialize(fileStream);
                    }
                }



                padre.Nombre = txtNombrePadre.Text;
                padre.Identicacion = txtIdendificacion.Text;
                padre.Direccion = txtDireccion.Text;
                padre.Correo = txtCorreoElectronico.Text;
                padre.Telefono = txtTelefono.Text;

                xml.padreXml.Add(padre);


                datosPadre.RegistroPadre(xml);
                LimpiarDatos();

            }
            catch (Exception) { }

        }
        private string RegistroPadre(string nombre, string identificacionPadre, string direccion, string correoPadre, string tel)
        {
            // Verificar si la identificación ya ha sido registrada
            if (identificaciones.Contains(identificacionPadre))
            {
                return "identificacion existente";
            }
            else
            {
                Padre nuevo = new Padre();

                nuevo.Nombre = nombre;
                nuevo.Identicacion = identificacionPadre;
                nuevo.Direccion = direccion;
                nuevo.Correo = correoPadre;
                nuevo.Telefono = tel;

                // Agregar el nuevo padre a la lista
                listaPadre.Add(nuevo);

                // Guardar la lista de padres en un archivo XML
                PadreXML.GuardarDatosEnXml(listaPadre, @"D:\ninnno.xml");

                // Limpiar los datos después del registro
                LimpiarDatos();

                return "Registro exitoso";
            }
        }


        private bool identificacionExistente(string identificacion)
        {
            //Validacion de identificaiones existentes
            foreach (Padre padre in listaPadre)
            {
                if (padre.Identicacion == identificacion)
                {

                    //MessageBox.Show("ID existente");
                    return true;

                }


            }
            return false;




        }

        private void LimpiarDatos()
        {
            //Limpia de datos 
            txtNombrePadre.Clear();
            txtIdendificacion.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreoElectronico.Clear();


        }
        //Aqui se ve si ya la identificacion ya ha sido registrada

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Hide();
            ventanaPrincipal.Show();


        }

        private void dataGridViewServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
