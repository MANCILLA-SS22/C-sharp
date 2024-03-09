using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_LOad(object sender, EventArgs e)
            //1. Crea un botón que al darle clic muestre un mensaje personalizado utilizando una etiqueta.
           MessageBox.Show("Etiqueta de tarea #2");
    }
}
