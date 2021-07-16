using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
        public class StudentTeacherTest
        {
            public void Inheritance()
            {
                //Creating an object for person class
                Person pr = new Person();
                pr.Greeting();
            //creating an object for student class
                Student st = new Student();
                st.SetAge(21);
                st.Greeting();
                st.ShowAge();
                st.Study();
            //creating an object for teacher class
                Teacher tr = new Teacher();
                tr.SetAge(45);
                tr.Greeting();
                tr.Explain();

            }
        }
      //defining the class person
        public class Person
        {
            protected int age;
            public void Greeting()
            {
                Console.WriteLine("Hello!");
            }
            public void SetAge(int n)
            {
                age = n;
            }
        }
    //inheriting from class Person
        public class Student:Person
        {
            public void Study()
            {
                Console.WriteLine("I am studying");//displaying the action of student
            }
            public void ShowAge()
            {
            Console.WriteLine("My age is" + age);//displaying the age
            }
        }

        public class Teacher:Person
        {
            public void Explain()
            {
                Console.WriteLine("I am Explaining");//displaying the action of teacher
            }
        }
    }
/*output:
 Hello!
Hello!
My age is21
I am studying
Hello!
I am Explaining  */

