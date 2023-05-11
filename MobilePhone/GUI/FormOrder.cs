using BLL;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MobilePhone.GUI
{
    public partial class FormOrder : Form
    {
        private ProductService productService = new ProductService();
        private OrderService Order = new OrderService();
        private AgentService Agent = new AgentService();
        private string id;
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            id = DateTime.Now.ToString("yyyyMMddHss");

            txtOrderID.Text = DateTime.Now.ToString("yyyyMMddHss");
            txtDateTime.Text = DateTime.Now.ToString("yyy-MM-dd");
            txtPID.Focus();
            // show column on table
            productOrderTable.Columns.Add("ID", "ID");
            productOrderTable.Columns.Add("Name", "Name");
            productOrderTable.Columns.Add("Price", "Price");
            productOrderTable.Columns.Add("Quantity", "Quantity");
            productOrderTable.Columns.Add("Total", "Total");
        }

        public void handleNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public double calcTotal()
        {
            double total = 0;
            for (int i = 0; i < productOrderTable.Rows.Count; i++)
            {
                total += double.Parse(productOrderTable.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Order.save(new Order(txtOrderID.Text,txtAgentID.Text,txtDateTime.Text, txtTotal.Text));
            for(int  i = 0; i < productOrderTable.Rows.Count; i++)
            {
                string pID = productOrderTable.Rows[i].Cells[0].Value.ToString();
                string quan = productOrderTable.Rows[i].Cells[3].Value.ToString();
                string price = productOrderTable.Rows[i].Cells[2].Value.ToString();
                Order.saveDetail(txtOrderID.Text, pID, quan, price);
            }
            MessageBox.Show("Successfully");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPID_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPID.Text))
            {
                return;
            }

            try
            {
                DataTable product = productService.find(txtPID.Text);
                txtProName.Text = product.Rows[0][1].ToString();
                txtPrice.Text = product.Rows[0][2].ToString();
                txtProTotal.Text = (int.Parse(product.Rows[0][2].ToString()) * int.Parse(txtAmount.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot find product!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text == "") return;
            double t = double.Parse(txtPrice.Text) * double.Parse(txtAmount.Text);
            txtProTotal.Text = (t).ToString();
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            double dis = 0.0;
            // parse to double
            if (!double.TryParse(txtDiscount.Text, out dis))
            {
                dis = 0.0;
            }
            dis /= 100.0;
            // calc total
            double t = double.Parse(txtPrice.Text) * double.Parse(txtAmount.Text);
            txtProTotal.Text = (t - t*dis).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productOrderTable.Rows.Add(txtPID.Text, txtProName.Text, txtPrice.Text, txtAmount.Text, txtProTotal.Text);
            txtTotal.Text = calcTotal().ToString();
        }

        private void productOrderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPID.Text = productOrderTable.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = productOrderTable.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = productOrderTable.CurrentRow.Cells[2].Value.ToString();
            txtAmount.Text = productOrderTable.CurrentRow.Cells[3].Value.ToString();
            txtProTotal.Text = productOrderTable.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (productOrderTable.CurrentRow != null)
            {
                productOrderTable.CurrentRow.Cells[0].Value = txtPID.Text;
                productOrderTable.CurrentRow.Cells[1].Value = txtProName.Text;
                productOrderTable.CurrentRow.Cells[2].Value = txtPrice.Text;
                productOrderTable.CurrentRow.Cells[3].Value = txtAmount.Text;
                productOrderTable.CurrentRow.Cells[4].Value = txtProTotal.Text;
            }
            txtTotal.Text = calcTotal().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow cur = productOrderTable.Rows[productOrderTable.CurrentRow.Index];
            productOrderTable.Rows.Remove(cur);
            txtTotal.Text = calcTotal().ToString();
        }

        private void txtCus_Leave(object sender, EventArgs e)
        {
            DataTable dt = Agent.find(txtAgentID.Text);

            if(dt.Rows.Count > 0)
            {
                txtAgentName.Text = dt.Rows[0][1].ToString();
                txtAgentAdd.Text = dt.Rows[0][2].ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (productOrderTable.Rows.Count == 0)
            {
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save Order as PDF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("Order.pdf", FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(productOrderTable.Columns.Count);
                // Lấy các header của datagridview và thêm vào bảng
                for (int j = 0; j < productOrderTable.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(productOrderTable.Columns[j].HeaderText));
                }
                // Lấy các dòng dữ liệu của datagridview và thêm vào bảng
                for (int i = 0; i < productOrderTable.Rows.Count; i++)
                {
                    for (int k = 0; k < productOrderTable.Columns.Count; k++)
                    {
                        if (productOrderTable[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(productOrderTable[k, i].Value.ToString()));
                        }
                    }
                }

                // Thêm các thông tin khác vào file PDF
                document.Add(new Paragraph("Order ID: " + txtOrderID.Text));
                document.Add(new Paragraph("Date Time: " + txtDateTime.Text));
                document.Add(new Paragraph("Total: " + txtTotal.Text));
                document.Add(new Paragraph("Agent ID: " + txtAgentID.Text));
                document.Add(new Paragraph("Agent Name: " + txtAgentName.Text));
                document.Add(new Paragraph("Agent Address: " + txtAgentAdd.Text));

                // Thêm bảng vào file PDF
                document.Add(table);

                // Đóng file PDF
                document.Close();

                // Hiển thị thông báo khi in thành công
                MessageBox.Show("Print Successful!");
            }
        }
    }
}
