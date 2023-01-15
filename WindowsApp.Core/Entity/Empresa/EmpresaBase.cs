using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Core.Entity.Empresa
{
    public abstract class EmpresaBase
    {
        protected EmpresaBase(string nombre, string cUIT, string contacto, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cUIT;
            Contacto = contacto;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }

    public class Proveedor : EmpresaBase
    {
        public Proveedor(string nombre, string cUIT, string contacto, string email, string telefono, string direccion) : base(nombre, cUIT, contacto, email, telefono, direccion)
        {
        }
    }

    public class ClienteEmpresa : EmpresaBase
    {
        public ClienteEmpresa(string nombre, string cUIT, string contacto, string email, string telefono, string direccion) : base(nombre, cUIT, contacto, email, telefono, direccion)
        {
        }
    }
}
