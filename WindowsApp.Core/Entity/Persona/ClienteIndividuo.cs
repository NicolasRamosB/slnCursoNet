using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Core.Personas;

namespace WindowsApp.Core.Entity
{

    public class ClienteIndividuo : PersonaBase
    {
        

        public ClienteIndividuo(string nombre, string apellido, string email, string telefono, string direccion, string cUIT) : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT = cUIT;
        }

        public string CUIT { get; set; }
    }
}
