using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Negocios
{
    public class PadreXML
    {
        public static List<Padre> CargarDatosDesdeXml(string archivo)
        {
            List<Padre> datos = new List<Padre>();

            if (File.Exists(archivo))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Padre>));
                    using (FileStream fs = new FileStream(archivo, FileMode.Open))
                    {
                        datos = (List<Padre>)xmlSerializer.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar datos desde el archivo XML: " + ex.Message);
                }
            }

            return datos;
        }

        public static void GuardarDatosEnXml(List<Padre> datos, string archivo)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Padre>));
                using (FileStream fs = new FileStream(archivo, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, datos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar datos en el archivo XML: " + ex.Message);
            }
        }
    }
}
