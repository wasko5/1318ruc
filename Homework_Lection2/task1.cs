using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class task1
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                number = int.Parse(Console.ReadLine())
                int numberHold = number;
                int digit5 = number % 10; number = number / 10;
                int digit4 = number % 10; number = number / 10;
                int digit3 = number % 10; number = number / 10;
                int digit2 = number % 10; number = number / 10;
                int digit1 = number % 10;
                Console.WriteLine(digit5 * 10000 + digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1);
                int SumDigit = digit1 + digit2 + digit3 + digit4 + digit5;
                Console.WriteLine(numberHold % SumDigit);
                numberHold = numberHold - (digit2 * 1000);
                numberHold = numberHold - (digit3 * 100);
                numberHold = numberHold + (digit3 * 1000);
                numberHold = numberHold + (digit2 * 100);
                Console.WriteLine(numberHold);
            }
            catch(Exception)
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
