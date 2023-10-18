using Datos;
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

namespace FrontEnd
{
    public partial class DatosNiño : Form
    {

        private List<Niño> listaNiño = new List<Niño>();
        private List<Padre> listaPadre = new List<Padre>();
        public DatosNiño()
        {
            InitializeComponent();
        }

        private void DatosNiño_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           DatosNiños datos = new DatosNiños();




            try
            {
                // string resultado = datos.RegistroNinio(, apellido, identificacion, fechaNacimiento, sexo, identificacionPadre);
                datos.RegistroNinio(txtNombreNiño.Text, txtApellido.Text, txtIdendificacionNiño.Text, dateTimePickerFechaNacimiento.Value.ToString(), comboBoxSexoNiño.ToString(), txtIDPadre.Text);

                Limpiar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("este es el error: " + ex);
            }

            //string nombre = txtNombreNiño.Text;
            //string apellido = txtApellido.Text;
            //string identificacion = txtIdendificacionNiño.Text;
            //DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
            //string sexo = comboBoxSexoNiño.ToString();
            //string identificacionPadre = txtIDPadre.Text;

            //if (string.IsNullOrEmpty(sexo))
            //{
            //    MessageBox.Show("Por favor seleccione el sexo");
            //    return;


            //}

            //DateTime UnAñoAtras = DateTime.Now.AddYears(-1);
            //if (fechaNacimiento > UnAñoAtras)
            //{
            //    MessageBox.Show("La fecha de nacimiento tiene que ser mayor a un año");
            //    return;

            //}
            //if (IdentificacionExistente(identificacion))
            //{
            //    MessageBox.Show("Identificacio ya registrada en el sistema");

            //}
            //else
            //{

            //  Niño nuevo = new Niño(nombre, apellido, identificacion, fechaNacimiento, sexo, identificacionPadre);
            //    listaNiño.Add(nuevo);
            //    Limpiar();
            //    MessageBox.Show("Registrado con exito");

            //}




        }
        private bool IdentificacionExistente(string identificacion)
        {
            foreach (Niño niño in listaNiño)
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

    

    private void comboBoxSexoNiño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblSexo_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
            PantallaPrincipal pantalla = new PantallaPrincipal();
            pantalla.Show();

        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblApellidoDelNiño_Click(object sender, EventArgs e)
        {
        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {
        }

        private void lblIDPadre_Click(object sender, EventArgs e)
        {
        }

        private void lblIdentificacionPadre_Click(object sender, EventArgs e)
        {
        }

        private void lblNombreNiño_Click(object sender, EventArgs e)
        {
        }

        private void txtIDPadre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdendificacionNiño_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombreNiño_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
