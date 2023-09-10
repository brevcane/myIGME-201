using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            // Prompt the user for the start value for imagCoord
            Console.WriteLine("Enter the starting value for imagCoord: ");
            double startImagCoord = double.Parse(Console.ReadLine());

            // Prompt the user for the end value for imagCoord
            Console.WriteLine("Enter the end value for imagCoord, make sure it is less than your starting value: ");
            double endImagCoord = double.Parse(Console.ReadLine());

            // Prompt the user for the start value for realCoord
            Console.WriteLine("Enter the starting value for realCoord: ");
            double startRealCoord = double.Parse(Console.ReadLine());

            // Prompt the user for the end value for imagCoord
            Console.WriteLine("Enter the end value for realCoord, make sure it is greater than your starting value: ");
            double endRealCoord = double.Parse(Console.ReadLine());

            // Replaced constant variables with new user inputted values
            for (imagCoord = startImagCoord; imagCoord >= endImagCoord; imagCoord -= (startImagCoord-endImagCoord)/48)
            {
                for (realCoord = startRealCoord; realCoord <= endRealCoord; realCoord += (endRealCoord-startRealCoord)/80)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
