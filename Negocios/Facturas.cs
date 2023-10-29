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
        string costoTotal = " ";
        string NumeroFactura = " ";
        DateTime fechaFactura;




        public string RegistroFactura(XmlFactura Facturaxml)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // A esta ruta se pasan los XML
            string subfolder = "XMLFiles";
            string filename = "Factura.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);


          
            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.ReadWrite))
                using (StreamWriter MyFile = new StreamWriter(fileStream))
                {
                    XmlSerializer Serializer = new XmlSerializer(typeof(XmlFactura));
                    Serializer.Serialize(MyFile, Facturaxml);
                }
            }
            else
            {
                // Aqui cree un objeto XmlSerializer para la clase Persona
                XmlSerializer serializer = new XmlSerializer(typeof(XmlFactura));
                //  Aqui cree de escritura del archivo para guardar el XML
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
