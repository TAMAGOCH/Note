using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomePraktika
{
    class Program
    {
        static void Main(string[] args)
        {
            int visota, shirina;
            string color;
            int area;
            int perimeter;
            visota = 12;
            shirina = 12;
            color = "white";
            area = visota + shirina;
            perimeter = visota * 2 + shirina * 2;
            Console.WriteLine("Имеем квадрат");
            Console.WriteLine("Ширина: " + shirina + " м.");
            Console.WriteLine("Высота: " + visota + " м.");
            Console.WriteLine("Цвет: " + color);
            Console.WriteLine("Его площадь: " + area + " м.");
            Console.WriteLine("Его Периметр: " + perimeter + " м.");

            string str = Console.ReadLine();
            switch (str)
            {
                case "exit":
                    Console.WriteLine("Работа приложения завершена.");
                    Thread.Sleep(2000); //подождать 2 секунды
                    Environment.Exit(0); //закрыть приложение
                    break;
                default:
                    Console.WriteLine("Выполняется какая-то работа");
                    break;
            }
          }
        }
    }

