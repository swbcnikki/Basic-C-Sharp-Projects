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
            Console.WriteLine("Anonymous Income Comparison Program"); //name of program
            Console.ReadLine();// keeps the console display open so we can see the result

            //identifying the first subject
            Console.WriteLine("Person 1");
            Console.ReadLine();

            //Question in string, hourly rate in integer
            Console.WriteLine("Hourly Rate?"); 
            Console.ReadLine();
            int hourlyRate1 = 60; //integer variable and value
            Console.WriteLine(hourlyRate1); //passing in the variable
            Console.ReadLine();

            //Question in string, hours worked in integer
            Console.WriteLine("Hours worked per week? ");
            Console.ReadLine();
            int hoursWorked1 = 80; //integer variable and value
            Console.WriteLine(hoursWorked1); //passing in the variable
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

            //multiplying the rate, hours per week and weeks in a year
            int product1 = 60 * 80 * 52; 
            Console.WriteLine(product1);//value of the variable after the operation above
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            Console.ReadLine();

            int product2 = 50 * 90 * 52;
            Console.WriteLine(product2);
            Console.ReadLine();

            //comparing the salaries
            Console.WriteLine("Does Person 1 make more money than  Person 2");
            Console.ReadLine();

            //boolean to determine which is greater and to answer the true/false question of who makes more
            bool moMoney = product1 > product2;
            Console.WriteLine(moMoney);
            Console.ReadLine();
        }
    }
}
