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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            adminAddUsers1 = new adminAddUsers();
            adminAddUsers1.Visible = false;
            panel3.Controls.Add(adminAddUsers1);

            adminAddProducts1 = new adminAddProducts();
            adminAddProducts1.Visible = false;
            panel3.Controls.Add(adminAddProducts1);

            adminCustomers1 = new adminCustomers();
            adminCustomers1.Visible = false;
            panel3.Controls.Add(adminCustomers1);

            adminAddCategories1 = new adminAddCategories();
            adminAddCategories1.Visible = false;
            panel3.Controls.Add(adminAddCategories1);

            adminDashboard1 = new adminDashboard();
            adminDashboard1.Visible = true;
            panel3.Controls.Add(adminDashboard1);
        }

        private void addUsers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = true;
            
            adminAddProducts1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = false;

            adminAddUsers aaUsers = adminAddUsers1 as adminAddUsers;

            if (aaUsers != null)
            {
                aaUsers.refreshData();
            }adminAddUsers1.BringToFront();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете закрити програму?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = false;

            adminDashboard aDashboard = adminDashboard1 as adminDashboard;

            if (aDashboard != null)
            {
                aDashboard.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = true;
            adminAddProducts1.BringToFront();
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = false;

            adminAddProducts aaProd = adminAddProducts1 as adminAddProducts;

            if (aaProd != null)
            {
                aaProd.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminCustomers1.Visible = true;
            adminCustomers1.BringToFront();
            adminAddCategories1.Visible = false;

            adminCustomers aCust = adminCustomers1 as adminCustomers;

            if (aCust != null)
            {
                aCust.refreshData();
            }
        }

        private void addCategories_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddCategories1.BringToFront();

            adminAddCategories aaCat = adminAddCategories1 as adminAddCategories;

            if (aaCat != null)
            {
                aaCat.refreshData();
            }
        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {
            
        }
        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }
        private void adminCustomers1_Load(object sender, EventArgs e)
        {

        }
        private void adminAddCategories1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void adminDashboard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
