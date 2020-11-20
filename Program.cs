using System;
using System.Linq;

namespace _04.substrings
{
    class Program
    {
        static void Main()
        {
            string text = "Peshoe";
            // text.Replace('e', '!'); //take the string text, everywhere You see symbol-e, put symbol !;
            // Console.WriteLine(text);//dont work, it creates new string! -> new variable
            string newString = text.Replace('e', '!');
            Console.WriteLine(newString);

        }
    }
}
