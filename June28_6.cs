using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_6
    {
        public void sort()
        {
            int[] brr1 = new int[10];
            int i,j,temp, n;
            Console.WriteLine("enter the length of the array to sort the elements");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the elements into the array");
            //initialing array elements
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("elements:");
                brr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("the input elements are ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(brr1[i]);
            }
            //sorting array elements
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (brr1[j] < brr1[i])
                    {
                        temp = brr1[i];
                        brr1[i] = brr1[j];
                        brr1[j] = temp;

                    }
                }
            }
            //displaying array elements in ascending order
                    Console.WriteLine("the input elements in asscending order");
                    for(i=0;i<n;i++)
                    {
                        Console.WriteLine(brr1[i]);

                    }
                }
            }

        }
/*input:array elements{60,5,4,77,20}
output:the input elements in ascending order 4,5,20,60,77
    
