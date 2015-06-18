using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerberdFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // ciklFor(); демонстрация цикла for
            // BlockDemo(); демонстрация блока
            //ForProizvSum(); с помощью цикла for в блоке считаем сумму и произведение
            //Trigonometry(); тригонометрические функции с применением класса Math
            //Discount(); расчет сидки с помощью типа decimal
            //NormPribil(); расчет прибыли в течении 10 лет
            //Hypot(); вычисление гипотенузы треугольника
            //Preobrazovania(); преобразование разных типов
            // koren(); вычисление корня от 1 до 10 с выявлением дробной части
            // PrePostDemo(); демонстрация работы x++ и ++x
            //TrueFalse(); операции импликации
            //Encode(); //легкий вид зашифровки данных
            //ShiftDemo(); //задани по второму занятию со сдвигом на 1
            //schetchik(); //реализация простого счетчика
            //UseGoTo(); //использование goto для завершения вложенных циклов


        }

        private static void UseGoTo()
        {
            int i = 0, j = 0, k = 0;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        Console.WriteLine("i, j, k: " + i + " " + j + " " + k);
                        if (k == 3) goto stop;
                    }
                }
            }
        stop:
            Console.WriteLine("Остановка!" + i + " " + j + " " + k);
        }

        private static void schetchik()
        {
            int num, mag;
            num = 435679;
            mag = 0;
            Console.WriteLine("Число: " + num);
            while (num > 0)
            {
                mag++;
                num = num / 10;
            }
            Console.WriteLine("Порядок величины: " + mag);
        }

        private static void ShiftDemo()
        {
            // забавный бесконечный цикл
            /*int val = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t++)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val << 1;
            }*/
            int val = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val << 1;
            }
            //Console.WriteLine();
            val = 128;
            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val >> 1;
            }
        }

        private static void Encode()
        {
            char ch1 = 'H';
            char ch2 = 'i';
            char ch3 = '!';
            int key = 88;
            Console.WriteLine("Исходный вид: {0}{1}{2}", ch1, ch2, ch3);
            // зашифрока
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);
            Console.WriteLine("зашифрованный вид: " + ch1 + ch2 + ch3);
            //расшифровка
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);
            Console.WriteLine("расшифрованный вид: " + ch1 + ch2 + ch3);
        }

        private static void TrueFalse()
        {
            bool p = false, q = false;
            int i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    if (i == 0) p = true;
                    if (i == 1) p = false;
                    if (j == 0) q = true;
                    if (j == 1) q = false;
                    Console.WriteLine("p равно {0}, q равно {1} ", p, q);
                    if (!p | q)
                        Console.WriteLine("Результат импликации {0} и {1} равен " + true, p, q);
                    Console.WriteLine("--------------");
                }
            }
        }

        private static void PrePostDemo()
        {
            int x, y;
            int i;
            x = 1;
            y = 0;
            Console.WriteLine("Результат при выражении y = y + x++");
            for (i = 0; i < 10; i++)
            {
                y = y + x++;
                Console.WriteLine(y + " ");
            }
            Console.WriteLine("------------------------");
            x = 1;
            y = 0;
            Console.WriteLine("Результат при выражении y = y + ++x");
            for (i = 0; i < 10; i++)
            {
                y = y + ++x;
                Console.WriteLine(y + " ");
            }
            Console.WriteLine("++++++++++++++++++++++++");
        }

        private static void koren()
        {
            double n;
            for (n = 1.0; n <= 10; n++)
            {
                Console.WriteLine("Корень из {0} равен {1} ", n, Math.Sqrt(n));
                Console.WriteLine("Целая часть числа: {0}", (int)Math.Sqrt(n));
                Console.WriteLine("Дробная часть числа: {0}", Math.Sqrt(n) - (int)Math.Sqrt(n));
            }
        }

        private static void Preobrazovania()
        {
            double x, y;
            byte b;
            int i;
            char ch;
            uint u;
            short s;
            long l;
            x = 10.0;
            y = 3.0;
            //приведение типа double к int
            i = (int)(x / y);
            Console.WriteLine("результат деления х на у " + i);
            Console.WriteLine();
            //приведение типа int к byte
            i = 255;
            b = (byte)i;
            Console.WriteLine("значению типа byte присвоено значение типи int с преобразованием " + b);
            Console.WriteLine();
            //потерия данных в случае преобразования типа int к byte
            i = 257;
            b = (byte)i;
            Console.WriteLine("переменной b присвоено значение 257 с потерией в результате преобразование " + b);
            Console.WriteLine();
            // преобразование типа uint к short
            u = 32000;
            s = (short)u;
            Console.WriteLine("без потерии данных " + s);
            Console.WriteLine();
            //приведение типа uint к short с потерией данных
            l = 64000;
            s = (short)u;
            Console.WriteLine("с потериее данных " + s);
            Console.WriteLine();
            //приведение типа long к uint
            l = 64000;
            u = (uint)l;
            Console.WriteLine("без потерии данных " + u);
            Console.WriteLine();
            // приведение типа long к uint с потерией данных
            l = -12;
            u = (uint)l;
            Console.WriteLine("с потериее данных " + u);
            Console.WriteLine();
            // приведение типа int к char
            b = 88;//код ASCII символа Х
            ch = (char)b;
            Console.WriteLine("преобразование 88 в char " + ch);
            Console.WriteLine();
        }

        private static void Hypot()
        {
            double s1 = 5.0;
            double s2 = 4.0;
            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Гипотенуза треугольника со сторонами " + s1 + " и " + s2 + " равна ");
            Console.WriteLine("{0:#.###}.", hypot);
        }

        private static void NormPribil()
        {

            decimal amount;
            decimal rate;
            int years, i;

            amount = 1000m;
            rate = 0.07m;
            years = 10;

            Console.WriteLine("Первоначальное вложение: " + amount);
            Console.WriteLine("Норма прибыли: " + rate);
            Console.WriteLine("В течении " + years + " лет");
            for (i = 0; i < years; i++)
            {
                amount = amount + (amount * rate);
            }
            Console.WriteLine("будующая стоимость равна $" + amount);
        }

        private static void Discount()
        {
            decimal price;
            decimal discount;
            decimal dis_price;

            //расчитать цену со скидкой
            price = 19.95m;
            discount = 0.15m; // скидка в размере 15 %
            dis_price = price - (price * discount);
            Console.WriteLine("цена со скидкой: $" + dis_price);
        }

        private static void Trigonometry()
        {

            double theta; //угол в радианах
            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
            {
                Console.WriteLine("sin " + theta + " =" + Math.Sin(theta));
                Console.WriteLine("cos " + theta + " =" + Math.Cos(theta));
                Console.WriteLine("tan " + theta + " =" + Math.Tan(theta));
                Console.WriteLine();
            }

        }

        private static void ForProizvSum()
        {
            int prod, sum, i;
            sum = 0;
            prod = 1;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }
            Console.WriteLine("summa = " + sum);
            Console.WriteLine("proizvedenie = " + prod);

        }

        private static void BlockDemo()
        {
            int i, j, d;
            i = 0;
            j = 10;
            // адресом оператора if служит кодовый блок
            if (i != 0)
                // заключение в { } является блоком
            {
                Console.WriteLine("i != zero");
                d = j / i;
                Console.WriteLine("j/i = " + d);
            }
            else
            {
                Console.WriteLine("i = zero");
            } 
        }

        private static void ciklFor()
        {
            int count;
            for (count = 0; count < 5; count++)
                Console.WriteLine("znachenie = " + count);
            Console.WriteLine("done");
        }
    }
}
