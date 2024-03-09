using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class btnEquals : Form
    {
        double result = 0;
        string operation = "";
        bool enter_value = false;
        String firstnum, secondnum;
        public btnEquals()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(result != 0)
            {
                button23.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOp.Text = System.Convert.ToString(result) + " " + operation;
            }
            else
            {
                operation = b.Text;
                result = double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOp.Text = System.Convert.ToString(result) + " " + operation;
            }

            firstnum = lblShowOp.Text;
            
        }

        

        private void button23_Click(object sender, EventArgs e)
        {
            secondnum = txtDisplay.Text;
            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "X":
                    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
                    break;

                default:
                    break;

            }
            result = double.Parse(txtDisplay.Text);
            operation = "     ";
            //===============================================

            btnClearHistory.Visible = true;
            rtbDisplayHistory.AppendText(firstnum +   "    " + secondnum + " =   " + "\n");
            rtbDisplayHistory.AppendText("\n\t" + txtDisplay.Text + "\n\n");
            lblHistoryDisplay.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }


        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
            if (lblHistoryDisplay.Text =="")
            {
                lblHistoryDisplay.Text = "There's no history yet";
            }
            btnClearHistory.Visible = false;
            rtbDisplayHistory.ScrollBars = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnEquals_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        
    }
}
