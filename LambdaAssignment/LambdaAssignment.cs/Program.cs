using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment.cs
{
   
    public class Program
    {
        public void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee{ ID = 1, Name = "Joe Smith"},
                new Employee{ ID = 2, Name = "Mary Meta"},
                new Employee{ ID = 3, Name = "Tim Twitter"},
                new Employee{ ID = 4, Name = "Amos Amazon"},
                new Employee{ ID = 5, Name = "Daisy Discord"},
                new Employee{ ID = 6, Name = "Alice Apple"},
                new Employee{ ID = 7, Name = "Matt Microsoft"},
                new Employee{ ID = 8, Name = "Ginger Google"},
                new Employee{ ID = 9, Name = "Zippy Zoom"},
                new Employee{ ID = 10, Name = "Joe Jones"},

            };

            foreach (string Name in employeeList)
            {
                if (Employee.Name.Contains("Joe"))
                {
                    Console.WriteLine(Name);
                    Console.ReadLine();

                }
            }

            Employee employee = employeeList.Find(numIDs => Employee.ID > 5)
        }
    }
}





/*Perform these actions and create a console app that includes the following:


In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name “Joe”.

Using a foreach loop, create a new list of all employees with the first name “Joe”.

Perform the same action again, but this time with a lambda expression.

Using a lambda expression, make a list of all employees with an Id number greater than 5.

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

Upload your code to GitHub */