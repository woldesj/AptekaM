using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Apteka
{
    class adminAddUsersData
    {
        private readonly string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("ІмяКористувача")]
        public string ІмяКористувача { get; set; }

        [JsonProperty("Пароль")]
        public string Пароль { get; set; }

        [JsonProperty("Роль")]
        public string Роль { get; set; }

        [JsonProperty("Статус")]
        public string Статус { get; set; }

        [JsonProperty("ДатаРеєстрації")]
        public string ДатаРеєстрації { get; set; }

        public List<adminAddUsersData> ListAddUsersData()
        {
            if (!File.Exists(jsonFilePath))
            {
                File.WriteAllText(jsonFilePath, "[]");
            }

            string json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<adminAddUsersData>>(json) ?? new List<adminAddUsersData>();
        }

        public void AddUser(adminAddUsersData newUser)
        {
            var users = ListAddUsersData();

            // Устанавливаем ID для нового пользователя
            newUser.ID = users.Count > 0 ? users[users.Count - 1].ID + 1 : 1;

            users.Add(newUser);

            SaveUsersToJson(users);
        }

        private void SaveUsersToJson(List<adminAddUsersData> users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }
    }
}
