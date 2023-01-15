using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Core.Personas;

namespace WindowsApp.Core.Entity
{
    public class Vendedor : PersonaBase
    {
        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string dNI) : base(nombre, apellido, email, telefono, direccion)
        {
            DNI = dNI;
        }

        public string DNI { get; set; }
        
    }
}
