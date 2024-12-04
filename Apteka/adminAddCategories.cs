using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Apteka
{
    public partial class adminAddCategories : UserControl
    {
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "categories.json"); // Путь к JSON файлу

        public adminAddCategories()
        {
            InitializeComponent();
            displayCategoriesData();
        }

        // Метод для обновления данных
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategoriesData();
        }

        // Метод для отображения данных категорий
        public void displayCategoriesData()
        {
            List<adminAddCategoriesData> listData = LoadCategoriesFromJson();
            dataGridView1.DataSource = listData;
        }

        // Метод для загрузки данных из JSON
        public List<adminAddCategoriesData> LoadCategoriesFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                var json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<adminAddCategoriesData>>(json) ?? new List<adminAddCategoriesData>();
            }
            return new List<adminAddCategoriesData>();
        }

        // Метод для сохранения данных в JSON
        public void SaveCategoriesToJson(List<adminAddCategoriesData> categories)
        {
            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        // Метод для добавления новой категории
        private void addcategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addcategories_category.Text == "" || addcategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Заповніть поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<adminAddCategoriesData> categories = LoadCategoriesFromJson();

                // Создание нового объекта категории
                adminAddCategoriesData newCategory = new adminAddCategoriesData
                {
                    ID = categories.Count == 0 ? 1 : categories.Max(c => c.ID) + 1, // ID будет автоматически увеличиваться
                    Категорія = addcategories_category.Text.Trim(),
                    Статус = addcategories_status.SelectedItem.ToString(),
                    ДатаДодавання = DateTime.Today.ToString("yyyy-MM-dd")
                };

                categories.Add(newCategory);
                SaveCategoriesToJson(categories);

                clearFields();
                MessageBox.Show("Успішно додано!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayCategoriesData();
            }
        }

        // Метод для очищения полей
        public void clearFields()
        {
            addcategories_category.Text = "";
            addcategories_status.SelectedIndex = -1;
        }

        // Метод для очистки полей
        private void addcategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // Метод для обновления категории
        private void addcategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addcategories_category.Text == "" || addcategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, спочатку виберіть елемент", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Ви впевнені, що хочете оновити ID: " + getID + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<adminAddCategoriesData> categories = LoadCategoriesFromJson();

                    // Находим категорию по ID и обновляем ее
                    var categoryToUpdate = categories.FirstOrDefault(c => c.ID == getID);
                    if (categoryToUpdate != null)
                    {
                        categoryToUpdate.Категорія = addcategories_category.Text.Trim();
                        categoryToUpdate.Статус = addcategories_status.SelectedItem.ToString();
                        categoryToUpdate.ДатаДодавання = DateTime.Today.ToString("yyyy-MM-dd");

                        SaveCategoriesToJson(categories);
                        clearFields();
                        MessageBox.Show("Успішно оновлено!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayCategoriesData();
                    }
                }
            }
        }

        // Переменная для хранения ID выбранной категории
        private int getID = 0;

        // Метод для обработки клика по ячейке в DataGrid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                addcategories_category.Text = row.Cells[1].Value.ToString();
                addcategories_status.Text = row.Cells[2].Value.ToString();
            }
        }
        private void adminAddCategories_Load(object sender, EventArgs e)
        {
            // Ваш код здесь (например, инициализация данных на форме)
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Ваш код здесь (например, рисование на панели)
        }
        private void label5_Click(object sender, EventArgs e)
        {
            // Ваш код для обработки клика по label5
        }




        // Метод для удаления категории
        private void addcategories_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addcategories_category.Text == "" || addcategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, спочатку виберіть елемент", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити ID: " + getID + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<adminAddCategoriesData> categories = LoadCategoriesFromJson();

                    // Находим категорию по ID и удаляем ее
                    var categoryToDelete = categories.FirstOrDefault(c => c.ID == getID);
                    if (categoryToDelete != null)
                    {
                        categories.Remove(categoryToDelete);
                        SaveCategoriesToJson(categories);
                        clearFields();
                        MessageBox.Show("Успішно видалено!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayCategoriesData();
                    }
                }
            }
        }
    }
}
