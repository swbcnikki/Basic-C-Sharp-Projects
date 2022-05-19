using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            Console.ReadLine();
            int hourlyRate1 = 60;
            Console.WriteLine(hourlyRate1);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week? ");
            Console.ReadLine();
            int hoursWorked1 = 80;
            Console.WriteLine(hoursWorked1);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            Console.ReadLine();
            int hourlyRate2 = 50;
            Console.WriteLine(hourlyRate2);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week? ");
            Console.ReadLine();
            int hoursWorked2 = 90;
            Console.WriteLine(hoursWorked2);
            Console.ReadLine();

        
            Console.WriteLine("Annual Salary of Person 1");
            Console.ReadLine();

            int product1 = 60 * 80 * 52;
            Console.WriteLine(product1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            Console.ReadLine();

            int product2 = 50 * 90 * 52;
            Console.WriteLine(product2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than  Person 2");
            Console.ReadLine();

            bool moMoney = product1 > product2;
            Console.WriteLine(moMoney);
            Console.ReadLine();
        }
    }
}
