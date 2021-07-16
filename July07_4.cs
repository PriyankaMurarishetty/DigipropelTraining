using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    abstract class Course
        {
            protected string name;
            protected int duration;
            protected int coursefee;
            public Course(int duration, int coursefee, string name)
            {
                this.name = name;
                this.duration = duration;
                this.coursefee = coursefee;
            }

        protected Course(string name, int duration, int coursefee)
        {
            this.name = name;
            this.duration = duration;
            this.coursefee = coursefee;
        }

        public virtual void Print()
            {
                Console.WriteLine("name :"+name);
                Console.WriteLine("coursefee :"+coursefee);
                Console.WriteLine("duration :"+duration);
            }
            public abstract int GetTotalFee();

        }
    //class has parttime course details
       class PartTimeCourse : Course
        {
            private string timings;
        public PartTimeCourse(string name, int duration, int coursefee, string timings):base(name,duration,coursefee)//parametarised constructor defined
            {
                this.timings =timings ;
            }
           public override void Print()
            {
                base.Print();
                Console.WriteLine("timings:" + timings);
            }
            public override int GetTotalFee()
            {
                return (int) (coursefee * 0.90);
            }
        }
        //class for onsight course
        class Onsight : Course
        {
            private string Companyname;
            private int Students;
            public Onsight(string name,int duration,int coursefee,string Companyname,int Students):base(name,duration,coursefee)
            {
                this.Students = Students;
                this.Companyname = Companyname;
            }
            public override void Print()
            {
                base.Print();

                Console.WriteLine("companyname:" +Companyname);
                Console.WriteLine("number of students:"+Students);
            }
            public override int GetTotalFee()
            {
                return (int)(coursefee * 1.1);
            }
        }
    //creating a class to perform the testcase
        class Test
        {
            public void CourseInformation()
            {
            Console.WriteLine("ONSIGHT COURSE DETAILS");
                Course c = new Onsight("ASP.NET",30,5000,"ABCTECH",10);
                c.Print();
                Console.WriteLine("total fee :"+ c.GetTotalFee());
            Console.WriteLine("PARTTIME COURSE DETAILS");
                c = new PartTimeCourse("C#", 30, 3000, "7 - 9PM");
                c.Print();
                Console.WriteLine("totalfee" +c.GetTotalFee());
            }
        }
    }
/*output:
 ONSIGHT COURSE DETAILS:
name :ASP.NET
coursefee :5000
duration :30
companyname:ABCTECH
number of students:10
total fee :5500

PARTTIME COURSE DETAILS:
name :C#
coursefee :3000
duration :30
timings:7 - 9PM
totalfee :2700    */

