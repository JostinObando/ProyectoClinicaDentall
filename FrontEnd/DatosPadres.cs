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
        public DatosPadres()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosPadre datos = new DatosPadre();




            try
            {
                // string resultado = datos.RegistroNinio(, apellido, identificacion, fechaNacimiento, sexo, identificacionPadre);
                datos.RegistroPadre(txtNombrePadre.Text, txtIdendificacion.Text, txtDireccion.Text, txtCorreoElectronico.Text, txtTelefono.Text);

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

            this.Close();
            PantallaPrincipal pantalla = new PantallaPrincipal();
            pantalla.Show();

        }
    }
}
