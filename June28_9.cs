using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_9
    {
        public void frequency()
        {
            int[] arr1 = new int[10];
            int[] fr1 = new int[10];
            int i, j, count = 1, n;
            Console.WriteLine("enter the number of elements into array");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the elements into the array:");
            //initilaizing array elements
            for(i=0;i<n;i++)
            {
                Console.WriteLine("elements:");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
              
            }
            //displaying array elements
            Console.WriteLine("the input elements n the array are:");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(arr1[i]);
                
            }
            //checking for duplicate numbers and frequency
            for(i=0;i<n;i++)
            {
                count = 1;
                for(j=i+1;j<n;j++)
                {
                    if (arr1[j] == arr1[i])
                    {
                        count++;
                        fr1[j] = 0;
                    }
                }
                if(fr1[i]!=0)
                {
                    fr1[i] = count;
                }
              
            }
            //displaying the frequency of elements
            Console.WriteLine("the frequency of all elements in the array:");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.WriteLine("{0} occurs {1} times \n" , arr1[i], fr1[i]);
                }
            }

            }
        }
    }
/*input:array elements{1,2,2,3,3,4}
ouput: 1 occurs 1  time
       2 occurs 2 times
       3 occurs 2 times
       4 occurs 1 time

