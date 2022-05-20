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
            Console.WriteLine("Anonymous Income Comparison Program\n"); //name of program            

            //identifying the first subject
            Console.WriteLine("Person 1\n");            

            //Question in string, hourly rate in integer
            Console.WriteLine("What is the hourly Rate?\n");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine()); //integer variable and value

            //Question in string, hours worked in integer
            Console.WriteLine("Hours worked per week?\n ");           
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine()); //integer variable and value

            
            Console.WriteLine("Person 2");

            Console.WriteLine("What is the hourly Rate?\n");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Hours worked per week? ");           
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1\n");            

            //multiplying the rate, hours per week and weeks in a year
            int product1 = hourlyRate1 * hoursWorked1 * 52;
            Console.WriteLine(product1);//value of the variable after the operation above            

            Console.WriteLine("Annual Salary of Person 2\n");

            int product2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine(product2);            

            //comparing the salaries
            Console.WriteLine("Does Person 1 make more money than  Person 2?\n");
            
            //boolean to determine which is greater and to answer the true/false question of who makes more
            bool moMoney = product1 > product2;
            Console.WriteLine(moMoney);
            Console.ReadLine(); // prevents the console window from closing itself

        }
    }
}
