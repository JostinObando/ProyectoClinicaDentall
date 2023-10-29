using System.Xml.Serialization;

namespace Negocios
{

    public class Funcionario
    {

        //Listas 
        private List<RFuncionario> funcionariosss = new List<RFuncionario>();
        //Primer formulario
        string nombre = "";
        string apellido = "";
        string identificacion = "";
        string sexo = "";
        // Segundo formulario
        string nombreCompleto1 = "";
        string codigoUsuario1 = "";
        string estado1 = "";
        string contraseña1 = "";
        public string RegistroFuncionario(xmlFuncionario funcionarioXml)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Aqui se puede pasar las  rutas a la direccion Funcionario
            string subfolder = "XMLFiles";
            string filename = "Funcionario.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);


           
            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.ReadWrite))
                using (StreamWriter MyFile = new StreamWriter(fileStream))
                {
                    XmlSerializer Serializer = new XmlSerializer(typeof(xmlFuncionario));
                    Serializer.Serialize(MyFile, funcionarioXml);
                }
            }
            else
            {
                // Aqui cree un objeto XmlSerializer para la clase Persona
                XmlSerializer serializer = new XmlSerializer(typeof(xmlFuncionario));
                // Crear un flujo de escritura de archivo para guardar el XML
                using (TextWriter writer = new StreamWriter(xmlFilePath))
                {
                    // Serializar la entidad Persona en XML y escribirlo en el archivo
                    serializer.Serialize(writer, funcionarioXml);
                }
            }
            


            return "";
        }




    }
}
