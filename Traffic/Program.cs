using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    internal class Program
    {
        static void AddPassenger(IPassengerCarrier carrier)
        {
            carrier.LoadPassenger();

            System.Console.WriteLine(carrier.ToString());
        }
        static void Main(string[] args)
        {
            // create a new IPassengerCarrier
            IPassengerCarrier carrier = new SUV();

            // Run the AddPassenger method
            AddPassenger(carrier);

            // create a new IHeavyLoadCarrier
            // IHeavyLoadCarrier heavyCarrier = new FreightTrain();

            // Run the AddPassengerMethod on an object that did not inherit the IPassengerCarrier
            // AddPassenger(heavyCarrier);
            // I get an error as AddPassenger cannot take a reference to a different variable


        }
    }
}
