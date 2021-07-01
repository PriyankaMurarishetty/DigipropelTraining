using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class June28_3
    {
        public void Matrix()
        {
            int[,]arr1 = new int[10,10];
            int[,] arr2 = new int[10,10];
            int i, j, r1, c1, r2, c2, num = 1;
            Console.WriteLine("enter the number of rows in first matrix:");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of columns in first matrix:");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of rows in second matrix");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of column in second matrix");
            c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements into first matrix");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.WriteLine("elements:[{0}],[{1}]" + (i, j));
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("the first matix is:");
            for (i = 0; i < r1; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < c1; j++)
                {
                    Console.WriteLine("\t",arr1[i,j]);

                }
            }
            Console.WriteLine("enter the elements into second matrix ");
            for (i = 0; i < r2; i++)

            {
               
                for (j = 0; j < c2; j++)
                {
                    Console.WriteLine("elements:[{0]},[{1}]" + (i, j));
                    arr2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("the second matrix is :");
            for (i = 0; i < r2; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < c2; j++)
                {
                    Console.WriteLine("\t",arr2[i,j]);

                }
            }
            if (r1 != r2 && c1 != c2)
            {
                Console.WriteLine("the matrices cannot be compared");

            }
            else
            {
                {
                    Console.WriteLine("the matrices can be compared");

                    for (i = 0; i < r1; i++)
                    {
                        for (j = 0; j < c2; j++)
                        {
                            if (arr1[i,j] != arr2[i,j])
                            {
                                num = 0;
                                break;
                            }

                        }
                        if(num== 1)

                            Console.WriteLine("matrices are equal");

                        else

                            Console.WriteLine("matrices are not equal");
                    }
                }
            }
        }
    }
}

       
    



        
    

