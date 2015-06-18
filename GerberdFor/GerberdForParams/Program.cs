using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerberdForParams
{
    class Program
    {
        static void Main(string[] args)
        {
            ParmDemo ob = new ParmDemo();
            for (int i = 2; i < 10; i++)
                if (ob.IsPrime(i)) Console.WriteLine(i+" простое число.");
                else Console.WriteLine(i+" не простое число.");
        }
    }
    class ParmDemo
    {
        public bool IsPrime (int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0) return false;
            return true;
        }
    }
}
