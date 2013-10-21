using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class task5
    {
        static void Main(string[] args)
        {
            string name;
            string ID;
            string phonenumber; // +359...
            try
            {
                name = Console.ReadLine();
                ID = Console.ReadLine();
                phonenumber = Console.ReadLine();
                Console.WriteLine("Hello {0}, your ID is: {1} and your phone number is {2}. ", name, ID, phonenumber);
            }
            catch (Exception)
            {
                Console.Write("ERROR");
            }
        }
    }
}
