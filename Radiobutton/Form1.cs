using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiobutton
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
            string sMateria = "";
            if (radioButton1.Checked)
            {
                sMateria = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                sMateria = radioButton2.Text;
            }

            if (radioButton3.Checked)
            {
                sMateria = radioButton3.Text;
            }

            if (radioButton4.Checked)
            {
                sMateria = radioButton4.Text;
            }

            MessageBox.Show(sMateria);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetMateria(radioButton5);
            GetMateria(radioButton6);
            GetMateria(radioButton7);
            GetMateria(radioButton8);
        }

        private void GetMateria(RadioButton rdoButton)
        {
            if (rdoButton.Checked) 
            {
                MessageBox.Show(rdoButton.Text);
            }
        }

    

    } 
}
