using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class June25_5
    {
        public void strdr()
        {
            string str, str1;
            Console.WriteLine("enter the input string");
            str = Console.ReadLine();
            Console.WriteLine("enter the string to check");
            str1 = Console.ReadLine();
            if (str.StartsWith(str1))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
