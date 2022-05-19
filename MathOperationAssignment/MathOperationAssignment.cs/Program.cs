using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {   
            //demonstrate multiplication
            int weeklyHours = 100;
            int hourlyRate = 50;

            int product = 100 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            //demonstrate addition
            byte airTicket = 150;
            byte bagFee = 25;

            byte sum = 150 + 25;
            Console.WriteLine(sum);
            Console.ReadLine();

            //demonstrate division with decimal number using double
            double totalJuice = 100;
            double eachGlass = 12.5;


            double quotient = 100 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();


            //demonstrate greater than
            int retirementAge = 65;
            int currentAge = 50;

            bool ofAge = retirementAge > currentAge;
            Console.WriteLine(ofAge);
            Console.ReadLine();

            //demonstrate finding remainders from division
            uint daysInMonth = 31;
            uint daysInWeek = 7;

            uint remainder = 31 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
