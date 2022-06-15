using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadAssignment.cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employees emp1 = new Employees(); // instance of employee record
            Employees emp2 = new Employees(); // instance of employee record

            emp1.empId = 1001;
            emp1.LastName = "smith";
            emp1.FirstName = "John";

            emp2.empId = 1002;
            emp2.LastName = "Smith";
            emp2.FirstName = "John";

            Console.ReadLine();

            if (emp1 == emp2)
            {
                Console.WriteLine("This is a match. This is the same person.");
            }
            else
            {
                Console.WriteLine("These are 2 different people");
            }
            
            Console.ReadLine();
        }  
                        
    }
}
