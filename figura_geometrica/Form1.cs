using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figura_geometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result1 = 0.0; //area del cuadrado
            double result2 = 0.0; //area del triangulo equilatero
            double result3 = 0.0; //area del trapecio
            double result4 = 0.0; //area del pentagono regular

            double a = 0.0; // lado de cuadrado

            double b = 0.0; // lado de triangulo
            double c = 0.0; // altura de triangulo

            double d = 0.0; // lado inferior de trapecio
            double f = 0.0; // lado superior de trapecio
            double g = 0.0; // altura de trapecio

            double h = 0.0; // lado de pentagono regular 
            double j = 0.0; // altura de pentagono regular 

            a = Convert.ToDouble(textBox1.Text);

            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox4.Text);

            d = Convert.ToDouble(textBox3.Text);
            f = Convert.ToDouble(textBox5.Text);
            g = Convert.ToDouble(textBox8.Text);

            h = Convert.ToDouble(textBox6.Text);
            j = Convert.ToDouble(textBox7.Text);

            result1 = Math.Pow(a,2);
            result2 = (b * c)/2;
            result3 = ((d+f) + h)/2;
            result4 = (6 * h * j) / 2;

             textBox9.Text = result1.ToString();
            textBox10.Text = result2.ToString();
            textBox11.Text = result3.ToString();
            textBox12.Text = result4.ToString();
        }
    }
}
