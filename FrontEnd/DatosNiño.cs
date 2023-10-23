﻿
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
        private PantallaPrincipal principal;
        public DatosNiño(PantallaPrincipal principal)

        {
            InitializeComponent();
            this.principal = principal;

        }

        private void DatosNiño_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           DatosNiños datos = new DatosNiños();




            try
            {
                // Obtener la fecha de nacimiento del niño
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;

                // Calcular la edad en años y meses
                TimeSpan edad = DateTime.Now - fechaNacimiento;
                int años = edad.Days / 365;
                int meses = (edad.Days % 365) / 30;
                //Valida datos ninio
                if (años >= 1 && (años < 14 || (años == 14 && meses == 0)))
                {
                    // Registro válido, procede con el registro del niño
                    datos.RegistroNinio(txtNombreNiño.Text, txtApellido.Text, txtIdendificacionNiño.Text, fechaNacimiento.ToString(), comboBoxSexoNiño.Text, txtIDPadre.Text);
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("El niño debe tener más de 6 meses y menos de 14 años para ser registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("este es el error: " + ex);
            }

           



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
            this.Hide();
            principal.Show();


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
