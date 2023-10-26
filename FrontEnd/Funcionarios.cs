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
using System.Xml.Serialization;

namespace FrontEnd
{
    public partial class Funcionarios : Form

    {
        private List<RFuncionario> RFuncionarios = new List<RFuncionario>();
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreFuncionario.Text) || string.IsNullOrWhiteSpace(txtApellidoFuncionario.Text) || string.IsNullOrWhiteSpace(txtIdendificacionFuncionario.Text))
                MessageBox.Show("Por favor, complete todos los campos.");

                 // Salir del evento si falta algún dato
            Funcionario funcionario = new Funcionario();
            RFuncionario fun = new RFuncionario();
            xmlFuncionario xml = new xmlFuncionario();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string subfolder = "XMLFiles";
            string filename = "Funcionario.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);

            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(xmlFuncionario));
                    xml = (xmlFuncionario)serializer.Deserialize(fileStream);
                }
            }
            fun.NombreFuncionario = txtNombreFuncionario.Text;
            fun.ApellidoFuncionario = txtApellidoFuncionario.Text;
            fun.IdentificacionFuncionario = txtIdendificacionFuncionario.Text;
            fun.SexoFuncionario = comboBoxSexoFuncioario.Text;
            fun.nombreCompleto = txtNombreFUncncionario.Text;
            fun.codigoUsuario = txtCodigo.Text;
            fun.Contrasenia = txtContrasenia.Text;
            fun.estado = comboBoxEstado.Text;

            xml.funcionarioxml.Add(fun);


            funcionario.RegistroFuncionario(xml);


        }




        // funcionario.nombre = txtNombreFuncionario.Text;
        // string apellido = txtApellidoFuncionario.Text;
        //string identificacion = txtIdendificacionFuncionario.Text;
        //string sexo = comboBoxSexoFuncioario.Text;

        //xml.padreXml.Add(padre);


        //Registro.RegistroPadre(xml);




        //string nombre = txtNombreFuncionario.Text;
        //string apellido = txtApellidoFuncionario.Text;
        //string identificacion = txtIdendificacionFuncionario.Text;
        //string sexo = comboBoxSexoFuncioario.Text;

        //// Realizar validaciones



        //// Llamar a métodos de la capa de negocio para guardar el funcionario, por ejemplo:
        //// Negocio.GuardarFuncionario(nuevoFuncionario);

        //// Limpiar los campos del formulario
        //txtNombreFuncionario.Clear();
        //txtApellidoFuncionario.Clear();
        //txtIdendificacionFuncionario.Clear();


        //MessageBox.Show("Funcionario guardado exitosamente.");

        //// Primer formulario
        //string nombreCompleto1 = txtNombreFUncncionario.Text;
        //string codigoUsuario1 = txtCodigo.Text;
        //string estado1 = comboBoxEstado.Text;
        //string contraseña1 = txtContrasenia.Text;

        //// Validar los campos del primer formulario
        //if (string.IsNullOrWhiteSpace(nombreCompleto1) || string.IsNullOrWhiteSpace(codigoUsuario1) || string.IsNullOrWhiteSpace(estado1) || string.IsNullOrWhiteSpace(contraseña1))
        //{
        //    MessageBox.Show("Por favor, complete todos los campos del primer formulario.");
        //    return;
        //}

        //// Crear una instancia de Funcionario para el primer formulario
        //RFuncionario rFuncionario1 = new RFuncionario
        //{
        //    NombreFuncionario = nombreCompleto1,
        //    IdentificacionFuncionario = codigoUsuario1,
        //    SexoFuncionario = estado1,
        //    Contrasenia = contraseña1
        //};

        // Limpiar los campos del primer formulario
        // txtNombreFUncncionario.Clear();
        //txtCodigo.Clear();
        //comboBoxEstado.SelectedIndex = -1;
        // txtContrasenia.Clear();



        //  }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
