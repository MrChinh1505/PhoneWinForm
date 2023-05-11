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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Office.Interop;

namespace MobilePhone.GUI
{
    public partial class FormImport : Form
    {
        private ReceiptService re = new ReceiptService();
        private ProductService ps = new ProductService();
        public FormImport()
        {
            InitializeComponent();
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            receiptTable.DataSource = re.findAll();
            //groupBox6.Enabled = false;
            comboBox1.DataSource = re.SupplierList();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "SupplierID";

            //comboBoxProduct.DataSource = ps.getAll();
            //comboBoxProduct.DisplayMember = "ProductName";
            //comboBoxProduct.ValueMember = "ProductId";

            txtDate.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;

            groupBox6.Enabled = true;
            groupBox5.Enabled = true;

            //receiptDetailTable.DataSource = null;

            // column headers
            //receiptDetailTable.Columns.Add("ImportID", "ImportID");
            //receiptDetailTable.Columns.Add("ProductID", "ProductID");
            //receiptDetailTable.Columns.Add("Quantity", "Quantity");
            //receiptDetailTable.Columns.Add("Price", "Price");

            txtReID.Text = DateTime.Now.ToString("yyMMddHHss");
            txtDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //txtDate.Enabled = true;
            //btnSave.Enabled = true;
            //btnDelete.Enabled = true;

            //groupBox6.Enabled = true;  
            //groupBox5.Enabled = true;

            receiptDetailTable.DataSource = null;

            //// column headers
            receiptDetailTable.Columns.Add("ImportID", "ImportID");
            receiptDetailTable.Columns.Add("ProductID", "ProductID");
            receiptDetailTable.Columns.Add("Quantity", "Quantity");
            receiptDetailTable.Columns.Add("Price", "Price");

            //txtReID.Text = DateTime.Now.ToString("yyMMddHHss");
            //txtDate.Value = DateTime.Now;
        }

        public void handleNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                re.delete(txtReID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error occurred!", MessageBoxButtons.OK);
            }
            receiptTable.DataSource = re.findAll();
        }

        public double calcTotal()
        {
            double total = 0.0;
            for (int i = 0; i < receiptDetailTable.Rows.Count; i++)
            {
                string quan = receiptDetailTable.Rows[i].Cells[2].Value.ToString();
                string price = receiptDetailTable.Rows[i].Cells[3].Value.ToString();

               total += double.Parse(quan)*double.Parse(price);
            }
            return total;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            re.save(new Receipt(txtReID.Text, comboBox1.SelectedValue.ToString(), txtDate.Value.ToString("yyyy-MM-dd"), totalBox.Text));

            for (int i = 0; i < receiptDetailTable.Rows.Count; i++)
            {
                string pID =  receiptDetailTable.Rows[i].Cells[0].Value.ToString();
                string quan =  receiptDetailTable.Rows[i].Cells[2].Value.ToString();
                string price =  receiptDetailTable.Rows[i].Cells[3].Value.ToString();

                re.saveDetail(txtReID.Text, pID, quan, price);
            }
            receiptTable.DataSource = re.findAll();
            MessageBox.Show("Successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = re.findByReceiptId(txtSearch.Text);
            if (dt != null)
            {
                receiptTable.DataSource = dt;
            }
        }

        private void receiptTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            receiptDetailTable.Columns.Clear();
            txtDate.Enabled = false;
            DataTable dt = re.findProductByReceiptId(receiptTable.CurrentRow.Cells[0].Value.ToString());
            DataTable dt1 = re.findByReceiptId(receiptTable.CurrentRow.Cells[0].Value.ToString());
            if(dt != null)
            {
                receiptDetailTable.DataSource = dt;
                //txtReID.Text = dt1.Rows[0][0].ToString();
                //txtDate.Value = DateTime.Parse(dt1.Rows[0][1].ToString());
                //comboBox1.SelectedValue = dt1.Rows[0][2].ToString();
                //totalBox.Text = dt1.Rows[0][3].ToString();
            }
            //btnDelete.Enabled = true;
            //btnSave.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            receiptDetailTable.Columns.Add("ImportID", "ImportID");
            receiptDetailTable.Columns.Add("ProductID", "ProductID");
            receiptDetailTable.Columns.Add("Quantity", "Quantity");
            receiptDetailTable.Columns.Add("Price", "Price");
            receiptDetailTable.Rows.Add(txtPID.Text, txtProName.Text, txtQuan.Text, txtImportPrice.Text);
            totalBox.Text = calcTotal().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow cur = receiptDetailTable.Rows[receiptDetailTable.CurrentRow.Index];
            receiptDetailTable.Rows.Remove(cur);
            totalBox.Text = calcTotal().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (receiptDetailTable.CurrentRow != null)
            {
                receiptDetailTable.CurrentRow.Cells[0].Value = txtPID.Text;
                receiptDetailTable.CurrentRow.Cells[1].Value = txtProName.Text;
                receiptDetailTable.CurrentRow.Cells[2].Value = txtImportPrice.Text;
                receiptDetailTable.CurrentRow.Cells[3].Value = txtQuan.Text;
            }
            totalBox.Text = calcTotal().ToString();
        }

        public void ExportToWord(DataGridView dataGridView1, DataGridView dataGridView2, string strPath)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = word.Documents.Add();


            Microsoft.Office.Interop.Word.Table table1 = document.Tables.Add(document.Range(), dataGridView1.RowCount + 1, dataGridView1.ColumnCount);

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                table1.Cell(1, i + 1).Range.Text = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    table1.Cell(i + 2, j + 1).Range.Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            Microsoft.Office.Interop.Word.Table table2 = document.Tables.Add(table1.Range.Next(), dataGridView2.RowCount + 1, dataGridView2.ColumnCount);

            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                table2.Cell(1, i + 1).Range.Text = dataGridView2.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    table2.Cell(i + 2, j + 1).Range.Text = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }

            document.SaveAs(strPath, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault);
            document.Close();
            word.Quit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (receiptTable.Rows.Count == 0)
            {
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word Document|*.docx";
            saveFileDialog.Title = "Export to Word";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                ExportToWord(receiptTable, receiptDetailTable, saveFileDialog.FileName);
                MessageBox.Show("Exported to Word successfully!");
            }
        }

        private void receiptDetailTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (receiptDetailTable.CurrentRow == null)
                return;
            txtPID.Text = receiptDetailTable.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = receiptDetailTable.CurrentRow.Cells[1].Value.ToString();
            txtQuan.Text = receiptDetailTable.CurrentRow.Cells[2].Value.ToString();
            txtImportPrice.Text = receiptDetailTable.CurrentRow.Cells[3].Value.ToString();
        }

        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Product product = ps.find();
            DataTable dt = ps.find(comboBoxProduct.SelectedValue.ToString());
            DataRow dataRowrow = dt.Rows[0];
            txtPID.Text = dataRowrow["ProductID"].ToString();
            txtProName.Text = dataRowrow["ProductName"].ToString();
            //txtQuan.Text = dataRowrow["ProductName"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }

        private void comboBoxProduct_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxProduct.DataSource = ps.getAll();
            comboBoxProduct.DisplayMember = "ProductName";
            comboBoxProduct.ValueMember = "ProductId";

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            receiptDetailTable.DataSource = null;
            //receiptDetailTable.Columns.Add("ImportID", "ImportID");
            //receiptDetailTable.Columns.Add("ProductID", "ProductID");
            //receiptDetailTable.Columns.Add("Quantity", "Quantity");
            //receiptDetailTable.Columns.Add("Price", "Price");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
