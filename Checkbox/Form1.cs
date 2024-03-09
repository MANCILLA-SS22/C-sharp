using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String meat = "";

            if (checkBox1.CheckState == CheckState.Checked) 
            {
                meat += "M"; 
            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                meat += "E";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                meat += "A";
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                meat += "T";
            }

            MessageBox.Show(meat);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
