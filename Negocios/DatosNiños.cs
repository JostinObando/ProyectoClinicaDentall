using System.Xml.Serialization;
using System.Xml;
using System.Reflection.Metadata;

namespace Negocios
{
    public class DatosNiños

    {
        string nombre = "";
        string apellido = "";
        string identificacion = "";
        DateTime fechaNacimiento;
        string identificacionPadre = "";
        string sexo = "";
        private List<Ninno> listaNiño = new List<Ninno>();
        Ninno ninno;

        /// <summary>
        /// Metodo registro Ninno
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="identificacion"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="sexo"></param>
        /// <param name="identificacionPadre"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public string RegistroNinio(NinnoXML ninno)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Puedes construir rutas relativas a esta ubicación
            string subfolder = "XMLFiles";
            string filename = "ninnno.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);


            //StreamWriter MyFile = new StreamWriter(xmlFilePath);
            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.ReadWrite))
                using (StreamWriter MyFile = new StreamWriter(fileStream))
                {
                    XmlSerializer Serializer = new XmlSerializer(typeof(NinnoXML));
                    Serializer.Serialize(MyFile, ninno);
                }
            }
            else
            {
                // Crear un objeto XmlSerializer para la clase Persona
                XmlSerializer serializer = new XmlSerializer(typeof(NinnoXML));
                // Crear un flujo de escritura de archivo para guardar el XML
                using (TextWriter writer = new StreamWriter(xmlFilePath))
                {
                    // Serializar la entidad Persona en XML y escribirlo en el archivo
                    serializer.Serialize(writer, ninno);
                }
            }


            return "";
        }



        private bool IdentificacionExistente(string identificacion)
        {
            foreach (Ninno niño in listaNiño)
            {
                if
                    (niño.Identificacion == identificacion)
                {
                    return true;

                }

            }
            return false;


        }
    }
}
