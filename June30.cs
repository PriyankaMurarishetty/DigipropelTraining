using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Text;

namespace Assignment3
{
    class June30
    {
        static void Main(string[] args)
        {
            June30 sr = new June30();
            
            sr.Sortstralphabet();
            sr.Strlength();
            sr.Wordsnum();
            sr.Positionstr();
            sr.Uppercase();
            sr.Alternate();
            sr.Reverse();
            sr.Enumprogram();
            sr.Pattern();
            
        }
        /*2. program to sort the words in alphabetical order*/
        public void Sortstralphabet()
        {

            List<string> names = new List<string>();
            names.Add("Laxmi");
            names.Add("Geetha");
            names.Sort();
            Console.WriteLine(string.Join(",", names));

        }
        /* 4.program to find the length of the string*/
        public void Strlength()
        {
            string str1;
            Console.WriteLine("enter the string to check the length");
            str1 = Console.ReadLine();
            int length = str1.Length;
            Console.WriteLine("the length of the input string is:" + length);
        }
        /*input:
        awesome
        output:the length of input string is :7 */
        /*5.program to find number of words in a string*/
        public void Wordsnum()
        {
            string Message;
            Console.WriteLine("enter the input string to count the number of words");
            Message = Console.ReadLine();
            int number = 0;
            for (int i = 0; i < Message.Length - 1; i++)
            {
                if (Message[i] == ' ' && char.IsLetter(Message[i + 1]) && (i > 0))
                {
                    number++;
                }
            }
            number++;
            Console.WriteLine("The number of words in the string are:" + number);

        }
        /*input:a beautiful morning
        output:number of words in the string are:3 */
        
        /*6.program to find  the position of a particular word*/
        public void Positionstr()
        {
            string sentence, word;
            Console.WriteLine("enter the input string to check the position of a word");
            sentence = Console.ReadLine();
            Console.WriteLine("enter the word to check:");
            word = Console.ReadLine();
            Console.WriteLine("the position of the word is:" + test(sentence, word));
        }
        public static int test(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }
        /* input:jack nd jill went up the hill
        positon of word jill
        output:3*/
        /*7.program to convert first letter of a word to uppercase*/
        public void Uppercase()
        {
            string message;
            Console.WriteLine("enter the string to convert to uppercase:");
            message = Console.ReadLine();
            Console.WriteLine("the output string after converting to uppercase:" + test(message));

        }
        public static string test(string message)
        {
            return string.Join(" ", message.Split(' ').Select(message => char.ToUpper(message[0]) + message.Substring(1)));
        }
        /*input:family
        output:Family*/
        /*8.program to alternate each letter*/
        public void Alternate()
        {
            string str1;
            Console.WriteLine("enter the input string to alternate the letters:");
            str1 = Console.ReadLine();
            Console.WriteLine("the output string after alternating letters is:" + check(str1));
        }
        public static string check(string str1)
        {
            string text = str1.Replace(" ", " ");
            string result = "";
            result += char.ToUpper(str1[0]);
            for (int i = 1; i < str1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += char.ToUpper(text[i]);
                }
                else if (i % 2 != 0 && char.IsUpper(text[i]))
                {
                    result += char.ToLower(text[i]);
                }
                else result += text[i];
            }
            result = result.Replace(" ", " ");
            return result;
        }/*input:digipropel
        output:DiGiPrOpEl*/
        /*9.program to reverse the string of even length*/
        public void Reverse()
        {
            string str2;
            Console.WriteLine("enter the input string to resverse");
            str2 = Console.ReadLine();
            Console.WriteLine("the output reverse string is:" + Reverse(str2));
        }
        public static string Reverse(string str2)
        {
            return string.Join(" ", str2.Split(' ').Select(str2 => str2.Length % 2 != 0 ? str2 : new string(str2.Reverse().ToArray())));

        }/*input:big tree
        output:big eert*/
        /*1. program for enum*/
        enum days { Sun, Mon, Tue, Wed, Thur, Fri, Sat }
        public void Enumprogram()
        {
            int Weekdaystart = (int)days.Mon;
            int Weekdayend = (int)days.Fri;

            Console.WriteLine("Mon:{0}", Weekdaystart);
            Console.WriteLine("Fri:{0}", Weekdayend);

        }

        /*3.program to draw a B pattern*/
        public void Pattern()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'B' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        
    }

}












