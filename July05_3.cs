using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class July05_3
    {
        public void Leapyear()
        {
            int year;
            Console.WriteLine("Enter the year to check:");
            year = Convert.ToInt32(Console.ReadLine());
            if((year % 4 == 0 && year % 100 != 0)||(year % 400 == 0))
            {
                Console.WriteLine("the entered year is leap year");
            }
            else
            {
                Console.WriteLine("the enetered year is not leap year");
            }
        }

    }
}
/*output:
Enter the year to check:
2004
the entered year is leap year*/

