using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class DatosServicio
    {
        //Listas
        private Dictionary<string, double> serviciosDisponibles = new Dictionary<string, double>();
        private List<DatosServe> serviciosSeleccionados = new List<DatosServe>();

        public DatosServicio()
        {
            //Servicios de la clinica
            serviciosDisponibles.Add("Limpieza Dental", 50000.0);
            serviciosDisponibles.Add("Extracción de muelas", 40000.0);
            serviciosDisponibles.Add("Extracción de dientes", 35000.0);
            serviciosDisponibles.Add("Cirugía de cordales", 110000.0);
            serviciosDisponibles.Add("Ortodoncia", 650000.0);
        }
        //GetServiciosDisponibles
        public List<string> GetServiciosDisponibles()
        {
            return new List<string>(serviciosDisponibles.Keys);
        }
        //Agregar
        public void AgregarServicio(string nombre)
        {
            if (serviciosDisponibles.ContainsKey(nombre))
            {
                double costo = serviciosDisponibles[nombre];
                serviciosSeleccionados.Add(new DatosServe(nombre, costo));
            }
            else
            {
                //El servicio seleccionado no existe en los servicios disponibles.
                throw new ArgumentException("El servicio seleccionado no existe en los servicios disponibles.");
            }
        }

        public double CalcularCostoTotal()
        {
            double costoTotal = 0;

            foreach (DatosServe servicio in serviciosSeleccionados)
            {
                costoTotal += servicio.Costo;
            }

            return costoTotal;
        }


    }
}

