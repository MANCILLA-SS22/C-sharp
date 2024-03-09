using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nota_compra
{
    public partial class Form1 : Form
    {

        class producto
        {
            public string nombre;
            public string iva;
            public double imp;
            public double precio;
            
        }

        List<producto> LISTA_PRODUCTOS;
        List<producto> LISTA_COMPRAS;

        //==================================================

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTA_PRODUCTOS = new List<producto>()
            {
                
                new producto() { nombre = "Naranja", precio = 10, iva = "    +   Iva = $", imp = 10*1.08},
                new producto() { nombre = "Carne", precio = 20, iva = "    +   Iva = $", imp = 20*1.08},
                new producto() { nombre = "Cereal", precio = 35, iva = "    +   Iva = $", imp = 35*1.08},
                new producto() { nombre = "Leche", precio = 25, iva = "    +   Iva = $", imp = 25*1.08},
                new producto() { nombre = "Agua", precio = 20, iva = "    +   Iva = $", imp = 20*1.08},
                new producto() { nombre = "Pescado", precio = 40, iva = "    +   Iva = $", imp = 40*1.08},
                new producto() { nombre = "Papitas", precio = 15, iva = "    +   Iva = $", imp = 15*1.08},
                new producto() { nombre = "Galletas", precio = 12, iva = "    +   Iva = $", imp = 12*1.08},
                new producto() { nombre = "Jugo", precio = 8, iva = "    +   Iva = $", imp = 8*1.08},
                new producto() { nombre = "Soda de 2L", precio = 18, iva = "    +   Iva = $", imp = 18*1.08},
                new producto() { nombre = "Soda de 1L", precio = 20, iva = "    +   Iva = $", imp = 20*1.08},
                new producto() { nombre = "Camarones", precio = 250, iva = "    +   Iva = $", imp = 250*1.08},
                new producto() { nombre = "Pollo", precio = 175, iva = "    +   Iva = $", imp = 175*1.08},
                new producto() { nombre = "Aceite", precio = 40, iva = "    +   Iva = $", imp = 40*1.08},
                new producto() { nombre = "Sal", precio = 10, iva = "    +   Iva = $", imp = 10*1.08},
                new producto() { nombre = "Manzana", precio = 8, iva = "    +   Iva = $", imp = 8*1.08},
                new producto() { nombre = "Sandia", precio = 20, iva = "    +   Iva = $", imp = 20*1.08},
                new producto() { nombre = "Platano", precio = 8, iva = "    +   Iva = $", imp = 8*1.08},
            };
            
            foreach (producto p in LISTA_PRODUCTOS)
            {
                list_Producto.Items.Add(ConstruirLineaProducto(p));
            }
      
            IniciarCompras();
        }

        private string ConstruirLineaProducto(producto p)
        {            
            string precio = p.precio.ToString("$0.00");            
            return p.nombre + new string(' ', 20 - p.nombre.Length - precio.Length) + precio + p.iva + p.imp;
           
        }

        private void IniciarCompras()
        {
            LISTA_COMPRAS = new List<producto>();
            listCompra.Items.Clear();
            lblTotal.Text = "$0,00";
        }

        private void list_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_Producto_DoubleClick(object sender, EventArgs e)
        {
            if (list_Producto.SelectedIndex == 1) return;
            producto p = LISTA_PRODUCTOS[list_Producto.SelectedIndex];
            AdicionarProductoCompra(p);
        }

        private void AdicionarProductoCompra(producto p)
        {
            LISTA_COMPRAS.Add(p);
            listCompra.Items.Add(ConstruirLineaProducto(p));

            double sub = LISTA_COMPRAS.Sum(i => i.precio);
            lblSubtotal.Text = sub.ToString("$0.00");

            double total = sub * 1.08;
            lblTotal.Text = total.ToString("$0.00");
            
            
        }

        private void btnClean_Click(object sender3, EventArgs e)
        {
            MessageBox.Show("Cuenta finalizada" + Environment.NewLine + lblTotal.Text);
            IniciarCompras();
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
