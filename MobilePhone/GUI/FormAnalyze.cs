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
using ClosedXML.Excel;


namespace MobilePhone.GUI
{
    public partial class FormAnalyze : Form
    {

        private OrderService os = new OrderService();
        private ReceiptService rs = new ReceiptService();
        public FormAnalyze()
        {
            InitializeComponent();
        }

        private void PopulateDataGridViewList(System.Windows.Forms.ComboBox comboBox)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {       
                if (control is DataGridView)
                {
                    comboBox.Items.Add(control);
                }           
            }

            // Chọn DataGridView đầu tiên
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == 0) // incoming
            {
                // Show a SaveFileDialog to get the location to save the data
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Incoming Data As";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Call the ExportToExcel function for the selected DataGridView
                    ExportToExcel(dataGridView1, saveFileDialog.FileName);
                    MessageBox.Show("Data exported successfully!", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (listBox.SelectedIndex == 1) // outgoing
            {
                // Show a SaveFileDialog to get the location to save the data
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Outgoing Data As";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Call the ExportToExcel function for the selected DataGridView
                    ExportToExcel(dataGridView2, saveFileDialog.FileName);
                    MessageBox.Show("Data exported successfully!", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");

                // Tạo tiêu đề cho các cột
                int columnIndex = 1;
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    worksheet.Cell(1, columnIndex).Value = column.HeaderText;
                    columnIndex++;
                }

                // Sao chép dữ liệu từ DataGridView
                int rowIndex = 2;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    columnIndex = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            worksheet.Cell(rowIndex, columnIndex).Value = cell.Value.ToString();
                        }
                        columnIndex++;
                    }
                    rowIndex++;
                }

                // Lưu tệp Excel
                workbook.SaveAs(filePath);
            }
        }

        private void FormAnalyze_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rs.findAll();
            dataGridView2.DataSource = os.findAll();
            dataGridView3.DataSource = os.TopSeller(10);
            chart1.DataSource = os.TopSeller(10);
            chart1.Series["Amount"].XValueMember = "ProductName";
            chart1.Series["Amount"].YValueMembers = "TotalQuantity";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
