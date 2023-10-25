using System.Xml.Serialization;
using System.Xml;
using System.Globalization;
using System.Windows;
using Datos;


namespace Negocios
{
    public class DatosPadre
    {
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


        //public bool RegistroPadre(List<Padre> listaPadre)
        //{
        //txtNombrePadre.Text, txtIdendificacion.Text, txtDireccion.Text, txtCorreoElectronico.Text, txtTelefono.Text)
        public string RegistroPadre(PadreXML padreXML)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Puedes construir rutas relativas a esta ubicación
            string subfolder = "XMLFiles";
            string filename = "PADRE.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);


            //StreamWriter MyFile = new StreamWriter(xmlFilePath);
            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.ReadWrite))
                using (StreamWriter MyFile = new StreamWriter(fileStream))
                {
                    XmlSerializer Serializer = new XmlSerializer(typeof(PadreXML));
                    Serializer.Serialize(MyFile, padre);
                }
            }
            else
            {
                // Crear un objeto XmlSerializer para la clase Persona
                XmlSerializer serializer = new XmlSerializer(typeof(PadreXML));
                // Crear un flujo de escritura de archivo para guardar el XML
                using (TextWriter writer = new StreamWriter(xmlFilePath))
                {
                    // Serializar la entidad Persona en XML y escribirlo en el archivo
                    serializer.Serialize(writer, padre);
                }
            }


            return "";
        }


        //Aqui se ve si ya la identificacion ya ha sido registrada
        /*            if (identificacionExistente(identificacionPadre))
                    {

                        return "identificacion existente";
                    }
                    else
                    {
                        Padre nuevo = new Padre();

                        nuevo.Nombre = nombre;
                        nuevo.Identicacion = identificacionPadre;
                        nuevo.Direccion = direccion;
                        nuevo.Correo = correoPadre;
                        nuevo.Telefono = tel;

                        istaPadre.Add(nuevo);


                    }


                    return "";

                }

                private bool identificacionExistente(string identificacion)
                {
                    //Validacion de identificaiones existentes
                    foreach (Padre padre in istaPadre)
                    {
                        if (padre.Identicacion == identificacion)
                        {
                            return true;

                        }


                    }
                    return false;




                }
            }
        */
    }
}
