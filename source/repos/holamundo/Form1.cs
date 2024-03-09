using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holamundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Usamos el metodo form1 que egecuta el formulario automaticamente
            //el elemento MessageBox.show muestra un mensaje en un formulario nuevo
            MessageBox.Show("Hola Mundo :v");
        }
    }
}
