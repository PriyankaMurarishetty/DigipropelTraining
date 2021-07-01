using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_4
    {
        public void maxmin()
        {
            int[] arr1 = new int[10];
          
            int i,n, max, min;
            Console.WriteLine("enter the number of elements into the array to find maxmin");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the elements into the array");
            for(i=0;i<n;i++)
            {
                Console.WriteLine("the input elements:");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(arr1[i]);
            max = arr1[0];
            min = arr1[0];
            for(i=0;i<n;i++)
            if(arr1[i]>max)
            {
                max = arr1[i];
            }
          else  if(arr1[i]<min)
            {
                min = arr1[i];
            }
            Console.WriteLine("maximum number is:" + max);
            Console.WriteLine("minimum number is :" + min);
        }
    }
}
