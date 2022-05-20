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
            
            //minimum age for insurance is 15
            Console.WriteLine("What is your current age?");
            int currentAge = Convert.ToInt32(Console.ReadLine());

            bool ofAge = currentAge >= 15;
           
            //maximum for DUI is 0
            Console.WriteLine("Do you have any DUI? Please input true or false");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

           // max speeding tickets is 3
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool maxTickets = tickets <= 3;

            //determining boolean logic
            Console.WriteLine("Did you qualify?");
            bool qualify = ofAge && DUI == false && maxTickets;
            Console.WriteLine(qualify);
            Console.ReadLine();
        }
    }
}
