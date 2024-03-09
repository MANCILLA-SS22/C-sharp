using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculator : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculator()
        {
            InitializeComponent();
        }
        Calc.CalcSuma obj = new Calc.CalcSuma();
        Calc.CalcResta obj2 = new Calc.CalcResta();
        Calc.CalcMult obj3 = new Calc.CalcMult();
        Calc.CalcDiv obj4 = new Calc.CalcDiv();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);

            double sum;
            double rest;
            double mult;
            double div;
            switch (operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    textBox1.Text = sum.ToString();
                    break;

                case "-":
                    rest = obj2.Restar((primero), (segundo));
                    textBox1.Text = rest.ToString();
                    break;

                case "*":
                    mult = obj3.Multiplicar((primero), (segundo));
                    textBox1.Text = mult.ToString();
                    break;

                case "/":
                    div = obj4.Dividir((primero), (segundo));
                    textBox1.Text = div.ToString();
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

    }
}
