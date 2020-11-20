using System;
using System.Linq;

namespace _04.substrings
{
    class Program
    {
        static void Main()
        {
            string text = "Pesho";
            string newString = text.Replace("Pe", "Go")
                                   .Replace("sho", "Ivanov")
                                   .Replace("Ivanova", "Maria") //here replaces any found in string 
                                                                //first param with second parameter
                                   .Substring(2);//Here we take from the end result  
                                                 // text string from 2nd index till the end of text string //


            Console.WriteLine(newString);

        }
    }
}
