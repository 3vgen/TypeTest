using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;

namespace TypeTest
{
    public class ScoreTable
    {
        string path = @"";
        public List<User> users = new List<User>();
        public ScoreTable(string path)
        {
            this.path = path;
        }
        public void ReadJson()
        {
            StreamReader reader = new StreamReader(path);
            users = JsonSerializer.Deserialize<List<User>>(reader.ReadToEnd());
            reader.Close();
        }
       
        public void WriteJson()
        {
            //File.WriteAllText(path, string.Empty);
            string json = JsonSerializer.Serialize(users, typeof(List<User>));
            StreamWriter writer = new StreamWriter(path);
            writer.Write(json);
            writer.Close();
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void PrintTable()
        {
            Console.WriteLine("Таблица рекордов");
            Console.WriteLine("----------------------------------------------");
            foreach(var item in users)
            {
                Console.WriteLine(item);
            }
        }
    }
}
