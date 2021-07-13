using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class PhotobookTest
    {
        public void Album()
        {
            Photobook myalbum = new Photobook();
            Console.WriteLine(myalbum.GetNumberPages());
            Photobook myalbum1 = new Photobook(24);
            Console.WriteLine(myalbum1.GetNumberPages());
            Superphotobook myBigphotoalbum = new Superphotobook();
            Console.WriteLine(myBigphotoalbum.GetNumberPages());
        }
    }
        public class Photobook
        {
           protected int numPages;
           
            public Photobook()
            {
                numPages = 16;
            }
            public Photobook(int numPages)
            {
                this.numPages = numPages;
            }
            public int GetNumberPages()
            {
            Console.WriteLine("the number of pages are:");
                return numPages;

            }
        }
    public class Superphotobook : Photobook
    {
        public Superphotobook()
        {
            
            numPages = 64;

        }
    }
} 
  



    

