using System;

namespace Assignment1
{
    class June25
    {
        
        static void Main(string[] args)
        {
            int num1, num2, num3;
            
            Console.WriteLine("Enter the first input number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second input number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third input number");
            num3 = Convert.ToInt32(Console.ReadLine());
            int Product = num1 * num2 * num3;
            Console.WriteLine("Product =" +Product);
            June25_1 pr = new June25_1();
            pr.Add();
            pr.MultiSubDiv();
            June25_2 tot = new June25_2();
            tot.Calculate();
            June25_3 obj = new June25_3();
            obj.check();
            June25_4 cr = new June25_4();
            cr.Triple();
            June25_5 sr = new June25_5();
            sr.strdr();
    
        }
    }
}
