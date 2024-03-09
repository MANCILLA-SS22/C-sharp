using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holayadios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_LOad(object sender, EventArgs e)
        {
            //1. Crea un botón que al darle clic muestre un mensaje personalizado utilizando una etiqueta.
            MessageBox.Show("Hola Y Adios xd");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hola Y Adios xd";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Y Adios xd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juego: NO PRESIONES EL BOTON");
            label1.Text = "Has perdido";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
          
}
