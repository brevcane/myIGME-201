using ColorsAndNumbers.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ColorsAndNumbers
{
    namespace Colors
    {
        enum EColors
        {
            red,
            orange,
            yellow,
            green,
            blue,
            indigo,
            violet
        }
    }

    namespace Numbers
    {

        enum ENumbers
        {
            one,
            two,
            three,
            four,
            five,
            six,
            seven
        }
    }
}

namespace FavoriteColorAndNumber
{
    using ColorsAndNumbers.Colors;

    using ColorsAlias = ColorsAndNumbers.Colors;
    //"Using" allows namespaces to be accessed directly or with an alias.
    static internal class Program
        //For the first unit make sure all classes and methods are static.
    {
        // WriteMyVar writes out a given integer
        static void WriteMyVar(ref int nParameter)
        {
            Console.WriteLine(nParameter);

            nParameter = 42;
        }
        static void Main(string[] args)
        {
            ColorsAlias.EColors eColors;
            ColorsAndNumbers.Numbers. ENumbers eNumbers;



            Console.WriteLine("");
            //Commenting out using system will break Console commmands.

            int myInt = 0;
            int anotherInt = 2;
            string sFavoriteColor = null;
            string sFavoriteNumber = "";
            int? nFavoriteNumber = null;
            bool bValid = false;

            anotherInt = myInt;

            WriteMyVar(ref myInt);
            //Using a reference variable means that anything changed to nParameter also happens to my Int.

            // 3 errors
            // 1. syntax errors (missing semi)
            // 2. logical (code works but doesn't do the right thing)
            // 3. run-time errors (code crashes!)


            // Prompt the user for their favorite color
            Console.Write("Hello! Please enter your favorite color: ");

            // Read the favorite color from the user and store it in a variable
            sFavoriteColor = Console.ReadLine();

            // Prompt the user for their favorite number
            Console.Write("Hello! Please enter your favorite number: ");

            // Read the favorite number into a variable
            sFavoriteNumber = Console.ReadLine();

            //while(bValid == false)
            // int nFavoriteNumberInt = 0;
            while (nFavoriteNumber == null)
            {
                try
                {
                    // nFavoriteNumber = Convert.ToInt32(sFavoriteNumber);
                    // bValid = int.TryParse(sFavoriteNumber, out nFavoriteNumber);
                    // Try parse won't work since nFavorite number is an "int?" data type
                    // Try using a new int variable. bValid tells us whether our variable was changed or not.
                    // bValid = int.TryParse(sFavoriteNumber, out nFavoriteNumberInt);

                    nFavoriteNumber = int.Parse(sFavoriteNumber);
                    // Parses sFavoriteNumber from a string into an int
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                    sFavoriteNumber = Console.ReadLine();
                }
            }

            // set favorite color to lower case
            sFavoriteColor = sFavoriteColor.ToLower();   


            // change the console output color to match their favorite color

            // a switch statement is similar to an if statement, but it easier to use.
            switch(sFavoriteColor)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case "purple":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }


            // A loop that outputs their favorite color, their favorite number of times
            for (int i = 0; i < nFavoriteNumber; i++)
            {
                Console.WriteLine("[" + (i + 1) + "/" + nFavoriteNumber + "] Your favorite color is " + sFavoriteColor + "!");

                // two different ways to concatinate different data types
                // Console.WriteLine($"Your favorite color is {sFavoriteColor + "!"}");
                // Console.WriteLine("Your favorite color is {0}{1}", sFavoriteColor, "!");
            }




            
        }
    }
}
