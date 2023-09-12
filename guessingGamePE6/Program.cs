using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGamePE6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a variable that will randomly select a number between 0 and 100 whenever the code is ran
            Random rand = new Random();
            int randomNumber = rand.Next(0, 101);

            // Printing the random number at the top of my program for testing purposes
            // Console.WriteLine(randomNumber);

            // A friendly message to let the user know the game has started and provides a brief description
            Console.WriteLine("GUESSING GAME: Try to guess a number from 1-100 in 8 tries");

            // Create variables that will help me execute the main code

            // An int that can tell me how many guesses the user has left
            int nGuesses = 0;

            // A bool that can tell me if the user is correct
            bool correct = false;

            // An int of the user's current guess
            int? guess = null;

            // A bool used to determine if the user's input was valid
            bool isValid = false;

            // Using a while loop prompt the user to guess the number until they've guessed 8 times or gotten the number correct
            // At the end of the loop isValid is reset to false and the number of guesses is incremented
            do
            {
                // tells the user how many guesses they have left and saves their guess
                Console.Write("GUESS [" + (nGuesses + 1) + "/8] : ");

                // checks for varying user errors when inputing guesses
                while (!isValid)
                {
                    
                    try
                    {
                        guess = int.Parse(Console.ReadLine());
                        if (guess < 0 || guess > 100)
                        {
                            Console.WriteLine("ERROR. Please input an integer between 0 and 100.");
                        } else
                        {
                            isValid = true;
                        }
                            

                    }
                    catch
                    {
                        System.Console.WriteLine("ERROR. Please input an integer between 0 and 100.");
                    }
                }
                
                

                // using if statements tell the user if their guess was too high, low, or just right
                if(guess > randomNumber)
                {
                    Console.WriteLine("Too high");
                    isValid = false;
                    nGuesses++;
                    if(nGuesses == 8)
                    {
                        Console.WriteLine("You have reached 8 guesses, the correct number was " + randomNumber + ", game over.");
                    }
                }
                else if(guess < randomNumber)
                {
                    Console.WriteLine("Too low");
                    isValid = false;
                    nGuesses++;
                    if (nGuesses == 8)
                    {
                        Console.WriteLine("You have reached 8 guesses, the correct number was " + randomNumber + ", game over.");
                    }
                }
                else if(guess == randomNumber)
                {
                    // provides a seperate response if you manage to guess the number on the first try due to guess/guesses 1/more than 1
                    if(nGuesses == 0)
                    {
                        Console.WriteLine("Correct! You won in 1 guess.");
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Correct! You won in " + (nGuesses + 1) + " guesses.");
                        correct = true;
                    }
                }
                

            }while (nGuesses < 8 ^ correct);
        }
    }
}
