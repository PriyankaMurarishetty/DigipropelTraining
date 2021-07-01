using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_2
    {
        public void OddEven()
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;
            Console.WriteLine("enter the number of elements into the array to find oddeven");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the input elements:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("input elements:" + i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
                Console.WriteLine("Even numbers are:");
                for(i=0;i<j;i++)
                {
                    Console.WriteLine(arr2[i]);
                    
                }
                Console.WriteLine("odd numbers are:");
                for(i=0;i<k;i++)
                {
                    Console.WriteLine(arr3[i]);
                    
                }
               
            

        }
    }
}
