using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Apteka
{
    public partial class adminDashboard : UserControl
    {
        // Пути к файлам JSON
        private readonly string transactionsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "transactions.json");
        private readonly string usersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        public adminDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                displayTotalPharmacist();
                displayTotalOrders();
                displayTodaysRevenue();
                displayTotalRevenue();
                displayCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            LoadData();
        }

        // Відображення списку клієнтів
        public void displayCustomers()
        {
            try
            {
                List<User> users = LoadUsersData();
                var userData = users.Select(u => new
                {
                    u.ID,
                    u.ІмяКористувача,
                    u.Роль,
                    u.Статус,                    
                }).ToList();

                dataGridView1.DataSource = userData; // dataGridView1 - убедитесь в правильности имени
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отображения пользователей: {ex.Message}");
            }
        }

        // Загальна кількість фармацевтів
        public void displayTotalPharmacist()
        {
            try
            {
                List<User> users = LoadUsersData();
                int totalPharmacists = users.Count(u => u.Роль == "Фармацевт");
                totalPharmacist.Text = totalPharmacists.ToString(); // totalPharmacist - убедитесь в правильности имени
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отображения фармацевтов: {ex.Message}");
            }
        }

        // Загальна кількість замовлень
        public void displayTotalOrders()
        {
            try
            {
                List<Transaction> transactions = LoadTransactionsData();
                totalOrders.Text = transactions.Count.ToString(); // totalOrders - убедитесь в правильности имени
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отображения заказов: {ex.Message}");
            }
        }

        // Дохід за сьогодні
        public void displayTodaysRevenue()
        {
            try
            {
                DateTime today = DateTime.Today;
                List<Transaction> transactions = LoadTransactionsData();

                var todaysRevenue = transactions
                    .Where(t => DateTime.TryParseExact(t.дата_транзакції, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date) && date == today)
                    .Sum(t => t.загальна_ціна);

                todayRevenue.Text = todaysRevenue.ToString("C", System.Globalization.CultureInfo.CurrentCulture); // todayRevenue - убедитесь в правильности имени
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отображения сегодняшнего дохода: {ex.Message}");
            }
        }

        // Загальний дохід
        public void displayTotalRevenue()
        {
            try
            {
                // Загружаем данные из JSON
                List<Transaction> transactions = LoadTransactionsData();

                // Проверяем, есть ли транзакции
                if (transactions == null || !transactions.Any())
                {
                    totalRevenue.Text = "0.00";
                    return;
                }

                // Вычисляем сумму дохода
                var totalRevenueValue = transactions
                    .Where(t => t.загальна_ціна > 0) // Исключаем некорректные данные
                    .Sum(t => t.загальна_ціна);

                // Устанавливаем результат в элемент интерфейса
                totalRevenue.Text = totalRevenueValue.ToString("C", System.Globalization.CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                // Отображаем сообщение об ошибке
                MessageBox.Show($"Ошибка отображения общего дохода: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Метод для загрузки данных пользователей из JSON
        private List<User> LoadUsersData()
        {
            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);
                return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            return new List<User>();
        }

        // Метод для загрузки данных транзакций из JSON
        private List<Transaction> LoadTransactionsData()
        {
            if (File.Exists(transactionsFilePath))
            {
                string json = File.ReadAllText(transactionsFilePath);
                return JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
            }
            return new List<Transaction>();
        }
    }
}
