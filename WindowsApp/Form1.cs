using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Core.Entity;
using WindowsApp.Core.Entity.Empresa;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Nombre = "Ojota";
            producto.Descripcion = "Ojota sin suela perfecta para la playa";
            producto.PrecioCosto = 12000.30m;
            producto.Margen = 0.30;
            producto.IVA = 0.21;
            producto.Proveedor = "Ojo x Ojota";
            producto.Categoria = "Calzado";
            producto.SubCategoria = "Ojotas";

            MessageBox.Show(
                            $"----------PRODUCTO--------"+

                            $"\nNombre: {producto.Nombre}" +
                            $"\nDescriopcion: {producto.Descripcion}" +
                            $"\nPrecio: ${(producto.PrecioCosto).ToString()}" +
                            $"\nMargen de Ganacia: {(producto.Margen * 100).ToString()}%" +
                            $"\nIVA: {(producto.IVA * 100).ToString()}%" +
                            $"\nPrecio bruto: ${(producto.PrecioBruto).ToString()}" +
                            $"\nPrecio venta: ${Math.Round(producto.PrecioVenta).ToString()}" +
                            $"\nProveedor: {producto.Proveedor}" +
                            $"\nCategoria: {producto.Categoria}" +
                            $"\nSub Categoria: {producto.SubCategoria}");
   
        }



        private void btnEmpresa_Click(object sender, EventArgs e)
        {

            Empresa empresa = new Empresa(
             "Nicolas",
             "1234567879",
             "110100102203",
             "email@gmail.com",
             "42433356",
             "Av.SiempreViva 123"
             );

            MessageBox.Show(
                $"----------EMPRESA--------"+
                $"\nNombre Completo: {empresa.Nombre}" +
                $"\nCUIT: {empresa.CUIT}" +
                $"\nContacto: {empresa.Contacto}" +
                $"\nEmail: {empresa.Email}" +
                $"\nTelefono: {empresa.Telefono}" +
                $"\nDireccion: {empresa.Direccion}");

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor(
             "Nicolas",
             "Ramos",
             "email@gmail.com",
             "20292209",
             "Av.SiempreViva 123",
             "3203303003"
             );

            MessageBox.Show(
                "----------VENDEDOR--------" +

                $"\nNombre: {vendedor.Nombre}" +
                $"\nApellido {vendedor.Apellido}" +
                $"\nEmail: {vendedor.Email}" +
                $"\nTelefono: {vendedor.Telefono}" +
                $"\nDireccion: {vendedor.Direccion}" +
                $"\nDNI: {vendedor.DNI}"
                );

            ClienteIndividuo clienteIndividuo = new ClienteIndividuo(
             "Nicolas",
             "1234567879",
             "email@gmail.com",
             "20292209",
             "Av.SiempreViva 123",
             "3203303003"
             );

            MessageBox.Show($"----------CLIENTE INDIVIDUO--------"+
                $"\nNombre: {clienteIndividuo.Nombre}" +
                $"\nApellido: {clienteIndividuo.Apellido}" +
                $"\nEmail: {clienteIndividuo.Email}" +
                $"\nTelefono: {clienteIndividuo.Telefono}" +
                $"\nDireccion: {clienteIndividuo.Direccion}"+
                $"\nCUIT: {clienteIndividuo.CUIT}" 
                );
        }


        private void btnDC_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(
             "A",
             "1234567879",
             new DateTime(2023, 03, 11),
             "Royal",
             "Av.SiempreViva 123",
             "Responsable escrito",
             "Efectivo",
             "Es un perrito",
             (decimal)110.32
             ) ;

            MessageBox.Show(
                $"----------FACTURA--------"+
                $"\nTipo: {factura.Tipo}" +
                $"\nNumero: {factura.Numero}" +
                $"\nFecha: {factura.Fecha}" +
                $"\nCliente: {factura.Cliente}" +
                $"\nDireccion: {factura.Direccion}" +
                $"\nCondicion IVA: {factura.CondicionIVA}" +
                $"\nCondicion Venta: {factura.CondicionVenta}" +
                $"\nDetalle: {factura.Detalle}" +
                $"\nTotal: {factura.Total}");


            Remito remito = new Remito(
             "1234567879",
             new DateTime(2023, 03, 11),
             "Royal",
             "Av.SiempreViva 123",
             "Responsable escrito",
             "Efectivo",
             "Es un perrito",
             new DateTime(2023, 06, 20),
             (decimal)110.32
             );

            MessageBox.Show(
                $"----------REMITO--------"+
                $"\nNumero: {remito.Numero}" +
                $"\nFecha: {remito.Fecha}" +
                $"\nCliente: {remito.Cliente}" +
                $"\nDireccion: {remito.Direccion}" +
                $"\nCondicion IVA: {remito.CondicionIVA}" +
                $"\nCondicion Venta: {remito.CondicionVenta}" +
                $"\nFecha de entrega: {remito.FechaEntrega}" +
                $"\nDetalle: {remito.Detalle}" +
                $"\nTotal: {remito.Total}");
        }
    }
}
