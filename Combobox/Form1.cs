using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("programacion visual");
            comboBox1.Items.Add("maquinas electricas");
            comboBox1.Items.Add("fisica de semiconductores");
            comboBox1.Items.Add("diseno digital");
        }
    }
}

