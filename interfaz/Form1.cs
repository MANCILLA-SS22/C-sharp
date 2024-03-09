using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSealType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
                txtCarID.Text = Row.Cells["Car-ID"].Value.ToString();
                cbModel.Text = Row.Cells["Model"].Value.ToString();
                cbType.Text = Row.Cells["Type"].Value.ToString();
                dtIntime.Text = Row.Cells["Intime"].Value.ToString();
                dtOuttime.Text = Row.Cells["Outtime"].Value.ToString();
                cbSealType.Text = Row.Cells["Seal Type"].Value.ToString();
                txtDuration.Text = Row.Cells["Duration"].Value.ToString();
                txtPayment.Text = Row.Cells["Payment"].Value.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime intime = DateTime.Parse(dtIntime.Text);
            DateTime outtime = DateTime.Parse(dtOuttime.Text);
            float duration = float.Parse((outtime - intime).TotalMinutes.ToString());
            var span = System.TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var Minute = span.Minutes.ToString();
            txtDuration.Text = hour + ":" + "" + Minute;

            if ((duration / 60) > 0.5) 
            {
                if (cbSealType.SelectedItem == "seal into any local")
                    txtPayment.Text = "" + "$" + ((duration / 60)*10)*0.5;
                else
                    txtPayment.Text = "" + "$" + (duration / 60) * 10;
            }

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtCarID.Text;
            dataGridView1.Rows[n].Cells[1].Value = cbModel.Text;
            dataGridView1.Rows[n].Cells[2].Value = cbType.Text;
            dataGridView1.Rows[n].Cells[3].Value = dtIntime.Text;
            dataGridView1.Rows[n].Cells[4].Value = dtOuttime.Text;
            dataGridView1.Rows[n].Cells[5].Value = cbSealType.Text;
            dataGridView1.Rows[n].Cells[6].Value = txtDuration.Text;
            dataGridView1.Rows[n].Cells[7].Value = txtPayment.Text;
        }

        private void dtOuttime_Leave(object sender, EventArgs e)
        {

        }

        private void dtIntime_ValueChanged(object sender, EventArgs e)
        {
             
        }
    }
}
