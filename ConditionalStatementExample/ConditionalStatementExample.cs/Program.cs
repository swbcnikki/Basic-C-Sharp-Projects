using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExample.cs
{
    class Program
    {
        static void Main(string[] args)
        {   
            //if else with equal to
            string name = "Adam";

            if (name == "Jesse") //note, no semicolon here
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett") //note, no semicolon here
            {
                Console.WriteLine("Your name is not Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse. Your name is not Brett");
            }
            Console.ReadLine();

            //if else with not equal to
            if (1 !=2)
            {
                Console.WriteLine("all is right with the universe.");
            }
            else
            {
                Console.WriteLine("We live in a bizarro world.");
            }
            Console.ReadLine();

            //if else with less than or equal to
            int age = 20;
            if (age <= 20)
            {
                Console.WriteLine("No you may not purchase that bottle of wine.");
            }
            else
            {
                Console.WriteLine("There you go!");
            }
            Console.ReadLine();

            //if else with greater than
            int num1 = 12;
            int num2 = 14;
            if (num1 > num2)
            {
                Console.WriteLine("The first number is larger.");
            }
            else
            {
                Console.WriteLine("The second number is larger.");
            }
            Console.ReadLine();

            //ternary operator represented by the symbol ? : . Short form of if else statements. note its( ? "1st result" : "2nd result" )
            int num3 = 7;
            int num4 = 12;

            string result = num3 > num4 ? "num3 is greater than num4" : "num3 is not greater than num4";
            Console.WriteLine(result);
            Console.ReadLine();

            int currentTemp = 70;
            int roomTemp = 70;

            if (currentTemp == roomTemp) //condition to be met. Results in true/false answer. Note no semicolon here
            {
                //if the above is true, what's in this curly brace will execute
                Console.WriteLine("It is exactly room temparature");
            }
            else
            {
                //otherwise execute what is in this curly brace
                Console.WriteLine("It is not exactly room temparature");
            }
            Console.ReadLine();

            //for more specificity, include else if statement
            int currentTemp1 = 70;
            int roomTemp1 = 68;

            if (currentTemp1 == roomTemp1) //condition to be met. Results in true/false answer
            {
                //if the above is true, what's in this curly brace will execute
                Console.WriteLine("It is exactly room temparature");
            }
            else if (currentTemp1 > roomTemp1)
            {   
                //otherwise execute this curly brace. if this curly brace is not true, go to the next statement
                Console.WriteLine("It is warmer than room temperature");
            }
            else if (currentTemp1 < roomTemp1)
            {
                //otherwise execute this curly brace. if this curly brace is not true, go to the next statement
                Console.WriteLine("It is cooler than room temparature");
            }
            else // end of if else statements
            {
                //otherwise execute what is in this curly brace
                Console.WriteLine("It is not exactly room temparature"); //This one might be redundunt as this point. It's here to demo
            }
            Console.ReadLine(); // this is outside the entire if else statement 

            //ternary statement. Short form of if else statements
            int currentTemp2 = 65;
            int roomTemp2 = 70;

            string comparisonResult = currentTemp2 == roomTemp2 ? "It is room temp." : "It is not room temp.";

            Console.WriteLine(comparisonResult);
            Console.ReadLine();

            int roomTemparature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Hi, " + name1 + ", what is the temparature where you are?");
            int currentTemparature = Convert.ToInt32(Console.ReadLine());

            if (currentTemparature == roomTemparature)
            {
                Console.WriteLine("It is exactly room temparature.");
            }
            else if (currentTemparature > roomTemparature)
            {
                Console.WriteLine("It is warmer than room temparature");
            }
            else if (roomTemparature > currentTemparature)
            {
                Console.WriteLine("It is cooler than room temparature");
            }
            else
            {
                Console.WriteLine("uuuuuuh... something is wrong here");
            }
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result1 = favNum == 12 ? "You have a good favorite number" : "Your favorite number is meh";

            Console.WriteLine(result1);
            Console.ReadLine();
        }
    }
}
