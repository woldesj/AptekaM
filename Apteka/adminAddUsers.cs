using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Apteka
{
    public partial class adminAddUsers : UserControl
    {
        // Путь к JSON файлу рядом с .exe
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        public adminAddUsers()
        {
            InitializeComponent();
            displayAddUsers();
        }

        // Метод для загрузки пользователей из JSON
        private List<AdminAddUsersData> LoadUsersFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                var json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<AdminAddUsersData>>(json) ?? new List<AdminAddUsersData>();
            }
            return new List<AdminAddUsersData>(); // Если файл не существует, возвращаем пустой список
        }

        // Метод для сохранения пользователей в JSON
        private void SaveUsersToJson(List<AdminAddUsersData> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAddUsers();
        }

        public void displayAddUsers()
        {
            List<AdminAddUsersData> listData = LoadUsersFromJson();
            dataGridView1.DataSource = listData;
        }

        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1
                || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Пусті поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<AdminAddUsersData> users = LoadUsersFromJson();

                // Проверяем уникальность имени пользователя
                if (users.Exists(u => u.ІмяКористувача == addUsers_username.Text.Trim()))
                {
                    MessageBox.Show($"{addUsers_username.Text} вже існує", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Генерация уникального ID для нового пользователя
                int newUserID = GetNextUserID(users);

                // Добавляем нового пользователя
                var newUser = new AdminAddUsersData
                {
                    ID = newUserID,
                    ІмяКористувача = addUsers_username.Text.Trim(),
                    Пароль = addUsers_password.Text.Trim(),
                    Роль = addUsers_role.SelectedItem.ToString(),
                    Статус = addUsers_status.SelectedItem.ToString(),
                    ДатаРеєстрації = DateTime.Now.ToString("dd-MM-yyyy")
                };

                users.Add(newUser);

                // Сохраняем обновленный список пользователей в JSON
                SaveUsersToJson(users);

                MessageBox.Show("Успішно додано!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
                displayAddUsers();
            }
        }

        // Метод для получения следующего уникального ID
        private int GetNextUserID(List<AdminAddUsersData> users)
        {
            if (users.Count == 0)
                return 1; // Если пользователей нет, начинаем с ID = 1

            return users.Max(u => u.ID) + 1; // Возвращаем максимальный ID + 1
        }

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1
                || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, виберіть елемент", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<AdminAddUsersData> users = LoadUsersFromJson();

                var userToUpdate = users.Find(u => u.ID == getID);
                if (userToUpdate != null)
                {
                    userToUpdate.ІмяКористувача = addUsers_username.Text.Trim();
                    userToUpdate.Пароль = addUsers_password.Text.Trim();
                    userToUpdate.Роль = addUsers_role.SelectedItem.ToString();
                    userToUpdate.Статус = addUsers_status.SelectedItem.ToString();

                    // Сохраняем обновленный список пользователей в JSON
                    SaveUsersToJson(users);

                    MessageBox.Show("Успішно оновлено!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    displayAddUsers();
                }
            }
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUsers_password.Text = row.Cells[2].Value.ToString();
                addUsers_role.SelectedItem = row.Cells[3].Value.ToString();
                addUsers_status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        public void addUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            List<AdminAddUsersData> users = LoadUsersFromJson();

            var userToDelete = users.Find(u => u.ID == getID);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);

                // Сохраняем обновленный список пользователей в JSON
                SaveUsersToJson(users);

                MessageBox.Show("Успішно видалено!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
                displayAddUsers();
            }
        }

        private void adminAddUsers_Load(object sender, EventArgs e)
        {
            displayAddUsers();
        }
    }

    // Класс данных для пользователей
    public class AdminAddUsersData
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("ІмяКористувача")]
        public string ІмяКористувача { get; set; }

        [JsonProperty("Пароль")]
        public string Пароль { get; set; }

        [JsonProperty("Роль")]
        public string Роль { get; set; }

        [JsonProperty("Статус")]
        public string Статус { get; set; }

        [JsonProperty("ДатаРеєстрації")]
        public string ДатаРеєстрації { get; set; }
    }
}
