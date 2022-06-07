using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment.cs
{
    class Program
    {
        //Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instance

            employee.FirstName = "Sample"; // initializing the first name
            employee.LastName = "Student"; // initializing the last name
            employee.SayName(); // calling superclass method 

            Console.ReadLine();

            

        }
    }
}
