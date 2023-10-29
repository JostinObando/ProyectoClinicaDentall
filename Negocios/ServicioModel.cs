using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    //  ServicioModel get y set
    public class ServicioModel
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }

    public class ServicioModelList
    {
        public List<ServicioModel> listServicioModel;

        public ServicioModelList()
        {
            listServicioModel = new List<ServicioModel>();
        }
    }


}
