using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Apteka
{
    class PharmacistAvailableProducts
    {
        private readonly string productsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.json");

        public int ID { get; set; } // 0
        public string ІдентифікаторТовару { get; set; } // 1
        public string НазваТовару { get; set; } // 2
        public string Категорія { get; set; } // 3
        public decimal Ціна { get; set; } // 4
        public int Запас { get; set; } // 5

        public List<PharmacistAvailableProducts> AvailableProductsList()
        {
            try
            {
                // Загружаем данные из файла JSON
                if (!File.Exists(productsFilePath))
                {
                    throw new FileNotFoundException("Файл с продуктами не найден.");
                }

                string json = File.ReadAllText(productsFilePath);
                var products = JsonConvert.DeserializeObject<List<PharmacistAvailableProducts>>(json) ?? new List<PharmacistAvailableProducts>();

                // Фильтруем продукты со статусом "Активна"
                var activeProducts = products.Where(p => p.Запас > 0).ToList();

                return activeProducts;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке доступных продуктов: {ex.Message}");
            }
        }
    }
}
