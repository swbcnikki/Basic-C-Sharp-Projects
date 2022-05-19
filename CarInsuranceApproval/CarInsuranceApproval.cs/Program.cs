using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Qualification"); //title
            Console.ReadLine(); //prevents console window from closing itself

            //minimum age for insurance is 15
            Console.WriteLine("What is your current age?");
            Console.ReadLine();

            //setting comparison variables
            int qualifyingAge = 15;
            int currentAge = 17;

            //comparison boolean. Is current age greaterthan or equal to qualifying age? True
            bool ofAge = currentAge >= qualifyingAge;
            Console.WriteLine(currentAge);
            Console.ReadLine();

            //maximum for DUI is 0
            Console.WriteLine("Have you ever had a DUI?");
            Console.ReadLine();

            //comparison variables
            int disqualifyingDUI = 1;
            int yourDUI = 0;

            //comparison boolean. Is your number of DUIs 0? True
            bool DUI = yourDUI >= disqualifyingDUI;
            Console.WriteLine(DUI);
            Console.ReadLine();

            // max speeding tickets is 3
            Console.WriteLine("How many speeding tickets do you have?");
            Console.ReadLine();

            //comparison variables
            int maxTickets = 3;
            int yourTickets = 2;

            //comparison boolean. Is your number of tickets equal to or less than 3? True
            bool tickets = maxTickets <= yourTickets;
            Console.WriteLine(yourTickets);
            Console.ReadLine();

            //determining boolean logic
            Console.WriteLine("Do you qualify?");
            Console.ReadLine();
            Console.WriteLine(true && true && true);
            Console.ReadLine();
        }
    }
}
