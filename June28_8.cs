using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_8
    {
        public void add()
        {
            int i, n1, n2, temp1, temp2, sum=0;
          
            Console.WriteLine("enter the number of elements in first array:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of elements in second array");
            n2 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n1];
          int[] arr2 = new int[n2];
            //initializing first array elements
            Console.WriteLine("enter the elements into first array:");
            for(i=0;i<n1;i++)
            {
                Console.WriteLine("elements:", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            //initializing second array elements
            Console.WriteLine("enter the elements into second array:");
            for (i = 0; i < n2; i++)
            {
                Console.WriteLine("elements:", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            } 
            //converting first and second array elements to string
            string[] strarr1 = Array.ConvertAll(arr1, ele => ele.ToString());
            string[] strarr2 =Array.ConvertAll(arr2, ele => ele.ToString());
            temp1 = Convert.ToInt32(string.Join ("",strarr1));
            temp2 = Convert.ToInt32(string.Join("",strarr2));
            //adding the array's
            sum = temp1 + temp2;
            Console.WriteLine("{0}+{1}={2}",temp1,temp2,sum);

        }
    }
}
/*input:first array elemeents{1,6,9}
        second array elements{2,3}
  output:sum=169+23=192
