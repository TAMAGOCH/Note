using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
                        try
            {
            Square Trian = new Square(5, 5, 5);
            Trian.Print();
            }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Приложение не может выполнить свою задачу.");
                            SaveErrorInfo(ex);
                        }
        }
        public static void SaveErrorInfo(Exception ex)
        {
            FileStream stream = new FileStream("error.log", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(DateTime.Now);
            writer.WriteLine(ex.Message);
            writer.WriteLine(ex.StackTrace);
            writer.WriteLine("---------------------------------");
            writer.Close();
        }
        class Square
        {
            private double a;
            private double b;
            private double c;
            private double p;
            private double area;
            public void Print()
            {
                p = (a + b + c) / 2; //полупериметр
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //вычисление площади треугольника по формуле Герона
                Console.WriteLine("Данн треугольник");
                Console.WriteLine("Сторона a = " + a);
                Console.WriteLine("Сторона b = " + b);
                Console.WriteLine("Сторона c = " + c);
                Console.WriteLine("Его площадь: " + area);
                Console.WriteLine();
            }
            public Square(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

    }
}

