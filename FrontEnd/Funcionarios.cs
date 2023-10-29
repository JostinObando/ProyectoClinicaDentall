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
            try
            {
                

                //Validacion de campos para el usuario
                if (string.IsNullOrWhiteSpace(txtNombreFuncionario.Text) || string.IsNullOrWhiteSpace(txtApellidoFuncionario.Text) || string.IsNullOrWhiteSpace(txtIdendificacionFuncionario.Text))
                    MessageBox.Show("Por favor, complete todos los campos.");

                //  Inicio xml funcionario
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

                dataGridView1.DataSource = xml;

                //Se pasa la informacion 
                fun.NombreFuncionario = txtNombreFuncionario.Text;
                fun.ApellidoFuncionario = txtApellidoFuncionario.Text;
                fun.IdentificacionFuncionario = txtIdendificacionFuncionario.Text;
                fun.SexoFuncionario = comboBoxSexoFuncioario.Text;
                fun.nombreCompleto = txtNombreFUncncionario.Text;
                fun.codigoUsuario = txtCodigo.Text;
                fun.Contrasenia = txtContrasenia.Text;
                fun.estado = comboBoxEstado.Text;

                xml.funcionarioxml.Add(fun);

                //Columnas
                DataTable dtServicios = new DataTable();
                dtServicios.Columns.Add("NombreFuncionario", typeof(string));
                dtServicios.Columns.Add("ApellidoFuncionario", typeof(string));
                dtServicios.Columns.Add("IdentificacionFuncionario", typeof(string));
                dtServicios.Columns.Add("SexoFuncionario", typeof(string));
                dtServicios.Columns.Add("nombreCompleto", typeof(string));
                dtServicios.Columns.Add("codigoUsuario", typeof(string));
                dtServicios.Columns.Add("Contrasenia", typeof(string));
                dtServicios.Columns.Add("estado", typeof(string));

                foreach (var item in xml.funcionarioxml)
                {
                    DataRow fila1 = dtServicios.NewRow();
                    fila1["NombreFuncionario"] = item.nombreCompleto.ToString();
                    fila1["ApellidoFuncionario"] = item.ApellidoFuncionario.ToString();
                    fila1["IdentificacionFuncionario"] = item.IdentificacionFuncionario.ToString();
                    fila1["SexoFuncionario"] = item.SexoFuncionario.ToString();
                    fila1["nombreCompleto"] = item.nombreCompleto.ToString();
                    fila1["codigoUsuario"] = item.ToString();
                    fila1["Contrasenia"] = item.Contrasenia.ToString();
                    fila1["estado"] = item.estado.ToString();
                    dtServicios.Rows.Add(fila1);
                }

                //Inicio foreach
                dataGridView1.DataSource = dtServicios;


                funcionario.RegistroFuncionario(xml);



            }
            catch (Exception ex)
            {
                throw ex;
            }//fin del try



        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }//fin del main
}//fin de la clase
