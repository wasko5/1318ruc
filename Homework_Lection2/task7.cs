using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class task7
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            try
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                if ((a < b + c) && (b < a + c) && (c < a + b)) Console.WriteLine("A triangle with sides {0} {1} {2} can be made.", a, b, c);
                else
                {
                    Console.WriteLine("A triangle with sides {0} {1} {2} can not be made", a, b, c);
                    return;
                }
                if ((a == b) && (b == c)) Console.WriteLine("The triangle would be equilateral");
                else if ((a != b) && (b != c)) Console.WriteLine("The triangle would be versatile");
                else Console.WriteLine("The Triangle would be isosceles");
            }
            catch (Exception)
            {

                Console.Write("ERROR");
            }
        }
    }
}
