using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _3questions
{
    internal class Program
    {

        static Timer timer;
        static bool timeOut = false;

        static void Main(string[] args)
        {
            // Question number bool variable
            bool bQuestion = false;

            // Play again bool variable
            bool playAgain = true;

            // Question number int variable
            int? nQuestion = null;

            // Answer variables
            string qOneAnswer = "black and white";
            string qTwoAnswer = "42";
            string qThreeAnswer = "What do you mean? African or European swallow?";

            // create timer
            timer = new Timer(5000);
            timer.Elapsed += new ElapsedEventHandler(TimesUp);

            // Create a while loop that will end when the user doesn't want to play again
            while(playAgain)
            {
                // Prompt the user to select a question number
                Console.Write("Choose your question (1-3): ");

                // Store the given number into nQuestion, if the user doesn't input 1, 2, or 3, then prompt them to enter 1, 2, or 3.
                while (!bQuestion)
                {
                    nQuestion = int.Parse(Console.ReadLine());
                    if (nQuestion == 1 || nQuestion == 2 || nQuestion == 3)
                    {
                        bQuestion = true;
                    }
                    else
                    {
                        Console.WriteLine("Please input 1, 2, or 3.");
                    }
                }

                if (nQuestion == 1)
                {
                    Console.WriteLine("You have 5 seconds to answer the following question: ");
                    Console.WriteLine("What is your favorite color? ");

                    timer.Start();

                    string response = Console.ReadLine();

                    timer.Stop();

                    if (response == qOneAnswer && !timeOut)
                    {
                        System.Console.WriteLine("Correct!");
                    }
                    else if (response != qOneAnswer && !timeOut)
                    {
                        Console.WriteLine("Wrong! The answer is: " + qOneAnswer);
                    }
                    else
                    {
                        Console.WriteLine("The answer is: " + qOneAnswer);
                    }             
                }

                if (nQuestion == 3)
                {
                    Console.WriteLine("You have 5 seconds to answer the following question: ");
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow? ");

                    timer.Start();

                    string response = Console.ReadLine();

                    timer.Stop();

                    if (response == qThreeAnswer && !timeOut)
                    {
                        System.Console.WriteLine("Correct!");
                    }
                    else if (response != qThreeAnswer && !timeOut)
                    {
                        Console.WriteLine("Wrong! The answer is: " + qThreeAnswer);
                    }
                    else
                    {
                        Console.WriteLine("The answer is: " + qThreeAnswer);
                    }
                }

                if (nQuestion == 2)
                {
                    Console.WriteLine("You have 5 seconds to answer the following question: ");
                    Console.WriteLine("What is the answer to life, the universe and everything? ");

                    timer.Start();

                    string response = Console.ReadLine();

                    timer.Stop();

                    if (response == qTwoAnswer && !timeOut)
                    {
                        System.Console.WriteLine("Correct!");
                    }
                    else if (response != qTwoAnswer && !timeOut)
                    {
                        Console.WriteLine("Wrong! The answer is: " + qTwoAnswer);
                    }
                    else
                    {
                        Console.WriteLine("The answer is: " + qTwoAnswer);
                    }
                }

                

                nQuestion = null;
                bQuestion = false;
                timeOut = false;
                Console.WriteLine("Play again?");
                string sPlayAgain = Console.ReadLine();

                while (sPlayAgain != "i")
                {
                    if (sPlayAgain.StartsWith("n"))
                    {
                        playAgain = false;
                        sPlayAgain = "i";
                    }
                    else if (sPlayAgain.StartsWith("y"))
                    {

                        sPlayAgain = "i";
                    }
                    else
                    {
                        Console.WriteLine("Please enter yes or no");
                        sPlayAgain = Console.ReadLine();
                    }
                }
            }
   
            
            
        }

        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            // interrupt the user entry
            Console.WriteLine();

            // let the user know their time is up
            Console.WriteLine("Your time is up!");

            // prompt the user to hit enter
            Console.WriteLine("Please press enter.");

            // set the time out flag
            timeOut = true;

            // stop the timer, otherwise it will start over
            timer.Stop();
        }
    }
}
