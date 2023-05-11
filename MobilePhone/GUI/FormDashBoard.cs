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
using System.Windows.Forms.DataVisualization.Charting;

namespace MobilePhone.GUI
{   
    // form này để thống kê thôi
    public partial class FormDashBoard : Form
    {
        OrderService or = new OrderService();
        public FormDashBoard()
        {
            InitializeComponent();

            ChartArea bestSellerChartArea = new ChartArea();
            Series bestSellerSeries = new Series();

            bestSellerChartArea.Name = "BestSeller";
            bestSellerChartArea.AxisX.MajorGrid.Enabled = false;
            bestSellerChartArea.AxisY.MajorGrid.Enabled = false;
            

            bestSellerSeries.Name = "BestSellerSeries";
            bestSellerSeries.ChartType = SeriesChartType.Column;
            bestSellerSeries.IsValueShownAsLabel = true;
            bestSellerSeries.ChartType = SeriesChartType.StackedBar;
            bestSellerSeries.IsVisibleInLegend = true;
            bestSellerSeries["PointWidth"] = "0.5";


            DataTable topSellerData = or.TopSeller(5);
            if (topSellerData != null && topSellerData.Rows.Count > 0)
            {
                bestSellerSeries.Points.DataBind(topSellerData.AsEnumerable(), "ProductName", "TotalQuantity", null);
            }

            bestSeller.Series.Add(bestSellerSeries);
            bestSeller.ChartAreas.Add(bestSellerChartArea);

            bestSeller.Invalidate();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            Form f = new FormAnalyze();
            f.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
