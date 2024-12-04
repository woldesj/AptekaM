using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class pharmacistMainForm : Form
    {
        public pharmacistMainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете вийти?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете вийти?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void pharmacistOrders2_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            pharmacistOrders1.Visible = false;
            adminCustomers1.Visible = false;

            adminDashboard aDashboard = adminDashboard1 as adminDashboard;

            if(aDashboard != null)
            {
                aDashboard.refreshData();
            }

        }

        private void orders_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            pharmacistOrders1.Visible = true;
            adminCustomers1.Visible = false;

            pharmacistOrders cOrders = pharmacistOrders1 as pharmacistOrders;

            if (cOrders != null)
            {
                cOrders.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            pharmacistOrders1.Visible = false;
            adminCustomers1.Visible = true;

            adminCustomers aCustomers = adminCustomers1 as adminCustomers;

            if (aCustomers != null)
            {
                aCustomers.refreshData();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
