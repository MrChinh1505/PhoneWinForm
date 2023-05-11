using MobilePhone.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhone
{
    public partial class FormMain : Form
    {
        // create a form to store current form on child form panel
        private Form currentForm;
        private bool _isLoggedIn = false;

        public FormMain()
        {
            InitializeComponent();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        public void OpenChildForm(Form newForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = newForm;
            currentForm.TopLevel = false; // allow to display on child form
            currentForm.Dock = DockStyle.Fill; // auto fill size on child form
            currentForm.WindowState = FormWindowState.Maximized;
            currentForm.FormBorderStyle = FormBorderStyle.None; // no border button
            tabLabel.Text = currentForm.Text;
  
            childForm.Controls.Add(currentForm);// add to child form panel
            newForm.Show(); //  show form
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAgent());
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct());
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormImport());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOrder());
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDashBoard());
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAnalyze());
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDelivery());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAnalyze());
        }
    }
}

