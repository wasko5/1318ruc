using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class task2
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            try
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                Console.WriteLine(((a + b) * h) / 2);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
