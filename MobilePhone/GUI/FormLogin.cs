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
    public partial class FormLogin : Form
    {
        private EmployeeService em = new EmployeeService();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (em.login(emID.Text, pwd.Text))
            {
                MessageBox.Show("Success!", "", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Try again!", "Login fail!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
