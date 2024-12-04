
namespace Apteka
{
    partial class pharmacistMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacistMainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new Apteka.adminDashboard();
            this.pharmacistOrders1 = new Apteka.pharmacistOrders();
            this.adminCustomers1 = new Apteka.adminCustomers();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orders_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.pharmacistOrders1);
            this.panel3.Controls.Add(this.adminCustomers1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1273, 752);
            this.panel3.TabIndex = 5;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adminDashboard1.Location = new System.Drawing.Point(254, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1019, 752);
            this.adminDashboard1.TabIndex = 9;
            // 
            // pharmacistOrders1
            // 
            this.pharmacistOrders1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pharmacistOrders1.Location = new System.Drawing.Point(254, 0);
            this.pharmacistOrders1.Name = "pharmacistOrders1";
            this.pharmacistOrders1.Size = new System.Drawing.Size(1019, 752);
            this.pharmacistOrders1.TabIndex = 9;
            // 
            // adminCustomers1
            // 
            this.adminCustomers1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adminCustomers1.Location = new System.Drawing.Point(254, 0);
            this.adminCustomers1.Name = "adminCustomers1";
            this.adminCustomers1.Size = new System.Drawing.Size(1019, 752);
            this.adminCustomers1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.orders_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 752);
            this.panel2.TabIndex = 2;
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
            this.logout_btn.Image = global::Apteka.Properties.Resources.icons8_logout_241;
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
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фармацевт";
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
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(627, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Система керування аптекою, Панель керування фармацевта";
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apteka.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(82, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // orders_btn
            // 
            this.orders_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.orders_btn.FlatAppearance.BorderSize = 0;
            this.orders_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_btn.ForeColor = System.Drawing.Color.White;
            this.orders_btn.Image = global::Apteka.Properties.Resources.icons8_list_182;
            this.orders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders_btn.Location = new System.Drawing.Point(13, 271);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(230, 37);
            this.orders_btn.TabIndex = 8;
            this.orders_btn.Text = "Замовлення";
            this.orders_btn.UseVisualStyleBackColor = false;
            this.orders_btn.Click += new System.EventHandler(this.orders_btn_Click);
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
            this.customers_btn.Image = global::Apteka.Properties.Resources.icons8_receipts_182;
            this.customers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_btn.Location = new System.Drawing.Point(13, 324);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(230, 37);
            this.customers_btn.TabIndex = 6;
            this.customers_btn.Text = "Транзакції";
            this.customers_btn.UseVisualStyleBackColor = false;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::Apteka.Properties.Resources.icons8_dashboard_181;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(13, 213);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(230, 37);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "Панель керування";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pharmacistMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 795);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pharmacistMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pharmacistMainForm";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button orders_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label label2;
        private adminDashboard adminDashboard1;
        private pharmacistOrders pharmacistOrders1;
        private adminCustomers adminCustomers1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}