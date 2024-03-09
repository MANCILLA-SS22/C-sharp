using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
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

        private void btnGetItem_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            listBoxItem.Items.Add(s);
        }

        private void btnGetIndex_Click(object sender, EventArgs e)
        {
            listBoxIndex.Items.Clear();
            for (int i=0; i<checkedListBox1.CheckedIndices.Count; i++) 
            listBoxIndex.Items.Add(checkedListBox1.CheckedIndices[i]);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
