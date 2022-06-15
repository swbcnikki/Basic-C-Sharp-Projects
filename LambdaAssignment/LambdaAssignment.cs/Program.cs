using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment.cs
{
   
    public class Program
    {
        public static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well
            //as an Id. At least two employees should have the first name “Joe”


            //****** NOTE THERE IS AN ADDED CLASS, EMPLOYEE.CS THAT HAS THE DECLARATIONS FOR ID, FIRSTNAME AND LASTNAME PROPERTIES******


            List<Employee> employeeList = new List<Employee>()
            {
                new Employee{ ID = 1, firstName = "Joe", lastName = "Smith"},
                new Employee{ ID = 2, firstName = "Mary", lastName = "Meta"},
                new Employee{ ID = 3, firstName = "Tim", lastName = "Twitter"},
                new Employee{ ID = 4, firstName = "Amos", lastName = "Amazon"},
                new Employee{ ID = 5, firstName = "Daisy", lastName = "Discord"},
                new Employee{ ID = 6, firstName = "Alice", lastName = "Apple"},
                new Employee{ ID = 7, firstName = "Matt", lastName = "Microsoft"},
                new Employee{ ID = 8, firstName = "Ginger", lastName = "Google"},
                new Employee{ ID = 9, firstName = "Zippy", lastName = "Zoom"},
                new Employee{ ID = 10, firstName = "Joe", lastName = "Jones"},

            };

            List<Employee> onlyJoes = new List<Employee>(); //creating a list for the filtered names to go to

            foreach (Employee emp in employeeList) // iterate the whole list, for each emp, perform the if statement
            {
                if (emp.firstName.Contains("Joe")) //if statement filtering the list
                {
                    onlyJoes.Add(emp); // adding filtered names to the newly created list onlyJoes
                    Console.WriteLine("{0} {1}", emp.firstName, emp.lastName); // format to print what you want. Could include id if you want              
                }                
            }

            List<Employee> lambdaJoes = employeeList.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee x in lambdaJoes)
            {
                Console.WriteLine("{0} {1}", x.firstName, x.lastName);
            }

            List<Employee> lambdaList = employeeList.Where(y => y.ID > 5).ToList();

            foreach (Employee y in lambdaList)
            {
                Console.WriteLine("{0} {1} {2}", y.ID, y.firstName, y.lastName);
            }

            Console.ReadLine(); //keep console open with all results showing
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