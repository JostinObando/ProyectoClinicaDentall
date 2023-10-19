using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ListaServicios
    {
        private Dictionary<string, double> serviciosDisponible = new Dictionary<string, double>();
        private List<   ListaServicio> serviciosSeleccionadso = new List<ListaServicio>();

        public ListaServicios() 
        {


            serviciosDisponible.Add("Limpieza Dental", 50000.0);
            serviciosDisponible.Add("Extraccion de muelas", 40000.0);
            serviciosDisponible.Add("Extraccion de dientes", 35000.0);
            serviciosDisponible.Add("Cirugia de cordales", 110000.0);
            serviciosDisponible.Add("Ortodoncia", 650000.0);
        }
        public List<string> GetListas()
        {
            return new List<string>(serviciosDisponible.Keys);

        }
        public void AgregarServicio(string nombre) 
        {
            if (serviciosDisponible.ContainsKey(nombre))

            {
                double costo = serviciosDisponible[nombre];
                serviciosSeleccionadso.Add(new ListaServicio(nombre,costo));


            }
            else 
            {
                throw new ArgumentException("El servicio selecionado no existe");
            
            
            }
        
        
        }
        public double CalcualarCostoTotal() 
        {
        double costoTotal = 0;
            foreach (ListaServicio listaServicios in serviciosSeleccionadso) 
            {
                costoTotal += listaServicios.Costo;
            
            }
            return costoTotal;
        
        
        
        }



    }
}
