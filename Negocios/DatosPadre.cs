using System.Xml.Serialization;
using System.Xml;
using System.Globalization;
using System.Windows;
using Datos;


namespace Negocios
{
    public class DatosPadre
    {
        //Lista
        private List<Padre> listaPadre = new List<Padre>();
        private List<Ninno> listaNiño = new List<Ninno>();

        //Se registra los datos brindados por el cliente
        string nombre = "";
        string identificacionPadre = "";
        string direccion = "";
        string correoPadre = "";
        string tel = "";

        private List<Padre> istaPadre = new List<Padre>();
        Padre padre;


        public string RegistroPadre(xmlPadre padreXML)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Puedes construir rutas relativas a esta ubicación
            string subfolder = "XMLFiles";
            string filename = "Padre.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);


            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.ReadWrite))
                using (StreamWriter MyFile = new StreamWriter(fileStream))
                {
                    XmlSerializer Serializer = new XmlSerializer(typeof(xmlPadre));
                    Serializer.Serialize(MyFile, padreXML);
                }
            }
            else
            {
                // Crear un objeto XmlSerializer para la clase Persona
                XmlSerializer serializer = new XmlSerializer(typeof(xmlPadre));
                //Aqui se hace la escritura de archivo para guardar el XML
                using (TextWriter writer = new StreamWriter(xmlFilePath))
                {
                    // Serializar la entidad Persona en XML y escribirlo en el archivo
                    serializer.Serialize(writer, padreXML);
                }
            }


            return "";
        }


    }
}
