using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Assignment4
{
    class July05_4
    {
        public void Compare()
        {
            DateTime date1 = new DateTime();
            Console.WriteLine("enter the first date to check");
            date1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Date {0}:" + date1);
            DateTime date2 = new DateTime();
            Console.WriteLine("enter the second date to check");
            date2 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Date {0}:" + date2);
            if(date1<date2)
            {
                Console.WriteLine("{0} comes before {1}" , date1, date2);
            }
            else if(date1>date2)
                {
                Console.WriteLine("{0} comes before{1}" , date2, date1);
            }
            else
            {
                Console.WriteLine("the dates are equal");
            }


            


        }
    }
}
