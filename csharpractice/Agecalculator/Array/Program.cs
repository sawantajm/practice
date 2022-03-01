using System;
using System.Collections.Generic;
namespace Array
{
    public class ArraOpration
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string co="";
           
            int j;
           
            Console.WriteLine(" ");
            for ( j = word.Length; j > 0; j--)
            {
                co+=word[j-1].ToString();
            }
            string s = "";
            if(co==word)
            {
                for (int i = 0; i < co.Length; i++)
                {

                    if (co[i] == '?')
                    {
                        s = co[i + 1].ToString();
                        
                    }

                }
                Console.WriteLine(" String is Palindrome");

            }
            else
            {
                Console.WriteLine("String is not PalinDrome");
            }
           

        }
    }
}