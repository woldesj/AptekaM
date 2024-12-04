using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Apteka
{
    public partial class registerForm : Form
    {
        // Путь к встраиваемому JSON файлу
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        public registerForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_confirmPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_Btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_confirmPassword.Text == "")
            {
                MessageBox.Show("Заповніть всі поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Загружаем данные из JSON
                var users = LoadUsersFromJson();

                // Проверяем, существует ли пользователь
                var existingUser = users.FirstOrDefault(u => u.ІмяКористувача == register_username.Text.Trim());
                if (existingUser != null)
                {
                    string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                    MessageBox.Show(tempUsern + " Користувач з таким ім'яв вже існує", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (register_password.Text.Length < 8)
                {
                    MessageBox.Show("Пароль повинен бути не менше 8 символів", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (register_password.Text != register_confirmPassword.Text)
                {
                    MessageBox.Show("Паролі не співпадають", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Добавляем нового пользователя в список
                    var newUser = new User
                    {
                        ID = users.Count + 1,
                        ІмяКористувача = register_username.Text.Trim(),
                        Пароль = register_password.Text.Trim(),
                        Роль = "Фармацевт",
                        Статус = "Очікує затвердження",
                        ДатаРеєстрації = DateTime.Today.ToString("dd-MM-yyyy")
                    };

                    users.Add(newUser);

                    // Сохраняем обновленный список пользователей в JSON
                    SaveUsersToJson(users);

                    MessageBox.Show("Успішна реєстрація!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Открываем форму логина
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        // Метод для загрузки пользователей из JSON
        private List<User> LoadUsersFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                var json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            return new List<User>(); // Если файл не существует, возвращаем пустой список
        }

        // Метод для сохранения пользователей в JSON
        private void SaveUsersToJson(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }

    // Класс пользователя, соответствующий структуре JSON
    public class User
    {
        [JsonProperty("ID")]
        public int ID { get; set; }                  // ID користувача

        [JsonProperty("ІмяКористувача")]
        public string ІмяКористувача { get; set; }   // Ім'я користувача

        [JsonProperty("Пароль")]
        public string Пароль { get; set; }           // Пароль

        [JsonProperty("Роль")]
        public string Роль { get; set; }             // Роль

        [JsonProperty("Статус")]
        public string Статус { get; set; }           // Статус

        [JsonProperty("ДатаРеєстрації")]
        public string ДатаРеєстрації { get; set; }   // Дата реєстрації
    }
}
