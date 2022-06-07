using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment.cs
{
    class Program
    {
        public static void Main(string[] args)        
        {
            OptionalParams option = new OptionalParams(); // instance

            Console.WriteLine("Type in a number for the operation to execute..."); // user question
            int digit = Convert.ToInt32(Console.ReadLine()); // converting input to int

            int sum1 = 0; //outside if statement
            int sum2 = 0; // outside if statement

            Console.WriteLine("(This is optional) Type a second number to execute..."); // option to trigger the default or not
            string entry = Console.ReadLine(); // This is before converting to int. If there is no entry, there is
                                               // no need to convert before processing this part of the code
            if (entry == "")
            {
                sum1 = option.Addition(digit); // calling method with 1st digit
                Console.WriteLine("No second number entered."); // communicate with the user
                Console.WriteLine(digit + " + default value of 4" + " = " + sum1); // explain why the initial digit they entered has the default (4) added to it
            }
            else
            {
                int digit2 = Convert.ToInt32(entry); // converting input to int

                sum2 = option.Addition(digit, digit2); // calling method adding 2nd digit to 1st digit. No default coz a digit was entered
                Console.WriteLine(digit + " + " + digit2 + " = " + sum2); // if 2nd digit is entered, this will process
            }                        
            
            Console.ReadLine();


             
        }
                
        
    }

}
    

