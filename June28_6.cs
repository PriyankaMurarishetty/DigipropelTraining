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
                    Console.WriteLine("the input elements in asscending order");
                    for(i=0;i<n;i++)
                    {
                        Console.WriteLine(brr1[i]);

                    }
                }
            }

        }
    
