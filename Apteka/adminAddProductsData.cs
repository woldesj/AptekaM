using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Apteka
{
    public class adminAddProductsData // Сделать класс public
    {
        // Путь к JSON файлу
        private string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.json");

        // Свойства
        public int ID { set; get; }
        public string ІдентифікаторТовару { set; get; } // Ідентифікатор товару
        public string НазваТовару { set; get; } // Назва товару
        public string Категорія { set; get; } // Категорія товару
        public string Ціна { set; get; } // Ціна товару
        public string Запас { set; get; } // Запас товару        
        public string Статус { set; get; } // Статус товару
        public string ДатаДодавання { set; get; } // Дата додавання товару

        // Метод для загрузки товаров из JSON
        public List<adminAddProductsData> LoadProductsFromJson() // Сделать метод public
        {
            // Проверка на существование файла
            if (File.Exists(jsonFilePath))
            {
                var json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<adminAddProductsData>>(json) ?? new List<adminAddProductsData>();
            }

            return new List<adminAddProductsData>(); // Если файла нет, возвращаем пустой список
        }

        // Метод для сохранения товаров в JSON
        public void SaveProductsToJson(List<adminAddProductsData> products) // Сделать метод public
        {
            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        // Метод для получения всех товаров
        public List<adminAddProductsData> addProductsList() // Сделать метод public
        {
            return LoadProductsFromJson();
        }

        // Метод для добавления нового товара
        public void AddProduct(int id, string identifier, string name, string category, string price, string stock, string status, string dateAdded)
        {
            List<adminAddProductsData> products = LoadProductsFromJson();

            // Проверка на уникальность товара по идентификатору
            if (products.Exists(p => p.ІдентифікаторТовару == identifier))
            {
                Console.WriteLine($"Товар с идентификатором {identifier} уже существует");
                return;
            }

            var newProduct = new adminAddProductsData
            {
                ID = id,
                ІдентифікаторТовару = identifier,
                НазваТовару = name,
                Категорія = category,
                Ціна = price,
                Запас = stock,
                Статус = status,
                ДатаДодавання = dateAdded
            };

            products.Add(newProduct);
            SaveProductsToJson(products);
            Console.WriteLine("Товар успешно добавлен!");
        }

        // Метод для обновления товара
        public void UpdateProduct(int id, string identifier, string name, string category, string price, string stock, string status, string dateAdded)
        {
            List<adminAddProductsData> products = LoadProductsFromJson();

            var productToUpdate = products.Find(p => p.ID == id);
            if (productToUpdate != null)
            {
                productToUpdate.ІдентифікаторТовару = identifier;
                productToUpdate.НазваТовару = name;
                productToUpdate.Категорія = category;
                productToUpdate.Ціна = price;
                productToUpdate.Запас = stock;
                productToUpdate.Статус = status;
                productToUpdate.ДатаДодавання = dateAdded;

                SaveProductsToJson(products);
                Console.WriteLine("Товар успешно обновлен!");
            }
        }

        // Метод для удаления товара
        public void DeleteProduct(int id)
        {
            List<adminAddProductsData> products = LoadProductsFromJson();

            var productToDelete = products.Find(p => p.ID == id);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
                SaveProductsToJson(products);
                Console.WriteLine("Товар успешно удален!");
            }
        }
    }
}
