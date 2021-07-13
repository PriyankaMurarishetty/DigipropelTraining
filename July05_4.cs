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
    /*output:
enter the first date to check
07-09-2017
Date {0}:7/9/2017 12:00:00 AM
enter the second date to check
05-09-2016
Date {0}:5/9/2016 12:00:00 AM
5/9/2016 12:00:00 AM comes before7/9/2017 12:00:00 AM*/



            


        }
    }
}
