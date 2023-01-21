using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection.PortableExecutable;


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
            users = JsonConvert.DeserializeObject<List<User>>(reader.ReadToEnd());
            reader.Close();
        }
       
        public void WriteJson()
        {
            string json = JsonConvert.SerializeObject(users);

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
