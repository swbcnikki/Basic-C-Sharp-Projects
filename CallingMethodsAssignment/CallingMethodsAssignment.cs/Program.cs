using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment.cs
//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some
//math operation on the received parameter. Put this class in a separate .cs file in the application.

{
    class Program
    {
        public static void Main(string[] args) // Main method of the program. We will be calling the methods we created in the class we created.
        {
            // The values are not hard coded in. Ask the user to provide the values to be processed
            Console.WriteLine("To perform the math operation, please enter your first number... "); // value provided is in string and needs to be converted to int
            int num1 = Convert.ToInt32(Console.ReadLine()); // converting string to int. Variable name can be anything. Ensure variable name for each number is
                                                            // distinct. It does not need to match the variable names in the called method from Arithmetic class. 
            Console.WriteLine("Please enter your second number... "); // string value from user
            int num2 = Convert.ToInt32(Console.ReadLine()); // converting the string value to int



             // calling created methods add, subtract, multiply and divide from the Arithmetic class we created
            int sum = Arithmetic.Add(num1, num2); // passing in the variables declared above and performing the operation
            Console.WriteLine("The sum is " + sum); // displaying the result
                        
            int difference = Arithmetic.Subtract(num1, num2); // passing variables
            Console.WriteLine("The difference is " + difference); // display results
            
            int product = Arithmetic.Multiply (num1, num2); // passing variables
            Console.WriteLine("The product is " + product); // display results
            
            int quotient = Arithmetic.Divide (num1, num2); // passing variables
            Console.WriteLine("The quotient is " + quotient); // display results
            Console.ReadLine(); // keeping the page open to view the results.
        }
               
    }
}
