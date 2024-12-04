
namespace Apteka
{
    partial class registerForm
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
            this.register_Btn = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.register_loginBtn = new System.Windows.Forms.Button();
            this.register_confirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // register_Btn
            // 
            this.register_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.register_Btn.FlatAppearance.BorderSize = 0;
            this.register_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.register_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.register_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Btn.ForeColor = System.Drawing.Color.Black;
            this.register_Btn.Location = new System.Drawing.Point(142, 391);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.Size = new System.Drawing.Size(175, 34);
            this.register_Btn.TabIndex = 19;
            this.register_Btn.Text = "Зареєструватися";
            this.register_Btn.UseVisualStyleBackColor = false;
            this.register_Btn.Click += new System.EventHandler(this.register_Btn_Click);
            // 
            // register_password
            // 
            this.register_password.BackColor = System.Drawing.Color.Azure;
            this.register_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(114, 282);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(237, 29);
            this.register_password.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Пароль";
            // 
            // register_username
            // 
            this.register_username.BackColor = System.Drawing.Color.Azure;
            this.register_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(114, 221);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(237, 29);
            this.register_username.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Логін";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(412, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 25);
            this.close.TabIndex = 14;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Apteka.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(181, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 96);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.BackColor = System.Drawing.Color.Azure;
            this.register_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPass.Location = new System.Drawing.Point(327, 291);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(15, 14);
            this.register_showPass.TabIndex = 24;
            this.register_showPass.UseVisualStyleBackColor = false;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Вже є акаунт?";
            // 
            // register_loginBtn
            // 
            this.register_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.register_loginBtn.FlatAppearance.BorderSize = 0;
            this.register_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.register_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(130)))), ((int)(((byte)(202)))));
            this.register_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginBtn.ForeColor = System.Drawing.Color.White;
            this.register_loginBtn.Location = new System.Drawing.Point(51, 514);
            this.register_loginBtn.Name = "register_loginBtn";
            this.register_loginBtn.Size = new System.Drawing.Size(355, 34);
            this.register_loginBtn.TabIndex = 22;
            this.register_loginBtn.Text = "Вхід";
            this.register_loginBtn.UseVisualStyleBackColor = false;
            this.register_loginBtn.Click += new System.EventHandler(this.register_loginBtn_Click);
            // 
            // register_confirmPassword
            // 
            this.register_confirmPassword.BackColor = System.Drawing.Color.Azure;
            this.register_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_confirmPassword.Location = new System.Drawing.Point(114, 349);
            this.register_confirmPassword.Name = "register_confirmPassword";
            this.register_confirmPassword.PasswordChar = '*';
            this.register_confirmPassword.Size = new System.Drawing.Size(237, 29);
            this.register_confirmPassword.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введіть пароль ще раз";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 33);
            this.label5.TabIndex = 27;
            this.label5.Text = "Аптека реєстрація";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(450, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_confirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_Btn);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register_loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.registerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_Btn;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button register_loginBtn;
        private System.Windows.Forms.TextBox register_confirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}