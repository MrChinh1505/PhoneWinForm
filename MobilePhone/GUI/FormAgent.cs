using BLL;
using DTO;
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
    public partial class FormAgent : Form
    {
        private AgentService agent = new AgentService();

        public FormAgent()
        {
            InitializeComponent();
        }

        public void showGRD()
        {
            agentBindingSource.DataSource = agent.getAll();
            //tableAgent.DataSource = agent.getAll();
        }

        public void clearText()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAdd.Text = "";
            txtContact.Text = "";
            txtPass.Text = "";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //showGRD();
            //tableAgent.DataSource = null;
            DataTable dataTable = agent.getAll();
            //agentBindingSource.DataSource = dataTable;
            tableAgent.DataSource = dataTable;
        }

        private void FormAgent_Load(object sender, EventArgs e)
        {
            //showGRD();
            //inforGroup.Enabled = false;
            //btnDelete.Enabled = false; 
            //btnSave.Enabled = false;
            //btnUpdate.Enabled = false;
        }

        private void tableAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtID.Text = tableAgent.CurrentRow.Cells[0].Value.ToString();
            //txtName.Text = tableAgent.CurrentRow.Cells[1].Value.ToString();
            //txtAdd.Text = tableAgent.CurrentRow.Cells[2].Value.ToString();
            //txtContact.Text = tableAgent.CurrentRow.Cells[3].Value.ToString();
            //txtPass.Text = tableAgent.CurrentRow.Cells[4].Value.ToString();

            //inforGroup.Enabled = true;
            //btnDelete.Enabled = true;
            //btnSave.Enabled = true;
            //btnUpdate.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableAgent.DataSource = agent.find(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //btnDelete.Enabled = true;
            //btnSave.Enabled = true;
            //btnUpdate.Enabled = true;
            //inforGroup.Enabled = true;

            //clearText();
            //txtID.Focus();
            Agent a = new Agent(txtID.Text, txtName.Text, txtAdd.Text, txtContact.Text, txtPass.Text);
            //agent.saveChange(a);
            //tableAgent.
            try
            {
                //productService.save(p, i);
                //tableProduct.Rows.Add(p);
                //Product_Import _Import = new Product_Import(txtID.Text, txtName.Text, supplierBox.Text, txtRetail.Text, txtOnOrder.Text, txtMinimum.Text, txtMaximum.Text, txtInstock.Text, txtImport.Text);
                agent.save(a);
                btnAll_Click(sender, e);
                //tableAgent.Rows.Add(a.AgentID,a.AgentName,a.Address,a.Contact,a.Password);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OKCancel);
            }
            


            clearText();
            //showGRD();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Agent a = new Agent(txtID.Text, txtName.Text, txtAdd.Text, txtContact.Text,txtPass.Text);
            //try
            //{
            //    agent.save(a);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Error!",MessageBoxButtons.OK);
            //}
            //clearText();
            //showGRD();
            agent.delete_all();
            for (int i = 0; i < tableAgent.RowCount; i++)
            {
                agent.save(new Agent(tableAgent.Rows[i].Cells[0].Value.ToString(), tableAgent.Rows[i].Cells[1].Value.ToString(), tableAgent.Rows[i].Cells[2].Value.ToString(), tableAgent.Rows[i].Cells[3].Value.ToString(), tableAgent.Rows[i].Cells[4].Value.ToString()));
            }
            btnAll_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.tableAgent.SelectedRows.Count > 0)
            {
                tableAgent.Rows.RemoveAt(this.tableAgent.SelectedRows[0].Index);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Agent a = new Agent(txtID.Text, txtName.Text, txtAdd.Text, txtContact.Text, txtPass.Text);
            //agent.saveChange(a);
            clearText();
            //showGRD();
        }

    }
}
