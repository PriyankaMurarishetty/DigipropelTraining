using System;

using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class June25_4
    {
        public void Triple()
        {
            int m, n;
            Console.WriteLine("Enter the values");
            Console.WriteLine("m=" );
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());
            if(m==n)
            {
                int multi = (m + n) * (m + n) * (m + n);
                Console.WriteLine("Result after triple of their sum = " + multi);
            }
            else
            {
                Console.WriteLine("Notequal");
                
            }
        }

    }
}
