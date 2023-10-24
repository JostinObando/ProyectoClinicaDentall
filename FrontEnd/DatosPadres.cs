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
            DatosPadre datos = new DatosPadre();


            try
            {
                string nombre = txtNombrePadre.Text;
                string identificacion = txtIdendificacion.Text;
                //string resultado = datos.RegistroNinio(, apellido, identificacion, fechaNacimiento, sexo, identificacionPadre);


                if (identificaciones.Contains(identificacion))
                {
                    MessageBox.Show("Identificacion existente en el sistema");
                }

                else
                {
                    identificaciones.Add(identificacion);
                    identificaciones.Add(identificacion);
                    Padre nuevoPadre = new Padre(
                        txtNombrePadre.Text,
                        txtIdendificacion.Text,
                        txtDireccion.Text,
                        txtCorreoElectronico.Text,
                        txtTelefono.Text);
                    listaPadre.Add(nuevoPadre);

// Guardar la lista de padres en un archivo XML
                    PadreXML.GuardarDatosEnXml(listaPadre, @"D:\Proyectos GIT\ProyectoClinicaDentall\FrontEnd\padres.xml");



                    // Serializa y guarda el nuevoPadre en un archivo XML

                }



                {
                    //  if (identificacionExistente == txtIdendificacion.Text) 
                    //   {
                    //   Me

                    //    }





                }

                LimpiarDatos();



            }
            catch (Exception ex)
            {
                MessageBox.Show("este es el error: " + ex);
            }



        }
        private void CargarDatosDesdeXml()
        {
            if (File.Exists("padres.xml"))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Padre>));
                    using (FileStream fs = new FileStream("padres.xml", FileMode.Open))
                    {
                        // Deserializa la lista de padres desde el archivo XML
                        listaPadre = (List<Padre>)xmlSerializer.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos desde el archivo XML: " + ex.Message);
                }
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
