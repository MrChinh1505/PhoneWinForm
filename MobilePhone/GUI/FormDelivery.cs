using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhone.GUI
{
    public partial class FormDelivery : Form
    {
        private DeliveryService d = new DeliveryService();
        DataTable rowData;
        public FormDelivery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(search.Text != "")
            {
                dataGridView1.DataSource = d.find(search.Text);
                rowData = d.find(search.Text);
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            if(search.Text != "" &&  ps.Text != "" && ds.Text != "" && dataGridView1.Rows.Count > 0)
                d.update(search.Text, "" ,ps.Text, ds.Text);
            return;
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DataSource = d.find();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            search.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dataGridView1.DataSource = d.find(search.Text);
        }
    }
}
