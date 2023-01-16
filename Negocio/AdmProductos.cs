using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Core.Entity;

namespace Negocio
{
    public static class AdmProductos
    {
        public static List<Producto> productos = new List<Producto>();

        public static List<Producto> Listar()
        {
            return productos;
        }

        public static List<Producto> Listar(string categoria)
        {
            return productos;
        }

        public static List<Producto> Listar(string categoria, string subCategoria)
        {
            return productos;
        }

        public static List<Producto> ListarDetalle(string nombre)
        {
            return productos;
        }
    }
}
