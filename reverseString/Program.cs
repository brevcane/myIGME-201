using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create needed variables
            string reversedInput = "";

            // prompt the user for a string
            Console.Write("Enter a string: ");

            // store the string into a variable
            string input = Console.ReadLine();

            // create an array of all the characters in the string
            char[] charArray = input.ToCharArray();
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                string s = charArray[i].ToString();
                reversedInput += s;
            }

            Console.WriteLine(reversedInput);
        }
    }
}
