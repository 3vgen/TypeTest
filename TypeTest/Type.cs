using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace TypeTest
{
    class Type
    {
        string Text { get; set; }
        private int Time { get; set; }
        public double Counter { get; set; }
        ConsoleKeyInfo note;
        Thread TimerThread;
       

        public double ResultInSecond
        {
            get { return GetResultInSecond(); }
        }
        public double ResultInMinute
        {
            get { return GetResultInMinute(); }
        }


        public Type(string text, int time)
        {
            Text = text;
            Time = time;
        }
        public void Preparation()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("0:" + i);
                Console.WriteLine("После окончания таймера начинайте печатать. Проверьте раскладку и клавишу <Caps Lock>");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("    ");
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("    ");

            }
        }
        private void StartPrint()
        {
            int deepLength = 0;
            Console.SetCursorPosition(0, deepLength);
            Console.WriteLine(Text);
            note = new ConsoleKeyInfo();
            for (int i = 0; i < Text.Length; i++)
            {
                if (TimerThread.IsAlive == false) break;
                while (true)
                {
                    Console.SetCursorPosition(i, deepLength);
                    note = Console.ReadKey();
                    if (note.KeyChar == Text[i])
                    {
                        Counter++;
                        Console.SetCursorPosition(i, deepLength);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Text[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else
                    {
                        Console.SetCursorPosition(i, deepLength);
                        Console.Write(Text[i]);

                    }
                }
            }
        }
        private void Timer()
        {
            Thread.Sleep(100);
            int deep = 5;
            for (int i = Time; i > 0; i--)
            {
                Console.SetCursorPosition(0, deep);
                Console.WriteLine("0:" + i);
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, deep);
                Console.WriteLine("    ");
                Console.SetCursorPosition(0, 6);
                Console.WriteLine("    ");

            }
        }
        private void StartTimer()
        {
            TimerThread = new Thread(Timer);
            TimerThread.Start();
        }
        public void RunningTest()
        {
            Counter = 0;
            StartTimer();
            StartPrint();
        }
        private double GetResultInSecond()
        {
            return Math.Round((Counter / Time),2);
        }
        private double GetResultInMinute()
        {
            double result = (Counter / Time) * 60;
            return Math.Round(result);

        }
    }
}
