using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace partOne
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Строки
            test();
            //login();

        }

        private static void login()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string str;
            str = Console.ReadLine();
            switch (str)
            {
                case "Иван Петрович":
                    Console.WriteLine("Идет обработка данных");
                    string[] sumbols = { "\\", "|", "/", "-" }; //элемент выполнения 
                    for (int i = 0; i < 100; i++)
                    {
                        Console.Write(sumbols[i % 4] + "\r");
                        Thread.Sleep(100);
                    }
                    Console.WriteLine("Вход выполнен");
                    Thread.Sleep(2000); //подождать 2 секунды
                    Environment.Exit(0); //закрыть приложение
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
            if (str != "Иван Петрович")
            {
                Console.WriteLine("Повторите запрос");
            }
            Console.ReadKey();
        }

        private static void test()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string us2 = "a23;a23";   //Console.ReadLine();
            string us3 = us2.ToUpper(); //возможно заменить 1 элемент вводимого текста
            Console.WriteLine("выводим введенное слово с верхним регистром " + us2.ToUpper());
            Console.WriteLine("-------------");
            Console.WriteLine("++++++++++++++");

            Console.WriteLine("выводим верхний регистр " + us3);
            //Console.WriteLine(us2.Replace(0, "сложная"));
            // Console.WriteLine(username.ToLower());
            //string text = "простая строка";

            string a = "ван ";
            string a0 = "етрович";
            string a1 = "И";
            string a2 = "П";
            Console.WriteLine(a1 + a + " " + a2 + a0);
            #endregion
        }
    }
}