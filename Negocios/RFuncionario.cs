using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Negocios
{
    public  class RFuncionario
    {
        public string NombreFuncionario { get; set; }
        public string ApellidoFuncionario { get; set; }
        public string IdentificacionFuncionario { get; set; }
        public string SexoFuncionario { get; set; }
        
        public string nombreCompleto { get; set; }
        public string codigoUsuario { get; set; }
        public string estado { get; set; }
        public string Contrasenia { get; set; }
        

       





    }

    public class xmlFuncionario
    {
        public List<RFuncionario> funcionarioxml;
        public xmlFuncionario()
        {
            funcionarioxml = new List<RFuncionario>();
        }
    }


}
