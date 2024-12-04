
using System.Windows.Forms;

namespace Apteka

{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new Apteka.adminDashboard();
            this.adminAddCategories1 = new Apteka.adminAddCategories();
            this.adminCustomers1 = new Apteka.adminCustomers();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.close = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customers_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.addUsers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addCategories_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.addProducts_btn);
            this.panel2.Controls.Add(this.addUsers_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.addCategories_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 752);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::Apteka.Properties.Resources.icons8_logout_24;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(13, 692);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(230, 37);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Text = "Вийти";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адміністратор";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.adminAddCategories1);
            this.panel3.Controls.Add(this.adminCustomers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(254, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 752);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1019, 795);
            this.adminDashboard1.TabIndex = 9;
            this.adminDashboard1.Load += new System.EventHandler(this.adminDashboard1_Load_1);
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 0);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1019, 752);
            this.adminAddCategories1.TabIndex = 9;
            // 
            // adminCustomers1
            // 
            this.adminCustomers1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adminCustomers1.Location = new System.Drawing.Point(-33, 15);
            this.adminCustomers1.Name = "adminCustomers1";
            this.adminCustomers1.Size = new System.Drawing.Size(1019, 752);
            this.adminCustomers1.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(1235, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 25);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(654, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Система керування аптекою, Панель керування адміністратора";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customers_btn
            // 
            this.customers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.customers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.customers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.White;
            this.customers_btn.Image = global::Apteka.Properties.Resources.icons8_receipts_18;
            this.customers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_btn.Location = new System.Drawing.Point(12, 453);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(230, 37);
            this.customers_btn.TabIndex = 6;
            this.customers_btn.Text = "Транзакції";
            this.customers_btn.UseVisualStyleBackColor = false;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_btn.FlatAppearance.BorderSize = 0;
            this.addProducts_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addProducts_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addProducts_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.ForeColor = System.Drawing.Color.White;
            this.addProducts_btn.Image = global::Apteka.Properties.Resources.prod24;
            this.addProducts_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProducts_btn.Location = new System.Drawing.Point(12, 334);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(230, 37);
            this.addProducts_btn.TabIndex = 5;
            this.addProducts_btn.Text = "Додати товари";
            this.addProducts_btn.UseVisualStyleBackColor = false;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addUsers_btn.FlatAppearance.BorderSize = 0;
            this.addUsers_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addUsers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addUsers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addUsers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_btn.ForeColor = System.Drawing.Color.White;
            this.addUsers_btn.Image = global::Apteka.Properties.Resources.icons8users_18;
            this.addUsers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUsers_btn.Location = new System.Drawing.Point(13, 273);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(230, 37);
            this.addUsers_btn.TabIndex = 4;
            this.addUsers_btn.Text = "    Додати користувачів";
            this.addUsers_btn.UseVisualStyleBackColor = false;
            this.addUsers_btn.Click += new System.EventHandler(this.addUsers_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::Apteka.Properties.Resources.icons8_dashboard_18;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(14, 213);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(230, 37);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "Панель керування";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apteka.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(79, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addCategories_btn
            // 
            this.addCategories_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addCategories_btn.FlatAppearance.BorderSize = 0;
            this.addCategories_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addCategories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addCategories_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addCategories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_btn.ForeColor = System.Drawing.Color.White;
            this.addCategories_btn.Image = global::Apteka.Properties.Resources.icons8_list_18;
            this.addCategories_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategories_btn.Location = new System.Drawing.Point(12, 394);
            this.addCategories_btn.Name = "addCategories_btn";
            this.addCategories_btn.Size = new System.Drawing.Size(230, 37);
            this.addCategories_btn.TabIndex = 8;
            this.addCategories_btn.Text = "Додати категорії";
            this.addCategories_btn.UseVisualStyleBackColor = false;
            this.addCategories_btn.Click += new System.EventHandler(this.addCategories_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 795);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addCategories_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private adminCustomers adminCustomers1;
        private adminAddProducts adminAddProducts1;
        private adminAddUsers adminAddUsers1;
        private adminAddCategories adminAddCategories1;
        private adminDashboard adminDashboard1;
        private Label close;
        private Label label4;
        private Panel panel1;
        private Button addUsers_btn;
    }
}