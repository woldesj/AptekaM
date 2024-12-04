using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace Apteka
{
    public partial class pharmacistOrders : UserControl
    {
        string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "aptekasqll.mdf")};Integrated Security=True;Connect Timeout=30;";

        public pharmacistOrders()
        {
            InitializeComponent();

            displayCategories();
            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategories();
            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }

        public void displayAvailableProducts()
        {
            adminAddProductsData prodData = new adminAddProductsData();
            dataGridView1.DataSource = prodData.addProductsList();
        }

        public void displayAllOrders()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT * FROM orders WHERE статус = 'Pending' AND ідентифікатор_клієнта = @cid";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@cid", generateID());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView2.DataSource = table;
                }
            }
        }


        public void displayCategories()
        {
            // Спочатку очищаємо список, що випадає
            orders_category.Items.Clear();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string selectData = "SELECT DISTINCT категорія FROM categories WHERE статус = 'Активна'"; // Використовуємо DISTINCT, щоб уникнути дублювання категорій

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string category = reader["категорія"].ToString();
                        orders_category.Items.Add(category); // Додаємо категорію в список, що випадає
                    }
                }
            }
        }


        private void orders_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очищення значень
            orders_prodName.Text = "";
            orders_prodID.SelectedIndex = -1;
            orders_prodID.Items.Clear();
            orders_regPrice.Text = "";
            orders_quantity.Value = 0;

            // Отримуємо обрану категорію
            string selectedValue = orders_category.SelectedItem as string;

            if (selectedValue != null)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Отримуємо товари, що належать до обраної категорії
                    string selectData = "SELECT ідентифікатор_товару FROM products WHERE категорія = @category AND статус = 'Активна'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Заповнюємо список, що випадає, з товарами
                            while (reader.Read())
                            {
                                string productId = reader["ідентифікатор_товару"].ToString();
                                orders_prodID.Items.Add(productId);
                            }
                        }
                    }
                }
            }
        }

        private void orders_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримуємо ID обраного товару
            string selectedValue = orders_prodID.SelectedItem as string;

            if (selectedValue != null)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Отримуємо дані товару за ID
                    string selectData = "SELECT назва_товару, ціна FROM products WHERE ідентифікатор_товару = @pID AND статус = 'Активна'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@pID", selectedValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Якщо товар знайдений, заповнюємо поля
                            if (reader.Read())
                            {
                                string prodName = reader["назва_товару"].ToString();
                                string prodPrice = reader["ціна"].ToString();

                                orders_prodName.Text = prodName;
                                orders_regPrice.Text = prodPrice;
                            }
                        }
                    }
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
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string insertData = "INSERT INTO orders (ідентифікатор_клієнта, ідентифікатор_товару, назва_товару, категорія, звичайна_ціна, кількість, статус, дата_замовлення)" +
                        " VALUES(@cid, @pID, @prodName, @cat, @regPrice, @qty, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cid", generateID());
                        cmd.Parameters.AddWithValue("@pID", orders_prodID.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@prodName", orders_prodName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", orders_category.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@regPrice", orders_regPrice.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", orders_quantity.Value);
                        cmd.Parameters.AddWithValue("@status", "Pending");
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Успішно додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            displayAllOrders();
            displayTotal();
        }

        public int generateID()
        {
            int getID = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT MAX(id) as getID FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["getID"] != DBNull.Value)
                            {
                                getID = Convert.ToInt32(reader["getID"]);
                            }

                            if (getID == 0)
                            {
                                getID = 1;
                            }
                        }
                    }
                }
            }

            if (getID == 0)
            {
                return 1;
            }
            else
            {
                return getID += 1;
            }
        }

        public void displayTotal()
        {
            orders_totalPrice.Text = "$" + getTotal().ToString() + ".00";
        }

        public float getTotal()
        {
            float totalPrice = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT звичайна_ціна as price, кількість as qty FROM orders WHERE ідентифікатор_клієнта = " + generateID();

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("price")) && !reader.IsDBNull(reader.GetOrdinal("qty")))
                            {
                                float price;
                                int qty;
                                if (float.TryParse(reader["price"].ToString(), out price)
                                    && int.TryParse(reader["qty"].ToString(), out qty))
                                {
                                    totalPrice += price * qty;
                                }
                            }
                        }
                    }
                }
            }
            return totalPrice;
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

        private void orders_amount_TextChanged(object sender, EventArgs e)
        {

        }
        // Оголошення змінної getOrderID в області класу
        private int getOrderID = 0; // Змінна для зберігання ID обраного замовлення

        private void orders_removeBtn_Click(object sender, EventArgs e)
        {
            if (getOrderID != 0) // Перевіряємо, що вибрано замовлення
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити замовлення з ID: " + getOrderID + "?",
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        // Рядок для видалення замовлення з таблиці orders за ідентифікатором
                        string deleteData = "DELETE FROM orders WHERE id = @orderID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            // Додаємо параметр для безпечного виконання запиту
                            cmd.Parameters.AddWithValue("@orderID", getOrderID);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Замовлення успішно видалено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть замовлення для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Оновлюємо відображення даних після видалення
            displayAllOrders();
            displayTotal();
        }

        // Обробник вибору рядка в DataGridView
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // Перевіряємо, що клікнули по рядку
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                // Припускаємо, що ID замовлення знаходиться в першому стовпці
                getOrderID = row.Cells[0].Value != null ? Convert.ToInt32(row.Cells[0].Value) : 0;
            }
        }



        private void orders_receiptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Від'єднання попередніх обробників подій
                printDocument1.PrintPage -= printDocument1_PrintPage;
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.BeginPrint -= printDocument1_BeginPrint;
                printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

                // Закриття попередньо відкритого діалогового вікна
                if (printPreviewDialog1 != null && printPreviewDialog1.Visible)
                {
                    printPreviewDialog1.Close(); // Закриваємо діалогове вікно, якщо воно відкрите
                }

                // Ініціалізація нового діалогового вікна попереднього перегляду
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument1 // Призначення документа
                };

                previewDialog.ShowDialog(); // Відображення попереднього перегляду
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float totalPrice = getTotal();

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Аптека";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (dataGridView2.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "ID", "Iд клієнта", "Ід товару", "Назва товару", "Категорія", "Кількість", "Ціна" };

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }

            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                int labelMargin = (int)Math.Min(rSpace, 200);

                DateTime today = DateTime.Now;

                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-----------------------------", labelFont).Width;

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Загальна ціна: \t$" + totalPrice + "\nВнесена сума: \t$"
                    + orders_amount.Text + "\n\t\t-----------\nРешта: \t$" + orders_change.Text, labelFont, Brushes.Black, labelX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();
                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right
                    - e.Graphics.MeasureString("-----------------------------", labelFont).Width, y);
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void pharmacistOrders_Load(object sender, EventArgs e)
        {

        }



        private void orders_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(orders_amount.Text);
                    float getChange = (getAmount - getTotal());

                    if (getChange <= -1)
                    {
                        orders_amount.Text = "";
                        orders_change.Text = "";
                    }
                    else
                    {
                        orders_change.Text = getChange.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не правильно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orders_amount.Text = "";
                    orders_change.Text = "";
                }
            }
        }

        private void orders_payBtn_Click(object sender, EventArgs e)
        {
            if (orders_amount.Text == "" || dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Щось пішло не так", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Ви впевнені, що хочете оплатити?", "Підтвердження"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        // Оновлення статусу всіх поточних замовлень клієнта
                        string updateOrders = "UPDATE orders SET статус = @status WHERE ідентифікатор_клієнта = @cid";

                        using (SqlCommand cmd = new SqlCommand(updateOrders, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Paid");
                            cmd.Parameters.AddWithValue("@cid", generateID());
                            cmd.ExecuteNonQuery();
                        }

                        // Додавання запису в таблицю транзакцій
                        string insertData = "INSERT INTO transactions (ідентифікатор_клієнта, загальна_ціна, статус, дата_транзакції)" +
                        " VALUES(@cid, @totalPrice, @status, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cid", generateID());
                            cmd.Parameters.AddWithValue("@totalPrice", getTotal());
                            cmd.Parameters.AddWithValue("@status", "Виконано");
                            cmd.Parameters.AddWithValue("@date", DateTime.Today);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Транзакція успішно завершена!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Оновлюємо відображення замовлень
                    displayAllOrders();
                    displayTotal();
                    clearFields();
                }
            }
        }

       

        private void orders_change_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

    }
}
