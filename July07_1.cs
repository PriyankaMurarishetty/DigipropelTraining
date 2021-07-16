using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class July07_1
    {
        public void Abstract()
        {
            //creating  a dog oject
            Dog dog = new Dog();
           dog.Setname(Console.ReadLine());
           Console.WriteLine(dog.Getname());
           dog.Eat();

        }
        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("The dog is eating");
            }
        }
        //defining an abstract class
        public abstract class Animal
        {
            private string Name;
            public void Setname(string name)
            {
                Console.WriteLine("Enter the dog name");
                Name = name;

            }
            public string Getname()
            {
                return Name;
            }
            public abstract void Eat();
        }
    }
}
/*output:
Enter the dog name
snoopy
The dog is eating  */
