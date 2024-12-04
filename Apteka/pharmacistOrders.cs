using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using Newtonsoft.Json;
using static Apteka.pharmacistOrdersData;

namespace Apteka
{
    public partial class pharmacistOrders : UserControl
    {
        private string ordersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orders.json");
        private string productsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.json");
        private string categoriesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "categories.json");
        private List<Order> orders;
        private List<Product> products;
        private List<Category> categories;
        private int getOrderID = 0;
        private int rowIndex = 0;

        public pharmacistOrders()
        {
            InitializeComponent();

            LoadData();
            displayCategories();
            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }

        private void LoadData()
        {
            orders = LoadOrders();
            products = LoadProducts();
            categories = LoadCategories();
        }

        private List<Order> LoadOrders()
        {
            if (File.Exists(ordersFilePath))
            {
                string json = File.ReadAllText(ordersFilePath);
                return JsonConvert.DeserializeObject<List<Order>>(json) ?? new List<Order>();
            }
            return new List<Order>();
        }

        private List<Product> LoadProducts()
        {
            if (File.Exists(productsFilePath))
            {
                string json = File.ReadAllText(productsFilePath);
                return JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
            }
            return new List<Product>();
        }

        private List<Category> LoadCategories()
        {
            if (File.Exists(categoriesFilePath))
            {
                string json = File.ReadAllText(categoriesFilePath);
                return JsonConvert.DeserializeObject<List<Category>>(json) ?? new List<Category>();
            }
            return new List<Category>();
        }

        private void SaveOrders()
        {
            string json = JsonConvert.SerializeObject(orders, Formatting.Indented);
            File.WriteAllText(ordersFilePath, json);
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            LoadData();
            displayCategories();
            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }

        public void displayAvailableProducts()
        {
            dataGridView1.DataSource = products.Where(p => p.Статус == "Активна").ToList();
            dataGridView1.Columns["НазваТовару"].HeaderText = "Назва Товару";
            dataGridView1.Columns["Категорія"].HeaderText = "Категорія";
            dataGridView1.Columns["Ціна"].HeaderText = "Ціна";
        }

        public void displayAllOrders()
        {
            var pendingOrders = orders.Where(o => o.статус == "Виконано").ToList();
            dataGridView2.DataSource = pendingOrders;
            dataGridView2.Columns["назва_товару"].HeaderText = "Назва Товару";
            dataGridView2.Columns["категорія"].HeaderText = "Категорія";
            dataGridView2.Columns["звичайна_ціна"].HeaderText = "Ціна";
            dataGridView2.Columns["кількість"].HeaderText = "Кількість";
        }

        public void displayCategories()
        {
            orders_category.Items.Clear();
            var activeCategories = categories.Select(c => c.Категорія).Distinct();
            foreach (var category in activeCategories)
            {
                orders_category.Items.Add(category);
            }
        }

        private void orders_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            orders_prodName.Text = "";
            orders_prodID.SelectedIndex = -1;
            orders_prodID.Items.Clear();
            orders_regPrice.Text = "";
            orders_quantity.Value = 0;

            string selectedValue = orders_category.SelectedItem as string;

            if (selectedValue != null)
            {
                var productIds = products.Where(p => p.Категорія == selectedValue && p.Статус == "Активна").Select(p => p.ІдентифікаторТовару);
                foreach (var productId in productIds)
                {
                    orders_prodID.Items.Add(productId);
                }
            }
        }

        private void orders_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = orders_prodID.SelectedItem as string;

            if (selectedValue != null)
            {
                var product = products.FirstOrDefault(p => p.ІдентифікаторТовару == selectedValue && p.Статус == "Активна");
                if (product != null)
                {
                    orders_prodName.Text = product.НазваТовару;
                    orders_regPrice.Text = product.Ціна.ToString();
                }
            }
        }

        private void orders_addBtn_Click(object sender, EventArgs e)
        {
            if (orders_category.SelectedIndex == -1 || orders_prodID.SelectedIndex == -1 || orders_prodName.Text == ""
                || orders_regPrice.Text == "" || orders_quantity.Value == 0)
            {
                MessageBox.Show("Пусті поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Order newOrder = new Order
                {
                    id = generateID(),
                    ідентифікатор_клієнта = 1,  // Пример ID клиента, должен быть динамическим
                    ідентифікатор_товару = orders_prodID.SelectedItem.ToString(),
                    назва_товару = orders_prodName.Text.Trim(),
                    категорія = orders_category.SelectedItem.ToString(),
                    звичайна_ціна = float.Parse(orders_regPrice.Text.Trim()),
                    кількість = (int)orders_quantity.Value,
                    статус = "Виконано",
                    дата_замовлення = DateTime.Today.ToString("dd-MM-yyyy")
                };

                orders.Add(newOrder);
                SaveOrders();

                MessageBox.Show("Успішно додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayAllOrders();
                displayTotal();
            }
        }

        public int generateID()
        {
            return orders.Count > 0 ? orders.Max(o => o.id) + 1 : 1;
        }

        public void displayTotal()
        {
            orders_totalPrice.Text = "$" + getTotal().ToString() + ".00";
        }

        public float getTotal()
        {
            return orders.Sum(o => o.звичайна_ціна * o.кількість);
        }

        public void clearFields()
        {
            orders_category.SelectedIndex = -1;
            orders_prodID.SelectedIndex = -1;
            orders_prodName.Text = "-----";
            orders_regPrice.Text = "-----";
            orders_quantity.Value = 0;
        }

        private void orders_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void orders_removeBtn_Click(object sender, EventArgs e)
        {
            if (getOrderID != 0)
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити замовлення з ID: " + getOrderID + "?",
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    orders.RemoveAll(o => o.id == getOrderID);
                    SaveOrders();

                    MessageBox.Show("Замовлення успішно видалено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть замовлення для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            displayAllOrders();
            displayTotal();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                getOrderID = row.Cells[0].Value != null ? Convert.ToInt32(row.Cells[0].Value) : 0;
            }
        }      

        private void orders_payBtn_Click(object sender, EventArgs e)
        {
            // Проверка, что количество заказов больше 0 и что поле с количеством не пустое
            if (orders_amount.Text == "" || dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Щось пішло не так", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Подтверждаем оплату
                if (MessageBox.Show("Ви впевнені, що хочете оплатити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Загружаем заказы из JSON
                        string ordersJson = File.ReadAllText("orders.json");
                        var ordersList = JsonConvert.DeserializeObject<List<Order>>(ordersJson);

                        // Обновляем статус всех текущих заказов клиента
                        foreach (var order in ordersList)
                        {
                            if (order.ідентифікатор_клієнта == generateID()) // Используй фактический ID клиента
                            {
                                order.статус = "Paid";  // Обновляем статус
                            }
                        }

                        // Сохраняем измененные заказы обратно в JSON
                        File.WriteAllText("orders.json", JsonConvert.SerializeObject(ordersList, Formatting.Indented));

                        // Создаем новую транзакцию
                        var newTransaction = new Transaction
                        {
                            ідентифікатор_клієнта = generateID(),
                            звичайна_ціна = getTotal(),  // Функция для расчета общей суммы
                            статус = "Виконано",
                            дата_транзакції = DateTime.Today.ToString("dd-MM-yyyy")
                        };

                        // Загружаем транзакции из JSON
                        string transactionsJson = File.ReadAllText("transactions.json");
                        var transactionsList = JsonConvert.DeserializeObject<List<Transaction>>(transactionsJson);

                        // Добавляем новую транзакцию в список
                        transactionsList.Add(newTransaction);

                        // Сохраняем обновленные транзакции в JSON
                        File.WriteAllText("transactions.json", JsonConvert.SerializeObject(transactionsList, Formatting.Indented));

                        MessageBox.Show("Транзакція успішно завершена!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Обновляем отображение заказов и общую сумму
                        displayAllOrders(); // Эта функция должна обновлять список заказов
                        displayTotal(); // Эта функция должна отображать общую стоимость
                        clearFields(); // Очистка полей ввода, если нужно
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при виконанні транзакції: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void orders_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int quantity = Convert.ToInt32(orders_quantity.Value);
                    if (quantity < 1)
                    {
                        MessageBox.Show("Кількість не може бути меншою за 1", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        orders_addBtn.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Введіть правильну кількість", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public class Product
        {
            public string ІдентифікаторТовару { get; set; }
            public string НазваТовару { get; set; }
            public string Категорія { get; set; }
            public float Ціна { get; set; }
            public int Запас { get; set; }
            public string Статус { get; set; }
            public string ДатаДодавання { get; set; }
        }
        public class Order
        {
            public int id { get; set; }
            public int ідентифікатор_клієнта { get; set; }
            public string ідентифікатор_товару { get; set; }
            public string назва_товару { get; set; }
            public string категорія { get; set; }
            public float звичайна_ціна { get; set; }
            public int кількість { get; set; }
            public string статус { get; set; }
            public string дата_замовлення { get; set; }
        }
        public class Transaction
        {
            public int id { get; set; }
            public int ідентифікатор_клієнта { get; set; }
            public string ідентифікатор_товару { get; set; }
            public float звичайна_ціна { get; set; }
            public string статус { get; set; }
            public string дата_транзакції { get; set; }
        }

        private void pharmacistOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
