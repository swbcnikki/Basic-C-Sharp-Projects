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

            int sum1 = option.Addition(digit);

            Console.WriteLine("(This is optional) Type a second number to execute...");
            //string entry = Console.ReadLine();
            //if (entry == "")
            //{
            //    Console.WriteLine("No number entered");
            //}

            int digit2 = Convert.ToInt32(Console.ReadLine()); // converting input to int
                      
            int sum2 = option.Addition(digit, digit2);

                        
            Console.WriteLine("The sum is {0} and the other sum is {1} ", sum1, sum2);
            Console.ReadLine();


             
        }
                
        
    }

}
    

