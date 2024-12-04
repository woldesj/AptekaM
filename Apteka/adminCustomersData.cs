using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Apteka
{
    class adminCustomersData
    {
        // Путь к JSON файлу с транзакциями
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "transactions.json");

        public int Ідентифікатор { set; get; }  // ID
        public int Ідентифікатор_Клієнта { set; get; }  // CustomerID
        public string Загальна_Ціна { set; get; }  // TotalPrice
        public string Статус { set; get; }  // Status
        public string Дата_Транзакції { set; get; }  // DateTransaction

        // Метод для загрузки данных транзакций из JSON
        public List<adminCustomersData> customersDataList()
        {
            List<adminCustomersData> listData = new List<adminCustomersData>();

            if (File.Exists(jsonFilePath))
            {
                // Чтение данных из файла JSON
                var json = File.ReadAllText(jsonFilePath);
                listData = JsonConvert.DeserializeObject<List<adminCustomersData>>(json) ?? new List<adminCustomersData>();
            }

            return listData;
        }

        // Метод для сохранения данных транзакций в JSON
        public void SaveTransactionsToJson(List<adminCustomersData> transactions)
        {
            var json = JsonConvert.SerializeObject(transactions, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        // Пример добавления новой транзакции
        public void AddTransaction(adminCustomersData newTransaction)
        {
            List<adminCustomersData> transactions = customersDataList();
            transactions.Add(newTransaction);
            SaveTransactionsToJson(transactions);
        }

        // Пример обновления транзакции
        public void UpdateTransaction(int id, adminCustomersData updatedTransaction)
        {
            List<adminCustomersData> transactions = customersDataList();
            var transaction = transactions.Find(t => t.Ідентифікатор == id);
            if (transaction != null)
            {
                transaction.Ідентифікатор_Клієнта = updatedTransaction.Ідентифікатор_Клієнта;
                transaction.Загальна_Ціна = updatedTransaction.Загальна_Ціна;
                transaction.Статус = updatedTransaction.Статус;
                transaction.Дата_Транзакції = updatedTransaction.Дата_Транзакції;
                SaveTransactionsToJson(transactions);
            }
        }

        // Пример удаления транзакции
        public void DeleteTransaction(int id)
        {
            List<adminCustomersData> transactions = customersDataList();
            var transaction = transactions.Find(t => t.Ідентифікатор == id);
            if (transaction != null)
            {
                transactions.Remove(transaction);
                SaveTransactionsToJson(transactions);
            }
        }
    }

    // Класс для десериализации данных транзакции
    public class Transaction
    {
        public int id { get; set; }
        public int ідентифікатор_клієнта { get; set; }
        public string ідентифікатор_товару { get; set; }
        public decimal загальна_ціна { get; set; }
        public string статус { get; set; }
        public string дата_транзакції { get; set; }
    }
}
