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
                    Padre nuevo = new Padre();

                    nuevo.Nombre = txtNombrePadre.Text;
                    nuevo.Identicacion = txtIdendificacion.Text;
                    nuevo.Direccion = txtDireccion.Text;
                    nuevo.Correo = txtCorreoElectronico.Text;
                    nuevo.Telefono = txtTelefono.Text;

                    listaPadre.Add(nuevo);

// Guardar la lista de padres en un archivo XML
                    



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
