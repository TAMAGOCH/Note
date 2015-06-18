using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        string text = Console.ReadLine().ToLower(); //переводим все буквы в нижний регистр
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;// получение объекта класса TextInfo
        Console.WriteLine("Исправление загланых букв: " + ti.ToTitleCase(text));//определяем каждое слово с заглавной буквы
        switch (text) // определение условия авторизации 
        {
            case "иван петрович":
                Console.WriteLine("Идет обработка данных");
                string[] sumbols1 = { "\\", "|", "/", "-" }; //элемент выполнения 
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(sumbols1[i % 4] + "\r");
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
    }
}
