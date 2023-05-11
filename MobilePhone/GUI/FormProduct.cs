using BLL;
using DTO;
using MobilePhone.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MobilePhone.GUI
{
    public partial class FormProduct : Form
    {
        private ProductService productService = new ProductService();

        public FormProduct()
        {
            InitializeComponent();
        }

        public void enableButton(Button b , bool e)
        {
            b.Enabled = e;
        }

        public void showGRD(DataTable tb)
        {
            tableProduct.DataSource = tb;
        }

        public void loadSupplier()
        {
            supplierBox.DataSource = productService.allSupplier();
            supplierBox.DisplayMember = "SupplierName";
            supplierBox.ValueMember = "SupplierID";
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            //enableButton(btnDelete, false);
            //enableButton(btnUpdate, false);
            //enableButton(btnExportData, false);
            DataTable tb = productService.getAll();
            loadSupplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            //txtRetail.Text = "";
            txtImport.Text = "";
            //txtInstock.Text = "";
            //txtOnOrder.Text = "";
            supplierBox.Text = "";
            //txtMinimum.Text = "";
            //txtMaximum.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Product p = new Product(txtID.Text, txtName.Text, supplierBox.Text,txtRetail.Text);
            //Inventory i = new Inventory(txtOnOrder.Text, txtMinimum.Text,txtMaximum.Text, txtInstock.Text,txtImport.Text);
            //try
            //{
            //    productService.save(p,i);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OKCancel);
            //}
            
            //showGRD(productService.getAll());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product p = new Product(txtID.Text, txtName.Text, supplierBox.Text, txtImport.Text);
           // Inventory i = new Inventory(txtOnOrder.Text, txtMinimum.Text, txtMaximum.Text, txtInstock.Text, txtImport.Text);

            //try
            //{
            //    productService.update(p, i);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OKCancel);
            //}

            showGRD(productService.getAll());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productService.delete(txtID.Text);
            showGRD(productService.getAll());
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable tb = productService.getAll();
            showGRD(tb);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //DataTable tb = productService.find(searchBox.Text); 
            //showGRD(tb);
        }

        private void tableProduct_Click(object sender, EventArgs e)
        {
            //txtID.Text = tableProduct.CurrentRow.Cells[0].Value.ToString();
            //txtName.Text = tableProduct.CurrentRow.Cells[1].Value.ToString();
            //txtRetail.Text = tableProduct.CurrentRow.Cells[2].Value.ToString();
            //txtImport.Text = tableProduct.CurrentRow.Cells[3].Value.ToString();
            //txtInstock.Text = tableProduct.CurrentRow.Cells[4].Value.ToString();
            //txtOnOrder.Text = tableProduct.CurrentRow.Cells[5].Value.ToString();
            //supplierBox.Text = tableProduct.CurrentRow.Cells[6].Value.ToString();
            //txtMinimum.Text = tableProduct.CurrentRow.Cells[7].Value.ToString();
            //txtMaximum.Text = tableProduct.CurrentRow.Cells[8].Value.ToString();

            //enableButton(btnDelete,true);
            //enableButton(btnUpdate,true);
            //enableButton(btnExportData,true);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Product p = new Product(txtID.Text, txtName.Text, supplierBox.Text, txtImport.Text);
            //Inventory i = new Inventory(txtOnOrder.Text, txtMinimum.Text, txtMaximum.Text, txtInstock.Text, txtImport.Text);
            try
            {
                //productService.save(p, i);
                //tableProduct.Rows.Add(p);
                //Product_Import _Import = new Product_Import(txtID.Text, txtName.Text, supplierBox.Text, txtRetail.Text, txtOnOrder.Text, txtMinimum.Text, txtMaximum.Text, txtInstock.Text, txtImport.Text);
                productBindingSource.Add(p);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OKCancel);
            }

            //showGRD(productService.getAll());
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < tableProduct.RowCount; i++)
            {
                productService.save(new Product(tableProduct.Rows[i].Cells[0].Value.ToString(), tableProduct.Rows[i].Cells[1].Value.ToString(), tableProduct.Rows[i].Cells[2].Value.ToString(), tableProduct.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void tableProduct_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = tableProduct.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = tableProduct.CurrentRow.Cells[1].Value.ToString();
            //txtRetail.Text = tableProduct.CurrentRow.Cells[2].Value.ToString();
            txtImport.Text = tableProduct.CurrentRow.Cells[3].Value.ToString();
            //txtInstock.Text = tableProduct.CurrentRow.Cells[4].Value.ToString();
            //txtOnOrder.Text = tableProduct.CurrentRow.Cells[5].Value.ToString();
            supplierBox.Text = tableProduct.CurrentRow.Cells[6].Value.ToString();
            //txtMinimum.Text = tableProduct.CurrentRow.Cells[7].Value.ToString();
            //txtMaximum.Text = tableProduct.CurrentRow.Cells[8].Value.ToString();

            enableButton(btnDelete, true);
            //enableButton(btnUpdate, true);
           // enableButton(btnExportData, true);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (this.tableProduct.SelectedRows.Count > 0)
            {
                tableProduct.Rows.RemoveAt(this.tableProduct.SelectedRows[0].Index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable tb = productService.getAll();
            tableProductManager.DataSource = tb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable tb = productService.find(searchBox.Text);
            tableProductManager.DataSource=tb;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.tableProductManager.SelectedRows.Count > 0)
            {
                tableProductManager.Rows.RemoveAt(this.tableProductManager.SelectedRows[0].Index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productService.delete_all();
            for (int i = 0; i < tableProductManager.RowCount; i++)
            {
                productService.save(new Product(tableProductManager.Rows[i].Cells[0].Value.ToString(), tableProductManager.Rows[i].Cells[1].Value.ToString(), tableProductManager.Rows[i].Cells[3].Value.ToString(), tableProductManager.Rows[i].Cells[2].Value.ToString()));
            }
        }
    }
}
