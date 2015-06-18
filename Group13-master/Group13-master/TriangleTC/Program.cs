using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Work work = new Work();
                work.GetNumber();
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
    }
    class Work
    {
        public int GetNumber()
        {
            while (true)
            {
                try
                {
                    //Координаты точек
                    Console.Write("a = ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b = ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c = ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    //Полупериметр
                    double p = (a + b + c) / 2;
                    //Площадь
                    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    Console.WriteLine(string.Format("Площадь = " + S));

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Program.SaveErrorInfo(ex);
                    Console.WriteLine("Нельзя вводить буквы.");
                    Console.WriteLine("Попробуйте еще раз:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Program.SaveErrorInfo(ex);
                    Console.WriteLine("Диапазон возможных значений: [{0}, {1}]", int.MinValue, int.MaxValue);
                    Console.WriteLine("Попробуйте еще раз:");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Program.SaveErrorInfo(ex);
                    Console.WriteLine("Произошла неизвестная ошибка.");
                    Console.WriteLine("Попробуйте еще раз:");
                }
              }
           }
       }
    }
