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
            //initializing first matrix elements
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.WriteLine("elements:[{0}],[{1}]" + (i, j));
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            //display the first matrix elements
            Console.WriteLine("the first matix is:");
            for (i = 0; i < r1; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < c1; j++)
                {
                    Console.WriteLine("\t",arr1[i,j]);

                }
            }
            //initializing second matrix elements
            Console.WriteLine("enter the elements into second matrix ");
            for (i = 0; i < r2; i++)

            {
               
                for (j = 0; j < c2; j++)
                {
                    Console.WriteLine("elements:[{0]},[{1}]" + (i, j));
                    arr2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //displaying second matrix elements

            Console.WriteLine("the second matrix is :");
            for (i = 0; i < r2; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < c2; j++)
                {
                    Console.WriteLine("\t",arr2[i,j]);

                }
            }
            //checking for matrix size
            if (r1 != r2 && c1 != c2)
            {
                Console.WriteLine("the matrices cannot be compared");

            }
            else
            {
                {
                    Console.WriteLine("the matrices can be compared");
         //checking for elements equality
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
/*input:first matrix elements:1 2 
                              3 4
        second matrix elements:1 2
                               3  4
   output:matrix can be compared
          matrices are equal

       
    



        
    

