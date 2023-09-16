using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Net;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            // Added a new string variable "play" that will be used when prompting the user if they want to play
            string play = "";

            string finalStory = "";

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            // prompt the user for their name, and whether they want to play Mad Libs or not
            do
            {
                Console.Write("Would you like to play Mad Libs? Please enter yes or no. ");
                play = Console.ReadLine();
            } while (play != "no" && play != "yes");

            // Depending on the player's response I will either end the game or allow them to move on
            if (play == "no")
            {
                Console.WriteLine("Goodbye!");
            } else
            {
                Console.WriteLine("What's your name? ");
                string name = Console.ReadLine();
                do
                {
                    Console.Write("Hello " + name + "! There are six stories to choose from. Please enter a number from 1-6 to select a story: ");
                    nChoice = int.Parse(Console.ReadLine()) - 1;
                } while (nChoice < 1 && nChoice > 6);


                // split the Mad Lib into separate words
                string[] words = madLibs[nChoice].Split(' ');

                foreach (string word in words)
                {
                    // if word is a placeholder
                    if (word[0] == '{')
                    {
                        string replaceWord = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                        // prompt the user for the replacement
                        Console.Write("Input a {0}: ", replaceWord);
                        // and append the user response to the result string
                        finalStory += Console.ReadLine() + " ";
                    }
                    // else append word to the result string
                    else
                    {
                        finalStory += word + " ";
                    }
                }

                // print out the final story
                Console.Write(finalStory);
            }
             
        }
    }
}