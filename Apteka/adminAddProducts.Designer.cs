
namespace Apteka
{
    partial class adminAddProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addProducts_clearBtn = new System.Windows.Forms.Button();
            this.addProducts_deleteBtn = new System.Windows.Forms.Button();
            this.addProducts_updateBtn = new System.Windows.Forms.Button();
            this.addProducts_addBtn = new System.Windows.Forms.Button();
            this.addProducts_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addProducts_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addProducts_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProducts_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProducts_productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProducts_prodID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 358);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(939, 278);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Товари";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.addProducts_clearBtn);
            this.panel2.Controls.Add(this.addProducts_deleteBtn);
            this.panel2.Controls.Add(this.addProducts_updateBtn);
            this.panel2.Controls.Add(this.addProducts_addBtn);
            this.panel2.Controls.Add(this.addProducts_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addProducts_stock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addProducts_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addProducts_category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addProducts_productName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addProducts_prodID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 325);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addProducts_clearBtn
            // 
            this.addProducts_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addProducts_clearBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_clearBtn.Location = new System.Drawing.Point(676, 248);
            this.addProducts_clearBtn.Name = "addProducts_clearBtn";
            this.addProducts_clearBtn.Size = new System.Drawing.Size(114, 39);
            this.addProducts_clearBtn.TabIndex = 17;
            this.addProducts_clearBtn.Text = "Очистити";
            this.addProducts_clearBtn.UseVisualStyleBackColor = false;
            this.addProducts_clearBtn.Click += new System.EventHandler(this.addProducts_clearBtn_Click);
            // 
            // addProducts_deleteBtn
            // 
            this.addProducts_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addProducts_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_deleteBtn.Location = new System.Drawing.Point(530, 248);
            this.addProducts_deleteBtn.Name = "addProducts_deleteBtn";
            this.addProducts_deleteBtn.Size = new System.Drawing.Size(114, 39);
            this.addProducts_deleteBtn.TabIndex = 16;
            this.addProducts_deleteBtn.Text = "Видалити";
            this.addProducts_deleteBtn.UseVisualStyleBackColor = false;
            this.addProducts_deleteBtn.Click += new System.EventHandler(this.addProducts_deleteBtn_Click);
            // 
            // addProducts_updateBtn
            // 
            this.addProducts_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addProducts_updateBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_updateBtn.Location = new System.Drawing.Point(354, 248);
            this.addProducts_updateBtn.Name = "addProducts_updateBtn";
            this.addProducts_updateBtn.Size = new System.Drawing.Size(114, 39);
            this.addProducts_updateBtn.TabIndex = 15;
            this.addProducts_updateBtn.Text = "Оновити";
            this.addProducts_updateBtn.UseVisualStyleBackColor = false;
            this.addProducts_updateBtn.Click += new System.EventHandler(this.addProducts_updateBtn_Click);
            // 
            // addProducts_addBtn
            // 
            this.addProducts_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.addProducts_addBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.addProducts_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_addBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_addBtn.Location = new System.Drawing.Point(208, 248);
            this.addProducts_addBtn.Name = "addProducts_addBtn";
            this.addProducts_addBtn.Size = new System.Drawing.Size(114, 39);
            this.addProducts_addBtn.TabIndex = 14;
            this.addProducts_addBtn.Text = "Додати";
            this.addProducts_addBtn.UseVisualStyleBackColor = false;
            this.addProducts_addBtn.Click += new System.EventHandler(this.addProducts_addBtn_Click);
            // 
            // addProducts_status
            // 
            this.addProducts_status.BackColor = System.Drawing.Color.Azure;
            this.addProducts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_status.FormattingEnabled = true;
            this.addProducts_status.Items.AddRange(new object[] {
            "Активна",
            "Не активна"});
            this.addProducts_status.Location = new System.Drawing.Point(658, 132);
            this.addProducts_status.Name = "addProducts_status";
            this.addProducts_status.Size = new System.Drawing.Size(207, 32);
            this.addProducts_status.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Статус:";
            // 
            // addProducts_stock
            // 
            this.addProducts_stock.BackColor = System.Drawing.Color.Azure;
            this.addProducts_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProducts_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_stock.Location = new System.Drawing.Point(658, 88);
            this.addProducts_stock.Name = "addProducts_stock";
            this.addProducts_stock.Size = new System.Drawing.Size(207, 29);
            this.addProducts_stock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Кількість:";
            // 
            // addProducts_price
            // 
            this.addProducts_price.BackColor = System.Drawing.Color.Azure;
            this.addProducts_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProducts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_price.Location = new System.Drawing.Point(658, 50);
            this.addProducts_price.Name = "addProducts_price";
            this.addProducts_price.Size = new System.Drawing.Size(207, 29);
            this.addProducts_price.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ціна:";
            // 
            // addProducts_category
            // 
            this.addProducts_category.BackColor = System.Drawing.Color.Azure;
            this.addProducts_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_category.FormattingEnabled = true;
            this.addProducts_category.Location = new System.Drawing.Point(219, 131);
            this.addProducts_category.Name = "addProducts_category";
            this.addProducts_category.Size = new System.Drawing.Size(207, 32);
            this.addProducts_category.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Категорія:";
            // 
            // addProducts_productName
            // 
            this.addProducts_productName.BackColor = System.Drawing.Color.Azure;
            this.addProducts_productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProducts_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_productName.Location = new System.Drawing.Point(219, 90);
            this.addProducts_productName.Name = "addProducts_productName";
            this.addProducts_productName.Size = new System.Drawing.Size(207, 29);
            this.addProducts_productName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назва товару:";
            // 
            // addProducts_prodID
            // 
            this.addProducts_prodID.BackColor = System.Drawing.Color.Azure;
            this.addProducts_prodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProducts_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_prodID.Location = new System.Drawing.Point(219, 49);
            this.addProducts_prodID.Name = "addProducts_prodID";
            this.addProducts_prodID.Size = new System.Drawing.Size(131, 29);
            this.addProducts_prodID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Товару:";
            // 
            // adminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminAddProducts";
            this.Size = new System.Drawing.Size(1019, 752);
            this.Load += new System.EventHandler(this.adminAddProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addProducts_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addProducts_productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProducts_prodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addProducts_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addProducts_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addProducts_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addProducts_clearBtn;
        private System.Windows.Forms.Button addProducts_deleteBtn;
        private System.Windows.Forms.Button addProducts_updateBtn;
        private System.Windows.Forms.Button addProducts_addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
