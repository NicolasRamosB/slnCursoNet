using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entity
{
    public class Producto
    {
        

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto {
            get
            {
                //                     Asigancion 
                decimal _PrecioBruto = this.PrecioCosto + (this.PrecioCosto * (decimal)this.Margen);
                return _PrecioBruto;
            }
        }
        public decimal PrecioVenta { 
            get 
            {
                decimal _PrecioVenta = this.PrecioBruto + (this.PrecioBruto * ( 1 + (decimal)this.IVA)); // 21% IVA
                return _PrecioVenta;
            } 
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
       
        

    }
}
