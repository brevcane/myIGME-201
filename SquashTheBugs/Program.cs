using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0
            // Syntax error, there is a missinge semicolon
            // Logical error, setting i to an int will make it impossible for future calculations to produce doubles ex. (3/2)
            double i = 0;

            // declare string to hold all numbers
            string allNumbers = null;

            // loop through the numbers 1 through 10
            // for (i = 1; i < 10; ++i)
            // Logical error, the "i < 10" will only loop through 1 to 9 instead of 1 to 10.
            for (i = 1; i <= 10; ++i)
            {
                // declare string to hold all numbers
                // string allNumbers = null;
                // Both a logical error and run-time error
                // The logical error is how each time the loop goes through allNumbers is being set back to null, losing whatever numbers we concatenated
                // The run-time error is how we can't access allNumbers outside of the for loop since we created the variable inside of the loop.

                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = ");
                // Run-time error, without seperating mathmatical operations from string operations we are trying to subtract an int from a string
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                // Console.WriteLine(i / (i - 1));
                // Logical error, we need to account for i - 1 being 0. As this will return a divide by zero exception and stop our code.

                try
                {
                    Console.WriteLine(i / (i - 1));
                } catch (DivideByZeroException)
                {
                    System.Console.WriteLine(i + "/" + (i - 1) + " does not exist.");
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1;
                // Logical error, we do not need to increment the counter as the for loop does this for us.
            }

            // output all numbers which have been processed
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            // Syntax error, we aren't concenating our list of numbers with our string. We need to add a " + " sign.
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

