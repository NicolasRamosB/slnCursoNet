using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Core.Entity.Personas.Recibos;

namespace WindowsApp.Core.Entity
{
    public class Factura :DocumentoComercialBase
    {
        public Factura(string tipo, string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total ) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            Tipo = tipo;
        }

        public string Tipo { get; set; }
        

    }
}
