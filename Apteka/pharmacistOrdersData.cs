using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Apteka
{
    class pharmacistOrdersData
    {
        // Путь к файлу JSON, который будет лежать рядом с EXE
        string ordersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orders.json");

        public int ID { set; get; }
        public int ідентифікатор_клієнта { set; get; }
        public string ідентифікатор_товару { set; get; }
        public string назва_товару { set; get; }
        public string категорія { set; get; }
        public string звичайна_ціна { set; get; }
        public string кількість { set; get; }

        public List<pharmacistOrdersData> pharmacistOrdersList()
        {
            List<pharmacistOrdersData> listData = new List<pharmacistOrdersData>();

            // Загрузка всех заказов из файла JSON
            List<Order> orders = LoadOrders();

            // Получение максимального ID клиента
            int maxClientId = orders.Max(o => o.ідентифікатор_клієнта);

            // Фильтрация заказов по максимальному ID клиента
            var filteredOrders = orders.Where(o => o.ідентифікатор_клієнта == maxClientId).ToList();

            // Преобразование заказов в нужный формат
            foreach (var order in filteredOrders)
            {
                pharmacistOrdersData orderData = new pharmacistOrdersData
                {
                    ID = order.ID,
                    ідентифікатор_клієнта = order.ідентифікатор_клієнта,
                    ідентифікатор_товару = order.ідентифікатор_товару,
                    назва_товару = order.назва_товару,
                    категорія = order.категорія,
                    звичайна_ціна = order.звичайна_ціна,
                    кількість = order.кількість
                };
                listData.Add(orderData);
            }

            return listData;
        }

        // Метод для загрузки всех заказов из файла JSON
        private List<Order> LoadOrders()
        {
            // Проверяем, существует ли файл с заказами
            if (!File.Exists(ordersFilePath))
            {
                return new List<Order>(); // Возвращаем пустой список, если файл не существует
            }

            // Чтение содержимого файла
            string json = File.ReadAllText(ordersFilePath);
            return JsonConvert.DeserializeObject<List<Order>>(json); // Десериализация в список объектов
        }

        // Метод для сохранения заказов в файл JSON
        public void SaveOrders(List<Order> orders)
        {
            // Сериализация списка заказов в JSON
            string json = JsonConvert.SerializeObject(orders, Formatting.Indented);
            // Запись данных в файл
            File.WriteAllText(ordersFilePath, json);
        }

        // Класс для представления данных заказа
        public class Order
        {
            public int ID { set; get; }
            public int ідентифікатор_клієнта { set; get; }
            public string ідентифікатор_товару { set; get; }
            public string назва_товару { set; get; }
            public string категорія { set; get; }
            public string звичайна_ціна { set; get; }
            public string кількість { set; get; }
        }
    }
}
