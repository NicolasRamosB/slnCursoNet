using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Core.Entity;
using WindowsApp.Core.Entity.Empresa;

namespace Negocio
{
    public static class AdmClientes
    {

        //----------Listar Cliente Individuo----------------------

        public static List<ClienteIndividuo> clienteIndividuos = new List<ClienteIndividuo>();
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            return clienteIndividuos;
        }
        public static ClienteIndividuo ListarClienteIndividuo(string cUIT)
        {
            ClienteIndividuo clienteIn = new ClienteIndividuo("Nico","Ramos","Email","telefono","direccion", "cuit");
            return clienteIn;
        }


        //----------Listar Cliente Empresa----------------------
        public static List<Empresa> clienteEmpresa= new List<Empresa>();

        public static List<Empresa> ListarClienteEmpresa()
        {
            return clienteEmpresa;
        }

        public static Empresa ListarClienteEmpresa(string cUIT)
        {
            Empresa clienteEmp = new Empresa("Nico", "Cuit", "contacto", "email", "telefono", "direccion");
           
            return clienteEmp;
        }

    }
}
