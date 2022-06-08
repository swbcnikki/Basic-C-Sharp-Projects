using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee2 employee2 = new Employee2(); // instantiating

            employee2.FirstName2 = "Sample2"; // initializing the first name
            employee2.LastName2 = "Student2"; // initializing the last name
            employee2.SayName2(); // calling method

            employee2.Quit2();

            Console.ReadLine();
        }
    }
}
