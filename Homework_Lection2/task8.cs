using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class task8
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double D;
            double x1;
            double x2;
            try
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                if (a != 0)
                {
                    D = b * b - 4 * a * c;
                    if (D < 0) Console.WriteLine("x1 and x2 are complex numbers!");
                    else if (D == 0)
                    {
                        x1 = (-1 * b) / (2 * a);
                        Console.WriteLine("x1 = x2 = {0}", x1);
                    }
                    else
                    {
                        x1 = ((-1 * b) + Math.Sqrt(D)) / 2 * a;
                        x2 = ((-1 * b) - Math.Sqrt(D)) / 2 * a;
                        Console.WriteLine("x1 = {0} \nx2 = {1} ", x1, x2);
                    }
                }
                else
                {
                    x1 = (-1 * c) / b;
                    Console.WriteLine("x=", x1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
