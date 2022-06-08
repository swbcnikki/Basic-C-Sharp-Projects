using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "Sample"; // initializing the first name
            employee.LastName = "Student"; // initializing the last name
            employee.SayName(); // calling method

            Console.ReadLine();
        }
    }
}
