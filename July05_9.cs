using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Assignment4
{
    class July05_9
    {
        public void Diectrory()
        {
            CreateDirectory();
            CreateFile();
            Console.ReadKey();

        }
        //creating directory
        static void CreateDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo("D:/Example");
            try
            {
                //to check directory exists
                if(dir.Exists)
                {
                    Console.WriteLine("Directory Already Exists");
                    Console.WriteLine("Directory Nmae:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on" + dir.CreationTime);
                    Console.WriteLine("Last Accessed" + dir.LastAccessTime);
                }
                else
                //creating irectory if it doesn't exists
                {
                    dir.Create();
                    Console.WriteLine("Directory Created Successfully.Information of Directory:");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on " + dir.CreationTime);
                    Console.WriteLine("LastAccessed" + dir.LastAccessTime);
;                }
            }
            catch(DirectoryNotFoundException d)
            {
                Console.WriteLine(d.Message.ToString());

            }
        }
        static void CreateFile()
        {
            FileInfo file = new FileInfo("D:\\Example\\test.txt");
            using(StreamWriter sw=file.CreateText())
            {
                sw.WriteLine("Hello File Handling");
            }
            //displaying file info
            Console.WriteLine("File Create on:" + file.CreationTime);
            Console.WriteLine("Directory Name" + file.DirectoryName);
            Console.WriteLine("FullName:" + file.FullName);
            Console.WriteLine("File is LastAccessed on :" + file.LastAccessTime);
        }
    }
}
