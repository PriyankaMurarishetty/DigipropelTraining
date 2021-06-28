using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class June25_1
    {
        static int a, b;
         public void Add()
        {
            
            Console.WriteLine("enter values for addition");
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:" );
            b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("sum=" + sum);
       }
        public void MultiSubDiv()
        {
            int Product = a * b;
            int Sub = a - b;
            int Div = a / b;
            Console.WriteLine("Prodcut=" + Product);
            Console.WriteLine("Sub=" + Sub);
            Console.WriteLine("Div=" + Div);
        }
          
    }
}
