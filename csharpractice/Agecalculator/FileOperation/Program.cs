using System;
using System.IO;
using System.Collections.Generic;


namespace Fileraeding
{
    class Filerad
    {

        static void readfile()
        {
            var path = @"C:/Users/sai/Desktop/Readfiletest.txt";
            if(!File.Exists(path))
            {
                using (StreamWriter sw =File.CreateText(path))
                {
                  sw.WriteLine("Country");
                    sw.WriteLine("America");
                    sw.WriteLine("India");
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine("Enter the country Name");
            string country = Console.ReadLine();
                string textfound ;
               
                    while((textfound = sr.ReadLine())!=null)
                {
                     Console.WriteLine(textfound);
                }

            }

            


        }
       static void Main()
        {
            readfile();
        }
    }
}