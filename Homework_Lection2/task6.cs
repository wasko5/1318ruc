using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class task6
    {
        static void Main(string[] args)
        {
            double number;
            try
            {
                number = double.Parse(Console.ReadLine());
                if (number > 0) Console.WriteLine("Positive!");
                else if (number < 0) Console.WriteLine("Negative!");
                else Console.WriteLine("The number Zero is neither negative nor positive!");
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
