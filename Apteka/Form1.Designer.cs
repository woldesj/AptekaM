
namespace Apteka
{
    partial class Form1
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
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.login_registerBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(412, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 25);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(111, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логін";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.Azure;
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(114, 221);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(237, 29);
            this.login_username.TabIndex = 3;
            this.login_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.Azure;
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(114, 307);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(237, 29);
            this.login_password.TabIndex = 5;
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(164, 349);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(137, 34);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Вхід";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Аптека вхід";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // login_registerBtn
            // 
            this.login_registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.login_registerBtn.FlatAppearance.BorderSize = 0;
            this.login_registerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.login_registerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.login_registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registerBtn.ForeColor = System.Drawing.Color.White;
            this.login_registerBtn.Location = new System.Drawing.Point(51, 514);
            this.login_registerBtn.Name = "login_registerBtn";
            this.login_registerBtn.Size = new System.Drawing.Size(355, 34);
            this.login_registerBtn.TabIndex = 10;
            this.login_registerBtn.Text = "Реєстрація";
            this.login_registerBtn.UseVisualStyleBackColor = false;
            this.login_registerBtn.Click += new System.EventHandler(this.login_registerBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Немає акаунту?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.BackColor = System.Drawing.Color.Azure;
            this.login_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_showPass.Location = new System.Drawing.Point(325, 315);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(15, 14);
            this.login_showPass.TabIndex = 12;
            this.login_showPass.UseVisualStyleBackColor = false;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Apteka.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(181, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 94);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(450, 580);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.login_registerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login_registerBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox login_showPass;
    }
}

