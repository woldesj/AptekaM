using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Apteka
{
    public partial class adminAddProducts : UserControl
    {
        // Путь к JSON файлу с продуктами
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.json");

        public adminAddProducts()
        {
            InitializeComponent();
            displayCategories();
            displayProducts();
        }

        // Метод для обновления данных
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategories();
            displayProducts();
        }

        // Метод для отображения продуктов
        public void displayProducts()
        {
            adminAddProductsData aapData = new adminAddProductsData();
            List<adminAddProductsData> listData = aapData.addProductsList();

            dataGridView1.DataSource = listData;
        }

        // Метод для отображения категорий
        public void displayCategories()
        {
            addProducts_category.Items.Clear();

            // Путь к файлу с категориями
            string categoriesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "categories.json");

            if (File.Exists(categoriesFilePath))
            {
                // Чтение данных из файла JSON
                var json = File.ReadAllText(categoriesFilePath);
                var categories = JsonConvert.DeserializeObject<List<Category>>(json);

                if (categories != null)
                {
                    foreach (var category in categories)
                    {
                        // Добавление категорий в ComboBox
                        addProducts_category.Items.Add(category.Категорія);
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить категории из файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл с категориями не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод добавления продукта
        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_productName.Text == "" || addProducts_category.SelectedIndex == -1
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1)
            {
                MessageBox.Show("Пусті поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<adminAddProductsData> products = LoadProductsFromJson();

                // Проверка на уникальность идентификатора товара
                if (products.Any(p => p.ІдентифікаторТовару == addProducts_prodID.Text.Trim()))
                {
                    MessageBox.Show(addProducts_prodID.Text.Trim() + " вже зайнято", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var newProduct = new adminAddProductsData
                    {
                        ІдентифікаторТовару = addProducts_prodID.Text.Trim(),
                        НазваТовару = addProducts_productName.Text.Trim(),
                        Категорія = addProducts_category.SelectedItem.ToString(),
                        Ціна = addProducts_price.Text.Trim(),
                        Запас = addProducts_stock.Text.Trim(),
                        Статус = addProducts_status.SelectedItem.ToString(),
                        ДатаДодавання = DateTime.Today.ToString("dd-MM-yyyy")
                    };

                    products.Add(newProduct);
                    SaveProductsToJson(products);
                    clearFields();
                    MessageBox.Show("Успішно додано!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            displayProducts();
        }

        // Метод для очистки полей
        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_productName.Text = "";
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_status.SelectedIndex = -1;
        }

        // Переменная для хранения ID выбранного продукта
        private int getID = 0;

        // Метод для выбора продукта в таблице
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_productName.Text = row.Cells[2].Value.ToString();
                addProducts_category.SelectedItem = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();
                addProducts_status.SelectedItem = row.Cells[6].Value.ToString();
            }
        }

        // Метод для очистки полей
        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // Метод для обновления данных продукта
        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_productName.Text == "" || addProducts_category.SelectedIndex == -1
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1)
            {
                MessageBox.Show("Пусті поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<adminAddProductsData> products = LoadProductsFromJson();

                var productToUpdate = products.FirstOrDefault(p => p.ID == getID);
                if (productToUpdate != null)
                {
                    if (MessageBox.Show("Ви впевнені, що хочете оновити ID: " + getID + "?", "Підтвердження",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        productToUpdate.ІдентифікаторТовару = addProducts_prodID.Text.Trim();
                        productToUpdate.НазваТовару = addProducts_productName.Text.Trim();
                        productToUpdate.Категорія = addProducts_category.SelectedItem.ToString();
                        productToUpdate.Ціна = addProducts_price.Text.Trim();
                        productToUpdate.Запас = addProducts_stock.Text.Trim();
                        productToUpdate.Статус = addProducts_status.SelectedItem.ToString();
                        productToUpdate.ДатаДодавання = DateTime.Today.ToString("dd-MM-yyyy");

                        SaveProductsToJson(products);
                        clearFields();
                        MessageBox.Show("Успішно оновлено!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            displayProducts();
        }

        // Метод для удаления продукта
        private void addProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити продукт з ID: " + getID + "?", "Підтвердження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<adminAddProductsData> products = LoadProductsFromJson();

                var productToDelete = products.FirstOrDefault(p => p.ID == getID);
                if (productToDelete != null)
                {
                    products.Remove(productToDelete);
                    SaveProductsToJson(products);
                    MessageBox.Show("Видалено!", "Інформаційне повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            displayProducts();
        }

        // Загрузка продуктов из JSON
        public List<adminAddProductsData> LoadProductsFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                var json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<adminAddProductsData>>(json) ?? new List<adminAddProductsData>();
            }
            return new List<adminAddProductsData>();
        }

        // Сохранение продуктов в JSON
        public void SaveProductsToJson(List<adminAddProductsData> products)
        {
            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        private void adminAddProducts_Load(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }

    // Класс для десериализации категорий
    public class Category
    {
        public int ID { get; set; }
        public string Категорія { get; set; }
        public string Статус { get; set; }
        public string ДатаДодавання { get; set; }
    }
}
