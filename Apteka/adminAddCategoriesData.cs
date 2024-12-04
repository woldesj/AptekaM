using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Apteka
{
    public class adminAddCategoriesData // Сделано public
    {
        // Путь к JSON файлу
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "categories.json");

        public int ID { set; get; } // ID
        public string Категорія { set; get; } // Категорія
        public string Статус { set; get; } // Статус
        public string ДатаДодавання { set; get; } // Дата додавання

        // Метод для загрузки данных категорий из JSON
        public List<adminAddCategoriesData> LoadCategoriesFromJson()
        {
            // Проверка на существование файла
            if (File.Exists(jsonFilePath))
            {
                var json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<adminAddCategoriesData>>(json) ?? new List<adminAddCategoriesData>();
            }

            return new List<adminAddCategoriesData>(); // Если файла нет, возвращаем пустой список
        }

        // Метод для сохранения категорий в JSON
        public void SaveCategoriesToJson(List<adminAddCategoriesData> categories)
        {
            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        // Метод для получения всех категорий
        public List<adminAddCategoriesData> listAddcategoriesData()
        {
            return LoadCategoriesFromJson();
        }

        // Метод для добавления новой категории
        public void AddCategory(int id, string category, string status, string dateAdded)
        {
            List<adminAddCategoriesData> categories = LoadCategoriesFromJson();

            // Проверка на уникальность категории
            if (categories.Exists(c => c.Категорія == category))
            {
                Console.WriteLine($"{category} уже существует");
                return;
            }

            var newCategory = new adminAddCategoriesData
            {
                ID = id,
                Категорія = category,
                Статус = status,
                ДатаДодавання = dateAdded
            };

            categories.Add(newCategory);
            SaveCategoriesToJson(categories);
            Console.WriteLine("Категорія успішно додана!");
        }

        // Метод для обновления категории
        public void UpdateCategory(int id, string category, string status, string dateAdded)
        {
            List<adminAddCategoriesData> categories = LoadCategoriesFromJson();

            var categoryToUpdate = categories.Find(c => c.ID == id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Категорія = category;
                categoryToUpdate.Статус = status;
                categoryToUpdate.ДатаДодавання = dateAdded;

                SaveCategoriesToJson(categories);
                Console.WriteLine("Категорія успішно оновлена!");
            }
        }

        // Метод для удаления категории
        public void DeleteCategory(int id)
        {
            List<adminAddCategoriesData> categories = LoadCategoriesFromJson();

            var categoryToDelete = categories.Find(c => c.ID == id);
            if (categoryToDelete != null)
            {
                categories.Remove(categoryToDelete);
                SaveCategoriesToJson(categories);
                Console.WriteLine("Категорія успішно видалена!");
            }
        }
    }
}
