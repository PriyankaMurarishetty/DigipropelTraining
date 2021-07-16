using System;

namespace Assignment5
{
    class July07
    {
     public static void Main(string[] args)
        {
           July07 pr = new July07();
            pr.Interface();
            July07_1 ab = new July07_1();
            ab.Abstract();
            StudentTeacherTest sr = new StudentTeacherTest();
            sr.Inheritance();
           UseStudent ds = new UseStudent();
          ds.Display();
            UseStudent2 sd = new UseStudent2();
            sd.Display1();
            Test cr = new Test();
            cr.CourseInformation();
            StackOperation tb = new StackOperation();
           tb.Table();
            July07_7 sc = new July07_7();
            sc.Search();
            TestTables ta = new TestTables();
            ta.Tables();
            TextEncrypter ed = new TextEncrypter();
            ed.EncryptDecrypt();
        }
        
        public void Interface()
        {
            Car car = new Car(0);
            int fuel = int.Parse(Console.ReadLine());
            if(car.Refuel(fuel))
            {
                car.Drive();
            }
        }
        //defining an interface
        public interface IVvehicle
        {
            void Drive();
            bool Refuel(int amount);
        }
        public class Car : IVvehicle//car class with a builder
        {
            public int Fuel { get; set; }//to setup initial fuel value
            public Car(int fuel)
            {
                Console.WriteLine("enter the fuel");//entering the amount of fuel
                Fuel = fuel;
            }
            public void Drive()//drive method will print on the screen that the car is driving
            {
                if(Fuel>0) 
                {
                    Console.WriteLine("The car is driving");
                }
                else
                {
                    Console.WriteLine("No fuel");
                }
            }
            public bool Refuel(int amount)
            {
                Fuel += amount;
                return true;
            }
        }
    }
}
/*output:
enter the fuel
50
The car is driving*/
