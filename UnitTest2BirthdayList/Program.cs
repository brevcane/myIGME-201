using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2BirthdayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedList to store friend's names and birthdates
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();

            // Add some data to the SortedList
            friendBirthdays.Add("John", new DateTime(1990, 4, 15));
            friendBirthdays.Add("Alice", new DateTime(1985, 8, 22));
            friendBirthdays.Add("Bob", new DateTime(1995, 3, 10));

            // Output the contents of the SortedList
            foreach (var pair in friendBirthdays)
            {
                string name = pair.Key;
                DateTime birthdate = pair.Value;
                string formattedBirthdate = birthdate.ToString("MM/dd/yyyy");

                Console.WriteLine($"{name}'s birthday: {formattedBirthdate}");
            }
        }
    }
}
