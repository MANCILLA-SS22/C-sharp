using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kardex
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
            lblMsg1.Text = textBox1.Text; 
            lblMsg2.Text = cboState1.Text;  
            lblMsg3.Text = cboState2.Text;  
            lblMsg4.Text = textBox2.Text;  
            lblMsg5.Text = cboState3.Text;

            if (checkedListBox2.Items.Count>0)
            {
                listBox1.Items.Clear();
                foreach (string s in checkedListBox2.CheckedItems) 
                {
                     listBox1.Items.Add(s).ToString();
                }
            }
           
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboState1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboState2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboState3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
