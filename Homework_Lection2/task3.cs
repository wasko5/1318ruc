using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class task3
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double p;
            double s;
            try
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                p = (a + b + c) / 2;
                s = p * (p - a) * (p - b) * (p - c);
                s = Math.Sqrt(s);
                Console.WriteLine(s);
            }
            catch(Exception)
            {
                Console.WriteLine("ERROR!")
            }
        }
    }
}
