using System;

namespace Assignment2
{
    class June28
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i, sum = 0, n;
            Console.WriteLine("enter the number of elements into the array to find sum");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the input elemnets into the array");
            //initializing array elements.
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("elements : ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            //calculating sum of elements in array
            for (i = 0; i < n; i++)
            {
                sum = sum + arr1[i];
            }
            Console.WriteLine("sum of the elements in the array :" + sum);
            
                 June28_1 dr = new June28_1();
                dr.duplicate();
                June28_2 cr = new June28_2();
                cr.OddEven();
                June28_3 mr = new June28_3();
                mr.Matrix();
                June28_4 pr = new June28_4();
                pr.maxmin();
                June28_5 re = new June28_5();
                re.reverse();
                June28_6 sr = new June28_6();
                sr.sort();
                June28_7 ms =new June28_7();
                ms.find();
                 June28_8 ad = new June28_8();
                ad.add();
                June28_9 fr = new June28_9();
                fr.frequency();
              
            

        }
    }
}
/*input:array element{0,1,2,3,4}
ouput: sum=10*/
