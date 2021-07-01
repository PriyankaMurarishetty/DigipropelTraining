using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment2
{
    class June28_7
    {
        public void Missingnum()
        {
            int[] num1= { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("original numbers in the array");
            Array.ForEach(num1, Console.WriteLine);
            Console.WriteLine("the missing number in the array is:", +test(num1,num1));
            int[] num2 = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("\noriginal numbers in the array");
            Array.ForEach(num2, Console.WriteLine);
            Console.WriteLine("the missing number in the array:" + test(num1,num2));
            int[] num3 = {10, 11, 12, 13, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("the original array elements");
            Array.ForEach(num3, Console.WriteLine);
            Console.WriteLine("the missing number in the array " + test(num1,num3));
            int[] num4 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Console.WriteLine("original array elements");
            Array.ForEach(num4, Console.WriteLine);
            Console.WriteLine("the missing number in the array"+test(num1,num4));

        }
        public static int test(int[]brr,int[]brr1)
        {
            return brr.Sum() - brr1.Sum();
        }
    }
}
