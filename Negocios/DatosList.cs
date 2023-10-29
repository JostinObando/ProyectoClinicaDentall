using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    [Serializable]
    public class DatosList
    {
        //Get y set
        public List<Ninno> ListaNiño { get; set; }
        public List<Padre> ListaPadre { get; set; }
    }
}
