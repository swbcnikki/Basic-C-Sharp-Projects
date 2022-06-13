using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Prints the current date and time to the console.

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

            //Asks the user for a number
            Console.WriteLine("Please type in a number that is between 1 and 10.");
            int number = Convert.ToInt32(Console.ReadLine());

            //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2
            DateTime later = now.AddHours(number);
            Console.WriteLine(" We have added {0} hours to the current time and it now says it is {1}.", number, later);
            Console.ReadLine();
        }




    }
}
