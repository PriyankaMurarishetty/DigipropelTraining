using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class July05_5
    {
        public void Random()
        {
            int min, max;
            Console.WriteLine("enter the starting range to check");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the end range to check");
            max = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int number = random.Next(min,max);
            Console.WriteLine("Random number:" + number);
        }
    }
}
