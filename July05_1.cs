using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class July05_1
    {
        public void Constructor()
        {
            
            int total = 3, i;
            Person[] persons = new Person[total];
            for (i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());

            }

            for (i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
            
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello! My Name is :" + Name;
        }
         ~Person()
         {
            Name=string.Empty;

          }
     }
    
}
/*output:john
        sana
         priya
Hello! My name is :john
Hello! My name is :sana
Hello! My name is :priya*/
    


