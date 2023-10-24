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
    public partial class Funcionario : Form

    {
        private List<RFuncionario> RFuncionarios = new List<RFuncionario>();
        public Funcionario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreFuncionario.Text;
            string apellido = txtApellidoFuncionario.Text;
            string identificacion = txtIdendificacionFuncionario.Text;
            string sexo = comboBoxSexoFuncioario.Text;

            // Realizar validaciones
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(identificacion) || string.IsNullOrWhiteSpace(sexo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return; // Salir del evento si falta algún dato
            }


            // Crear una instancia de Funcionario y establecer los datos
            RFuncionario rFuncionario = new RFuncionario
            {
                //   nombre 
                NombreFuncionario = nombre,
                ApellidoFuncionario = apellido,
                IdentificacionFuncionario = identificacion,
                SexoFuncionario = sexo
            };

            // Llamar a métodos de la capa de negocio para guardar el funcionario, por ejemplo:
            // Negocio.GuardarFuncionario(nuevoFuncionario);

            // Limpiar los campos del formulario
            txtNombreFuncionario.Clear();
            txtApellidoFuncionario.Clear();
            txtIdendificacionFuncionario.Clear();


            MessageBox.Show("Funcionario guardado exitosamente.");


        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
