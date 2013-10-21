using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class task4
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine(number << 3);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
