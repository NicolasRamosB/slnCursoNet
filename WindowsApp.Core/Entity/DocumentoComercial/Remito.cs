using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Core.Entity.Personas.Recibos;

namespace WindowsApp.Core.Entity
{
    public class Remito : DocumentoComercialBase
    {
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, DateTime fechaEntrega, decimal total) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }


        public DateTime FechaEntrega { get; set; }
    }
}
