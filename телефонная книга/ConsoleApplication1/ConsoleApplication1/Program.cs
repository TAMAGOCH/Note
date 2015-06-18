using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Library;

namespace ConsoleApplication1
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 Добавить автора");
            Console.WriteLine("2 Добавить произвидение");
            Console.WriteLine("3 Связать автора с произвидением");
            Console.WriteLine("4 Найти автора по произвидению ");
            Console.WriteLine("5 Найти произвидения по автору");
            Console.WriteLine("6 Распечатать все произвидения");
            Console.WriteLine("7 Распечатать всех авторов");
            Console.WriteLine("8 Сохранить в файл");
            Console.WriteLine("9 Считать из файла");
            Console.WriteLine("0 Выход");
            
        }

        static void Main(string[] args)
        {

            zapis pip = new zapis();
            bool quit = false;
            int mode;
            string authorName;
            string publusherName;
            string fileName;
            string[] zud;

            Console.WriteLine("библиотека L1");

            while (quit != true)
            {
                try
                {
                    PrintMenu();
                    mode = Convert.ToInt32(Console.ReadLine());

                    switch (mode)
                    {
                        case 1:
                            Console.Write("Введите имя автора: ");
                            authorName = Console.ReadLine();

                            pip.Addauthor(authorName);

                            break;
                        case 2:
                            Console.Write("Введите название произвидения: ");
                            publusherName = Console.ReadLine();

                            pip.Addpublisher(publusherName);

                            break;
                        case 3:
                            Console.Write("Введите имя автора: ");
                            authorName = Console.ReadLine();

                            Console.Write("Введите название произвидения: ");
                            publusherName = Console.ReadLine();

                            pip.AddpublisherToauthor(authorName, publusherName);

                            break;
                        case 4:
                            Console.Write("Введите название произвидения: ");
                            publusherName = Console.ReadLine();

                            pip.Findauthors(publusherName, out zud);

                    

                            foreach (string s in zud)
                                Console.WriteLine(s);

                            break;
                        case 5:
                            Console.Write("Введите имя автора: ");
                            authorName = Console.ReadLine();

                            pip.Findpublishers(authorName, out zud);

              

                            foreach (string s in zud)
                                Console.WriteLine(s);

                            break;
                        case 6:
                            pip.Printpublishers(out zud);

                            foreach (string s in zud)
                                Console.WriteLine(s);

                            break;
                        case 7:
                            pip.Printauthors(out zud);

                            foreach (string s in zud)
                                Console.WriteLine(s);

                            break;
                        case 8:
                            Console.Write("Введите имя файла: ");
                            fileName = Console.ReadLine();

                            pip.SaveToFile(fileName);

                            break;
                        case 9:
                            Console.Write("Введите имя файла: ");
                            fileName = Console.ReadLine();

                            pip.LoadFromFile(fileName);


                            break;
                        case 0:
                            quit = true;
                            break;
                        default:
                            Console.WriteLine("нельзя сотворить так");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("нельзя сотворить так");
                }
            }

            Console.WriteLine("исследование завершено");

            return;
        }
    }
}
