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
using Datos;
using Negocios;

namespace FrontEnd
{
    public partial class DatosPadres : Form
    {
        private List<Padre> listaPadre = new List<Padre>();
        private PantallaPrincipal ventanaPrincipal;

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
                // string resultado = datos.RegistroNinio(, apellido, identificacion, fechaNacimiento, sexo, identificacionPadre);


                if (identificacionExistente(identificacion))
                {
                    MessageBox.Show("Identificacion existente en el sistema");
                }

                else
                {
                    datos.RegistroPadre(txtNombrePadre.Text, txtIdendificacion.Text, txtDireccion.Text, txtCorreoElectronico.Text, txtTelefono.Text);
                    MessageBox.Show("Registro Exitoso");
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
        private void AbrirFormActual()
        {
         //  DatosPadre formActual = new DatosPadre(this); // Pasando la instancia de la ventana principal
           // formActual.Show();
        }
        private bool identificacionExistente(string identificacion)
        {
            //Validacion de identificaiones existentes
            foreach (Padre padre in listaPadre)
            {
                if (padre.Identicacion == identificacion)
                {
                    return true;
                    MessageBox.Show("ID existente");


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

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Hide();
            ventanaPrincipal.Show();
            

        }
    }
}
