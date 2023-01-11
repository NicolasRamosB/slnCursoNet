using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entity;

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
            Producto producto= new Producto();

            producto.Nombre = "Ojota";
            producto.Descripcion = "Ojota sin suela perfecta para la playa";
            producto.PrecioCosto = 12000.30m;
            producto.Margen = 0.30 ;
            producto.IVA = 0.21 ;
            producto.Proveedor = "Ojo x Ojota";
            producto.Categoria = "Calzado";
            producto.SubCategoria = "Ojotas";

            MessageBox.Show($"Nombre: {producto.Nombre}" +
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

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo= new ClienteIndividuo();

            clienteIndividuo.Nombre = "Nicolas";
            clienteIndividuo.Apellido = "Ramos";
            clienteIndividuo.CUIT = "1234567879";
            clienteIndividuo.Email = "email@gmail.com";
            clienteIndividuo.Telefono = "20292209";
            clienteIndividuo.Direccion = "Av.SiempreViva 123";

            MessageBox.Show(
                $"Nombre Completo: {clienteIndividuo.Nombre} {clienteIndividuo.Apellido}" +
                $"\nCUIT: {clienteIndividuo.CUIT}" +
                $"\nEmail: {clienteIndividuo.Email}" +
                $"\nTelefono: {clienteIndividuo.Telefono}" +
                $"\nDireccion: {clienteIndividuo.Direccion}" );



        }
    }
}
