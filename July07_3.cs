using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment5
{
      class StudentInformation
        {
         
          private string studentname;
          private string course;
            private int rollno;
            private int feepaid;
        private static double servicetax = 12.3;
            public StudentInformation(int rollno,string studentname, string course)//parametarised constructor defined
            {
                this.rollno = rollno;
                this.studentname = studentname;
                this.course = course;
            }
            public void Payment(int amount)//payment method calculates the feepaid
            {
                feepaid += amount;
            }
            public void Print()
            {
            //displaying the variables
                Console.WriteLine("STUDENTNAME :" +studentname);
                Console.WriteLine("ROLLNO :" +rollno);
                Console.WriteLine("FEEPAID:" +feepaid);
                Console.WriteLine("COURSE :" +course);
            Console.WriteLine("TOTALFEE:" + Totalfee);
            }
            public int DueAmount
            {
                get
                {
                    return Totalfee - feepaid;
                }
            }
        //returns the total fee
            public int Totalfee
            {
                get
                {
                 double total = course == "c#" ? 2000 : 3000;
                total = total + total * servicetax / 100;
                return (int) total;
                }
            }
        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
    }
    //defining class for C# course
        class UseStudent
        {
            public void Display()
            {
            Console.WriteLine("DETAILS OF C#");
                StudentInformation s = new StudentInformation(10, "GAURI", "c#");
                s.Payment(1000);
                s.Print();
                Console.WriteLine("DUEAMOUNT :" +s.DueAmount);

            }
        }
    //defining class for ASP.NET
    class UseStudent2
    {
        public void Display1()
        {
            Console.WriteLine("DETAILS OF ASP.NET");
            StudentInformation st = new StudentInformation(20,"PRIYA","ASP.net");
            st.Payment(1000);
            st.Print();
            Console.WriteLine("DUEAMOUNT:" +st.DueAmount);
            
        }
    }
    }
/*output:
 DETAILS OF C#:
STUDENTNAME :GAURI
ROLLNO :10
FEEPAID:1000
COURSE :c#
TOTALFEE:2246
DUEAMOUNT :1246

DETAILS OF ASP.NET:
STUDENTNAME :PRIYA
ROLLNO :20
FEEPAID:1000
COURSE :ASP.net
TOTALFEE:3369
DUEAMOUNT:2369   */




