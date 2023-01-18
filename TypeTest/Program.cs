using System;
using System.Threading;
using System.Diagnostics;

namespace TypeTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ScoreTable scoreTable = new ScoreTable(@"C:\Users\МБОУ ЦО 2\Desktop\users.json");
            ConsoleKeyInfo kk = new ConsoleKeyInfo();
            //Type type = new Type("dsafgdsln dhakjsh dsajkdh kasjhd kjash", 5);
            Type type;
            Texts text = new Texts();
            User user;
            while (true)
            {
                type = new Type(text.GetText(), 60);
                Console.Write("Введите ваше имя: ");
                string name = Console.ReadLine();
                Console.Clear();
                type.Preparation();
                Console.Clear();
                type.RunningTest();
                Console.Clear();
                user = new User(name, type.ResultInMinute, type.ResultInSecond);
                scoreTable.AddUser(user);
                scoreTable.WriteJson();
                scoreTable.ReadJson();
                scoreTable.PrintTable();
                Console.WriteLine("Нажмите <Enter>, чтобы пройти тест заново");
                while (true)
                {
                    kk = Console.ReadKey();
                    if (kk.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            
            
            

            
        }
    }
}
