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
        //Listas
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
                
                //Se carga xml
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

                //se pasa la info al xml

                padre.Nombre = txtNombrePadre.Text;
                padre.Identicacion = txtIdendificacion.Text;
                padre.Direccion = txtDireccion.Text;
                padre.Correo = txtCorreoElectronico.Text;
                padre.Telefono = txtTelefono.Text;

                xml.padreXml.Add(padre);


                datosPadre.RegistroPadre(xml);
                LimpiarDatos();

            }
            catch (Exception)
            { 

            }//fin try






        }
        //private string RegistroPadre(string nombre, string identificacionPadre, string direccion, string correoPadre, string tel)
        //{
        //    // Verificar si la identificación ya ha sido registrada
        //    if (identificaciones.Contains(identificacionPadre))
        //    {
        //        return "identificacion existente";
        //    }
            
       

        //}


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
        //

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir
            this.Hide();
            ventanaPrincipal.Show();


        }

        private void dataGridViewServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
