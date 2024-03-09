using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Scientific_Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void stantardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 335;
            txtDisplay.Width = 294;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 632;
            txtDisplay.Width = 596;
        }

        Double results = 0;
        String operation = "";
        bool enter_value = true;

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "") || (enter_value)) 
            txtDisplay.Text = "";
            enter_value = false;   // esto nos permite que al momento de introducir un segundo numero, el primero no se elimine, es decir, inavilita el valor de entrada
            Button num = (Button)sender; //el objeto sender permite asignar a varios controles un mismo evento, en este caso, los botones de numeros
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("0"))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                    txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        //Delete
        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            lblShowOp.Text = "";
        }

        //clear all
        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            lblShowOp.Text = "";
        }

        //clear
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text =="")
            {
                txtDisplay.Text = "";
            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + " " + operation;

        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = results;
                    txtDisplay.Text = Math.Exp(i * Math.Exp(q * 0)).ToString();
                    break;

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.14159265358979323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double qSinh = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Sin" + "(" + (txtDisplay.Text) + ")");
            qSin = Math.Sin(qSin);
            txtDisplay.Text = System.Convert.ToString(qSin);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double qCosh = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Cosh" + "(" + (txtDisplay.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txtDisplay.Text = System.Convert.ToString(qCosh);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double qCos = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Cos" + "(" + (txtDisplay.Text) + ")");
            qCos = Math.Cos(qCos);
            txtDisplay.Text = System.Convert.ToString(qCos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double qTanh = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Tanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtDisplay.Text = System.Convert.ToString(qTanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double qTan = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Tan" + "(" + (txtDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txtDisplay.Text = System.Convert.ToString(qTan);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);                      
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        // 1/x
        private void button23_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        // x^2
        private void button25_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);

        }

        // x^3
        private void button24_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text); ;
            txtDisplay.Text = System.Convert.ToString(a);
        }

        // %
        private void button21_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }
    }
}
