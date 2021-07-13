using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{ 
    
   public class StudentProfessorTest
        {
            public  void Inheritance()
            {
                Member myperson = new Member();
                myperson.Greetings();
                Student mystudent = new Student();
                mystudent.SetAge(21);
                mystudent.Greetings();
                mystudent.Study();
                mystudent.ShowAge();
                Professor myprofessor = new Professor();
                myprofessor.SetAge(35);
                myprofessor.Greetings();
                myprofessor.Explain();
            }
        }
        public class Member
        {
            protected int age;
            public void Greetings()
            {
                Console.WriteLine("Hello!");
            }
            public void SetAge(int n)
            {
                age = n;
            }
        }
        public class Student:Member
        {
            public void Study()
            {
                Console.WriteLine("I'm Studying");
            }
            public void ShowAge()
            {
                Console.WriteLine("My age is :" + age);
            }
        }
        public class Professor:Member
        {
            public void Explain()
            {
                Console.WriteLine("I'm explaining");
            }
        }
    }
/*output:Hello!
        Hello!
       I'm Studying
      My age is :21
      Hello!
      I'm explaining */


