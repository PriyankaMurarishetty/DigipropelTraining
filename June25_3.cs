using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class June25_3
    {
        public Boolean check()
        {
            int p, r;
            Console.WriteLine("Enter values to check for poitive or negative");
            Console.WriteLine("Enter p=");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter q=");
            r = Convert.ToInt32(Console.ReadLine());
            if ((p > 0 && r < 0)||(p < 0 && r > 0))
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }

        }
    }
}
