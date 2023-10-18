using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FrontEnd
{
    public partial class InicioClinica : Form
    {
        public InicioClinica()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            string usuarioIngresado = txtUsuarioNuevo.Text;
            string contraIngresada = TxtContra.Text;

            try
            {
                // string resultado = datos.RegistroNinio(, apellido, identificacion, fechaNacimiento, sexo, identificacionPadre);
                iniciarSesion.Registro(txtUsuarioNuevo.Text, TxtContra.Text);
                if (iniciarSesion.Registro(usuarioIngresado, contraIngresada))

                {
                    PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                    pantallaPrincipal.Show();
                    this.Hide();


                }
                else
                {

                    MessageBox.Show("Usuario y contraseña incorrectos");

                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible entrar: " + ex);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
