using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtEnter.Text);
            if(cbConvertFrom.SelectedItem == "Pesos" && cbConverTo.SelectedItem == "Dolar") 
            {
                double conver = i / 20.0793;
                lblConvertedAmount.Text = "Converted Amount :  $" + conver;
            }

            if (cbConvertFrom.SelectedItem == "Pesos" && cbConverTo.SelectedItem == "Euro")
            {
                double conver = i / 24.2144;
                lblConvertedAmount.Text = "Converted Amount :  $" + conver;
            }

            if (cbConvertFrom.SelectedItem == "Euro" && cbConverTo.SelectedItem == "Dollar")
            {
                double conver = i * 1.080499;
                lblConvertedAmount.Text = "Converted Amount :  $" + conver;
            }

            if (cbConvertFrom.SelectedItem == "Euro" && cbConverTo.SelectedItem == "Pesos")
            {
                double conver = i * 24.2144;
                lblConvertedAmount.Text = "Converted Amount :  $" + conver;
            }

            if (cbConvertFrom.SelectedItem == "Dollar" && cbConverTo.SelectedItem == "Pesos")
            {
                double conver = i * 19.75;
                lblConvertedAmount.Text = "Converted Amount :  $" + conver;
            }

            if (cbConvertFrom.SelectedItem == "Dollar" && cbConverTo.SelectedItem == "Euro")
            {
                double conver = i * 0.9254976;
                lblConvertedAmount.Text = "Converted Amount :  $" + conver;
            }
        }
    }
}
