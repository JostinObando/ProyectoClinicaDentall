using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocios
{
    public class ServicioNinios
    {
        private List<ServicioNinio> servicioNinios = new List<ServicioNinio>();

        public ServicioNinios(int idNinio, string descripcion, DateTime fecha, double costo) 
        {
            int nuevoId = ObtenerUltimoID();
            var nuevoServicio = new ServicioNinio()
            {
                Id = idNinio,
                NiñoId = nuevoId,   
                Fecha = fecha,
                Costo = costo

            };
            servicioNinios.Add(nuevoServicio);
        
        
        
        }
        public int GenerarNuevoID()
        {
            // Aquí debes implementar tu lógica para generar un nuevo ID único.
            // Esto podría incluir la consulta a una base de datos para obtener el último ID y luego incrementarlo en uno, o cualquier otra lógica que prefieras.
            // Por ahora, simplemente devolveré un valor fijo como ejemplo.

            int ultimoID = ObtenerUltimoID(); // Debes implementar ObtenerUltimoID para obtener el último ID de tu fuente de datos.

            // Incrementar el último ID en uno para obtener un nuevo ID único.
            int nuevoID = ultimoID + 1;

            return nuevoID;
        }
        public int ObtenerUltimoID()
        {
            // Aquí implementarías la lógica para obtener el último ID de tu fuente de datos.
            // Por ahora, simplemente devolveré un valor fijo como ejemplo.

            return 100; // Valor fijo como ejemplo.
        }
        private int ObtnerNuevo() 
        {

            return 100;
        
        }

    }
}
