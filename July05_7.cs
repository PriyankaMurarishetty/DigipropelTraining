using System;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;

   

namespace Assignment4._1
    {
 
class July05_7
    {
        const string fileName = "AppSettings.dat"; // defining constant string
        static void Main()
        {
           WriteDefaultValues();
            DisplayValues();
            
        }

        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {

                writer.Write("current date and time : " + DateTime.Now.ToString());

            }
        }

        public static void DisplayValues()
        {


            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    Console.WriteLine(reader.ReadString());

                }


            }
        }
    }
}
/* output :
   current date and time : 7/12/2021  7:30:22 PM*/
