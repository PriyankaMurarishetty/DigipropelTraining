using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_5
    {
        public void reverse()
        {
            int i, n;
            int[] brr1 = new int[10];
            Console.WriteLine("enter the length the array to find the reverse");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the elements into the array");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("elements :");
                brr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the input elements into array");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(brr1[i]);
            }
            Console.WriteLine("the reverse array is");
            for (i = n-1; i>=0; i--)
            {
                Console.WriteLine(brr1[i]);
            }
        }
    }
}


