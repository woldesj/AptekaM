
namespace Apteka
{
    partial class pharmacistOrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacistOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orders_clearBtn = new System.Windows.Forms.Button();
            this.orders_addBtn = new System.Windows.Forms.Button();
            this.orders_quantity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.orders_regPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orders_prodName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orders_prodID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orders_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.orders_removeBtn = new System.Windows.Forms.Button();
            this.orders_receiptBtn = new System.Windows.Forms.Button();
            this.orders_payBtn = new System.Windows.Forms.Button();
            this.orders_change = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.orders_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.orders_totalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 326);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Товари в наявності";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(18, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(560, 259);
            this.dataGridView1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.orders_clearBtn);
            this.panel2.Controls.Add(this.orders_addBtn);
            this.panel2.Controls.Add(this.orders_quantity);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.orders_regPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.orders_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.orders_prodID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.orders_category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(16, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 368);
            this.panel2.TabIndex = 1;
            // 
            // orders_clearBtn
            // 
            this.orders_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.orders_clearBtn.FlatAppearance.BorderSize = 0;
            this.orders_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_clearBtn.ForeColor = System.Drawing.Color.White;
            this.orders_clearBtn.Location = new System.Drawing.Point(49, 295);
            this.orders_clearBtn.Name = "orders_clearBtn";
            this.orders_clearBtn.Size = new System.Drawing.Size(501, 39);
            this.orders_clearBtn.TabIndex = 17;
            this.orders_clearBtn.Text = "Очистити";
            this.orders_clearBtn.UseVisualStyleBackColor = false;
            this.orders_clearBtn.Click += new System.EventHandler(this.orders_clearBtn_Click);
            // 
            // orders_addBtn
            // 
            this.orders_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.orders_addBtn.FlatAppearance.BorderSize = 0;
            this.orders_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_addBtn.ForeColor = System.Drawing.Color.White;
            this.orders_addBtn.Location = new System.Drawing.Point(49, 237);
            this.orders_addBtn.Name = "orders_addBtn";
            this.orders_addBtn.Size = new System.Drawing.Size(501, 39);
            this.orders_addBtn.TabIndex = 16;
            this.orders_addBtn.Text = "Додати";
            this.orders_addBtn.UseVisualStyleBackColor = false;
            this.orders_addBtn.Click += new System.EventHandler(this.orders_addBtn_Click);
            // 
            // orders_quantity
            // 
            this.orders_quantity.BackColor = System.Drawing.Color.Azure;
            this.orders_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orders_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_quantity.Location = new System.Drawing.Point(408, 75);
            this.orders_quantity.Name = "orders_quantity";
            this.orders_quantity.Size = new System.Drawing.Size(174, 29);
            this.orders_quantity.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Кількість:";
            // 
            // orders_regPrice
            // 
            this.orders_regPrice.AutoSize = true;
            this.orders_regPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_regPrice.Location = new System.Drawing.Point(156, 136);
            this.orders_regPrice.Name = "orders_regPrice";
            this.orders_regPrice.Size = new System.Drawing.Size(40, 24);
            this.orders_regPrice.TabIndex = 13;
            this.orders_regPrice.Text = "-----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ціна:";
            // 
            // orders_prodName
            // 
            this.orders_prodName.AutoSize = true;
            this.orders_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_prodName.Location = new System.Drawing.Point(156, 80);
            this.orders_prodName.Name = "orders_prodName";
            this.orders_prodName.Size = new System.Drawing.Size(40, 24);
            this.orders_prodName.TabIndex = 11;
            this.orders_prodName.Text = "-----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Назва товару:";
            // 
            // orders_prodID
            // 
            this.orders_prodID.BackColor = System.Drawing.Color.Azure;
            this.orders_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_prodID.FormattingEnabled = true;
            this.orders_prodID.Location = new System.Drawing.Point(408, 14);
            this.orders_prodID.Name = "orders_prodID";
            this.orders_prodID.Size = new System.Drawing.Size(174, 32);
            this.orders_prodID.TabIndex = 9;
            this.orders_prodID.SelectedIndexChanged += new System.EventHandler(this.orders_prodID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID товару:";
            // 
            // orders_category
            // 
            this.orders_category.BackColor = System.Drawing.Color.Azure;
            this.orders_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_category.FormattingEnabled = true;
            this.orders_category.Location = new System.Drawing.Point(123, 14);
            this.orders_category.Name = "orders_category";
            this.orders_category.Size = new System.Drawing.Size(174, 32);
            this.orders_category.TabIndex = 7;
            this.orders_category.SelectedIndexChanged += new System.EventHandler(this.orders_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Категорія:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.orders_removeBtn);
            this.panel3.Controls.Add(this.orders_receiptBtn);
            this.panel3.Controls.Add(this.orders_payBtn);
            this.panel3.Controls.Add(this.orders_change);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.orders_amount);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.orders_totalPrice);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(627, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 714);
            this.panel3.TabIndex = 1;
            // 
            // orders_removeBtn
            // 
            this.orders_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.orders_removeBtn.FlatAppearance.BorderSize = 0;
            this.orders_removeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_removeBtn.ForeColor = System.Drawing.Color.White;
            this.orders_removeBtn.Location = new System.Drawing.Point(15, 661);
            this.orders_removeBtn.Name = "orders_removeBtn";
            this.orders_removeBtn.Size = new System.Drawing.Size(348, 39);
            this.orders_removeBtn.TabIndex = 22;
            this.orders_removeBtn.Text = "Видалити";
            this.orders_removeBtn.UseVisualStyleBackColor = false;
            this.orders_removeBtn.Click += new System.EventHandler(this.orders_removeBtn_Click);
            // 
            // orders_receiptBtn
            // 
            this.orders_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.orders_receiptBtn.FlatAppearance.BorderSize = 0;
            this.orders_receiptBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_receiptBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_receiptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_receiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.orders_receiptBtn.Location = new System.Drawing.Point(15, 583);
            this.orders_receiptBtn.Name = "orders_receiptBtn";
            this.orders_receiptBtn.Size = new System.Drawing.Size(348, 39);
            this.orders_receiptBtn.TabIndex = 21;
            this.orders_receiptBtn.Text = "Рецепт";
            this.orders_receiptBtn.UseVisualStyleBackColor = false;
            this.orders_receiptBtn.Click += new System.EventHandler(this.orders_receiptBtn_Click);
            // 
            // orders_payBtn
            // 
            this.orders_payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.orders_payBtn.FlatAppearance.BorderSize = 0;
            this.orders_payBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_payBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_payBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.orders_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_payBtn.ForeColor = System.Drawing.Color.White;
            this.orders_payBtn.Location = new System.Drawing.Point(15, 528);
            this.orders_payBtn.Name = "orders_payBtn";
            this.orders_payBtn.Size = new System.Drawing.Size(348, 39);
            this.orders_payBtn.TabIndex = 18;
            this.orders_payBtn.Text = "Оплатити";
            this.orders_payBtn.UseVisualStyleBackColor = false;
            this.orders_payBtn.Click += new System.EventHandler(this.orders_payBtn_Click);
            // 
            // orders_change
            // 
            this.orders_change.AutoSize = true;
            this.orders_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_change.Location = new System.Drawing.Point(206, 467);
            this.orders_change.Name = "orders_change";
            this.orders_change.Size = new System.Drawing.Size(55, 24);
            this.orders_change.TabIndex = 19;
            this.orders_change.Text = "$0.00";
            this.orders_change.Click += new System.EventHandler(this.orders_change_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(128, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "Решта:";
            // 
            // orders_amount
            // 
            this.orders_amount.BackColor = System.Drawing.Color.Azure;
            this.orders_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orders_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_amount.Location = new System.Drawing.Point(256, 408);
            this.orders_amount.Name = "orders_amount";
            this.orders_amount.Size = new System.Drawing.Size(94, 29);
            this.orders_amount.TabIndex = 20;
            this.orders_amount.TextChanged += new System.EventHandler(this.orders_amount_TextChanged);
            this.orders_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.orders_amount_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 410);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Внесена покупцем сума:";
            // 
            // orders_totalPrice
            // 
            this.orders_totalPrice.AutoSize = true;
            this.orders_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_totalPrice.Location = new System.Drawing.Point(194, 360);
            this.orders_totalPrice.Name = "orders_totalPrice";
            this.orders_totalPrice.Size = new System.Drawing.Size(55, 24);
            this.orders_totalPrice.TabIndex = 19;
            this.orders_totalPrice.Text = "$0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Сума:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Всі замовлення";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(15, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.Size = new System.Drawing.Size(348, 259);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // pharmacistOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pharmacistOrders";
            this.Size = new System.Drawing.Size(1019, 752);
            this.Load += new System.EventHandler(this.pharmacistOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox orders_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orders_prodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown orders_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label orders_regPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label orders_prodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orders_addBtn;
        private System.Windows.Forms.Button orders_clearBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label orders_totalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox orders_amount;
        private System.Windows.Forms.Label orders_change;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button orders_payBtn;
        private System.Windows.Forms.Button orders_removeBtn;
        private System.Windows.Forms.Button orders_receiptBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
