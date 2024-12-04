using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Apteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Закриття програми
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Відображення/приховування пароля при зміні стану чекбоксу
        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        // Перехід на форму реєстрації
        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.Show();

            this.Hide();
        }

        // Метод для получения данных из JSON файла, расположенного рядом с .exe
        private string GetJsonFileContent(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (File.Exists(filePath))
            {
                // Чтение файла с использованием правильной кодировки
                return File.ReadAllText(filePath, System.Text.Encoding.UTF8);
            }
            else
            {
                throw new FileNotFoundException("JSON файл не найден.", fileName);
            }
        }

        // Подія при натисканні кнопки "Увійти"
        private void login_btn_Click(object sender, EventArgs e)
        {
            // Перевірка на порожні поля
            if (string.IsNullOrWhiteSpace(login_username.Text) || string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Порожні поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Чтение данных пользователей из файла JSON
                string jsonData = GetJsonFileContent("users.json");
                List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();

                // Поиск пользователя с введенными данными
                var user = users.FirstOrDefault(u =>
                    u.ім_користувача.Equals(login_username.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    u.пароль == login_password.Text.Trim() &&
                    u.статус.Equals("Активна", StringComparison.OrdinalIgnoreCase));

                if (user != null)
                {
                    MessageBox.Show("Вхід виконано успішно!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Переход в зависимости от роли
                    if (user.роль == "Адміністратор")
                    {
                        MainForm mForm = new MainForm();
                        mForm.Show();
                    }
                    else if (user.роль == "Фармацевт")
                    {
                        pharmacistMainForm cmForm = new pharmacistMainForm();
                        cmForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильне ім’я користувача/пароль або статус користувача не 'Активна'", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при роботі з файлом: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Класс для представления пользователя
        public class User
        {
            [JsonProperty("ID")]
            public int Id { get; set; }                  // ID користувача

            [JsonProperty("ІмяКористувача")]
            public string ім_користувача { get; set; }   // Ім'я користувача

            [JsonProperty("Пароль")]
            public string пароль { get; set; }           // Пароль

            [JsonProperty("Роль")]
            public string роль { get; set; }             // Роль

            [JsonProperty("Статус")]
            public string статус { get; set; }           // Статус

            [JsonProperty("ДатаРеєстрації")]
            public string дата_реєстрації { get; set; }  // Дата реєстрації
        }

    }
}
