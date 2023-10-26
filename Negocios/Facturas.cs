using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Negocios
{
    public class Facturas
    {
        private List<Factura> F = new List<Factura>();

        //Se registra los datos brindados por el cliente
       
        string NombreNinio = "";
        string ApellidoNinio = "";
        string Identificacion = "";
        string servicio = "";
        
        


        public string RegistroFactura(xmlFactura Facturaxml)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Puedes construir rutas relativas a esta ubicación
            string subfolder = "XMLFiles";
            string filename = "Factura.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);


            //StreamWriter MyFile = new StreamWriter(xmlFilePath);
            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.ReadWrite))
                using (StreamWriter MyFile = new StreamWriter(fileStream))
                {
                    XmlSerializer Serializer = new XmlSerializer(typeof(xmlFactura));
                    Serializer.Serialize(MyFile, Facturaxml);
                }
            }
            else
            {
                // Crear un objeto XmlSerializer para la clase Persona
                XmlSerializer serializer = new XmlSerializer(typeof(xmlFactura));
                // Crear un flujo de escritura de archivo para guardar el XML
                using (TextWriter writer = new StreamWriter(xmlFilePath))
                {
                    // Serializar la entidad Persona en XML y escribirlo en el archivo
                    serializer.Serialize(writer, Facturaxml);
                }
            }


            return "";
        }
    }
}
