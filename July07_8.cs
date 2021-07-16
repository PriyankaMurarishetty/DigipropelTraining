using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
   //creating a class for performing the actions 
        public class TestTables
        {
            public void Tables()
            {
                
                Table[] mytable = new Table[10];
                Random ran = new Random();
            for (int i = 0; i < mytable.Length; i++)
            {
                mytable[i] = new Table(ran.Next(50, 201), ran.Next(50, 201));
                mytable[i].ShowData();
            }
                    Console.ReadLine();
            }
        }
        public class Table
        {
            private float width, height;//declaring the variables
                public Table(float width, float height)//parametarised constructor defined
                {
                    this.width = width ;
                    this.height = height;
                }
                public float Width //to setup and get the width
                {
                set { width = value; }
                get { return width; }
                }
            public float Height // to set and get the height
            {
                set { height = value; }
                get { return height; }
            }
        //display the data
            public void ShowData()
            {
                Console.WriteLine("Width:{0},Height :{1}" , width, height);
            }
            

        }
      
    }
/*output:
 Width:79,Height :161
Width:138,Height :162
Width:113,Height :133
Width:136,Height :170
Width:102,Height :122
Width:131,Height :159
Width:67, Height :169
Width:50, Height :167
Width:138,Height :172
Width:132,Height :67    */

