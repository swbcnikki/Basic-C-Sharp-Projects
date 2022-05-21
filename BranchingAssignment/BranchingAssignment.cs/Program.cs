using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below."); //name of program
            //declaring max limit weight.
            int maxWeight = 50;
            //first instruction
            Console.WriteLine("Please enter the weight of your package.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            // bool logic. If over max weight, app will print message and close
            if (packageWeight > maxWeight)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            // If not over max weight, app will continue
            else
            {                               
                //Asks the user for more information to determine if the package is within max limits in size
                Console.WriteLine("Please enter the width of your package.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the height of your package.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                               
                Console.WriteLine("Please enter the length of your package.");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                //package size variable. Total dimensions max is 50        
                int packageDimensions = packageLength + packageWidth + packageHeight;
                
                // bool logic. If package size is over max size the message will print and close the app
                if (packageDimensions > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                // If package is within max size the app continues and calculates the shipping
                else
                {
                    int packageSize = packageLength * packageWidth * packageHeight;
                    // converting measurement int to decimal for financial calculations
                    decimal shipCost = Convert.ToDecimal(packageSize * packageWeight/100);
                                        
                    Console.WriteLine("Your estimated cost for shipping this package is " + "$" + shipCost);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                    
                }
                                
            }
                       
            
        }

    }   
}
