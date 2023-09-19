using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleQuotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt the user for a string
            Console.WriteLine("Input a string: ");

            // store the string into a variable
            string input = Console.ReadLine();

            // create an empty string variable
            string newInput = "";

            string[] words = input.Split();

            for(int i = 0; i < words.Length; i++)
            {
                newInput += '"' + words[i] + '"' + ' ';
            }

            Console.WriteLine("New string: " + newInput);
        }
    }
}
