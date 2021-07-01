using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_1
    {
        public void duplicate()
        { 
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];
        int i, j, s1, dup = 1, count = 0;
        Console.WriteLine("enter the number of elemnets into the array to find duplicate");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the elments into the array");
            for(i=0;i<s1;i++)
            {
                Console.WriteLine("input elements :");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<s1;i++)

            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
for (i = 0; i < s1; i++)
{
    for (j = 0; j < s1; j++)
    {
        if (arr1[i] == arr1[j])
        {
            arr3[j] = dup;
            dup++;
        }
    }
    dup = 1;
}
for (i = 0; i < s1; i++)
{
    if (arr3[i] == 2)
    {
        count++;
    }
}
Console.WriteLine("the count of duplicate numbers:" + count);
                    
                }
            }
        }
   
