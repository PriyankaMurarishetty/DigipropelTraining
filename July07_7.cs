using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace Assignment5
{
    class July07_7
    {
       public void Search()
        {
            FileStream inFile = new FileStream(@"C:\Users\dpladmin\Desktop\Priyanka.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string record;
            string input;
            Console.Write("Enter the word in the line to  find :\n");
            input = Console.ReadLine();
            try
            {
                //the program reads the record and displays it on the screen
                record = reader.ReadLine();
                while (record != null)
                {
                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                    }


                    record = reader.ReadLine();
                }
            }
            finally
            {
                //after the record is done being read, the progam closes
                reader.Close();
                inFile.Close();
            }


            Console.ReadLine();
        }
    }
}

