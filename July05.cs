using System;
namespace Assignment4
{
    public class July05
    {
        public static void Main(string[] args)
        {
            July05 ds = new July05();
            ds.Display();
           July05_1 cr = new July05_1();
            cr.Constructor();
            StudentProfessorTest sr = new StudentProfessorTest();
            sr.Inheritance();
            July05_3 lp = new July05_3();
            lp.Leapyear();
            July05_4 cm = new July05_4();
            cm.Compare();
            July05_5 ran = new July05_5();
            ran.Random();
            PhotobookTest al = new PhotobookTest();
            al.Album();
            File fl = new File();
            fl.Displayfile();
            July05_8 br = new July05_8();
            br.Reader();
            July05_9 dr = new July05_9();
            dr.Diectrory();
        }
        public void Display()
        {
            int total = 3, i;
            Person[] persons = new Person[total];
            for (i = 0; i < total; i++)
            {
                persons[i] = new Person()
                {
                    name = Console.ReadLine()
                };
            }

            for (i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
            Console.ReadLine();
        }
        public class Person
        {
            public string name { get; set; }
            public override string ToString()
            {
                return "Hello! My name is :" + name;
            }
        }
    }
}
/*output:john
        sana
        priya
Hello! My name is :john
Hello! My name is :sana
Hello! My name is :priya*/







