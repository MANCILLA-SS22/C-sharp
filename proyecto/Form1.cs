using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void ivWindow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        double price = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblPrecio.Text = (0).ToString("C");
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;           
            this.lblFechaHora.Text = datetime.ToString();
        }

        private void cboComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string product = cboComponents.Text;
            if (product.Equals("Antenna")) price = 250;
            if (product.Equals("Transistor")) price = 300;
            if (product.Equals("Capacitor")) price = 400;
            if (product.Equals("Coil")) price = 500;

            lblPrecio.Text = price.ToString("C");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboComponents.SelectedIndex == -1)
                MessageBox.Show("You must choose a product...!!!");
            else if (txtAmount.Text == "")
                MessageBox.Show("You must enter an amount...!!!");
            else if (cboType.SelectedIndex == -1)
                MessageBox.Show("You must choose a type...!!!");

            else
            {
                string product = cboComponents.Text;
                int amount = Convert.ToInt32(txtAmount.Text);
                string type = cboType.Text;

                double tax = 1.08;
                double subtotal = amount * price;
                double discount = 0;
                double total_price = 0;

                string gift = cboGift.Text;

                if (gift.Equals("0% Gift card"))
                {
                    total_price = subtotal * tax;
                }


                if (gift.Equals("10% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.01 * total_price;
                    total_price = total_price + discount;
                }

                if (gift.Equals("20% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.02 * total_price;
                    total_price = total_price + discount;
                }

                if (gift.Equals("30% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.03 * total_price;
                    total_price = total_price + discount;
                }

                if (gift.Equals("40% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.04 * total_price;
                    total_price = total_price + discount;
                }

                if (gift.Equals("50% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.05 * total_price;
                    total_price = total_price + discount;
                }

                if (gift.Equals("60% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.06 * total_price;
                    total_price = total_price + discount;
                }

                if (gift.Equals("70% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.07 * total_price;
                    total_price = total_price + discount;
                }

                if (gift.Equals("80% Gift card"))
                {
                    total_price = subtotal * tax;
                    discount = 0.08 * total_price;
                    total_price = total_price + discount;
                }


                ListViewItem file = new ListViewItem(product);
                file.SubItems.Add(amount.ToString());
                file.SubItems.Add(price.ToString());
                file.SubItems.Add(type.ToString());
                file.SubItems.Add(subtotal.ToString());
                file.SubItems.Add(discount.ToString());
                file.SubItems.Add(total_price.ToString());

                ivWindow.Items.Add(file);
                btnSalir_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboComponents.Text = "(Components seleccion)";
            txtAmount.Clear();
            lblPrecio.Text = (0).ToString("C");
            cboComponents.Focus();
        }

        
    }
}
