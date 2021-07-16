using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
  //defining an encrypt class
        public class Encrypter
        {
            public static string Encrypt(string text)
            {
                int letterInt = 0;
                char letter = ' ';
                string textencrypter = "";
                for(int i=0;i<text.Length;i++)
                {
                    letterInt = (int)text[i] + 1;//converting the alphabel to ASCIIint and adding 1
                    letter = (char)letterInt; //converting the ASCII value to char alphabet again
                    textencrypter += letter.ToString(); //joining the alphabet
                }
                return textencrypter;

            }
            public static string Decrypt(string text)
            {
                int letterInt = 0;
                char letter = ' ';
                string textdecrypter = "";
                for(int i=0;i<text.Length;i++)
                {
                    letterInt = (int)text[i] - 1;
                    letter = (char)letterInt;
                    textdecrypter += letter.ToString();
                }
                return textdecrypter;
            }
        }
        public class TextEncrypter
        {
            public void EncryptDecrypt()
            {
                bool debug =true;
            Console.WriteLine("enter the word to encrypt");
                string  TextEncrypted = Console.ReadLine();
                string newtext = Encrypter.Encrypt(TextEncrypted);
                Console.WriteLine("TextEncrypted:" + newtext);
                string TextDecrypted = Encrypter.Decrypt(newtext);
                Console.WriteLine("TextDecrypted: " + TextDecrypted);
                if (debug)
                    Console.ReadLine();
            }
        }
}
/*output:
enter the word to encrypt
hello
TextEncrypted:ifmmp
TextDecrypted: hello   */
