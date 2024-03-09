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

        // funcion que nos permite desplegar en consola un hola mundo 
        private void Form1_Load(object sender, EventArgs e)
        {
            //Usamos el metodo form1 que egecuta el formulario automaticamente
            //el elemento MessageBox.show muestra un mensaje en un formulario nuevo
            MessageBox.Show("Hola Mundo :v");
        }

         //funcion que nos permite desplegar en una ventanilla un hola mundo
        private void label1_Click(object sender, EventArgs e)
        {
            //usamos el metodo label1_click que muestra el mensaje una vez que damos click en la etiqueta
            //el elemento label1.text muestra un mensaje en el formulario formal
            label1.Text = "Hola mundo :v";
        }

        //funcion que nos permite desplegar con botones un hola mundo
        private void button1_Click(object sender, EventArgs e)
        {
            //Usamos el metodo button1_click que muestra el mensaje una vez que damos click en el boton creado
            // los elementos Message.Box.Show y label1.text muestran un mensaje en el formulario Form1 
            MessageBox.Show("Hola mundo activado por boton");
            label1.Text = "Hola mundo activado por boton";
        }
    }
}
