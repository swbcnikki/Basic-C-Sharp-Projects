using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine(); // cannot use int because program is expecting string. This is not a math operation
            //Console.WriteLine("Your favorite number is: " + favoriteNumber);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber); //casted string to int so now can be used for math
            //int Total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + Total);
            //Console.ReadLine();


            //examples of other datatypes
            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -2;
            char questionMark = '\u2103'; //unicode

            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            decimal moneyInTheBank = 100.5m; // m means decimal
            double heightInCentimeters = 225.683;
            float secondsLeft = 13.4f;
            short temparatureOnMars = -300;
            string myName = "Miss Jackson if ya nasty";

            int currentAge = 30; // convert int to str
            string yearsOld = currentAge.ToString();

            bool israining = true;
            string rainingStatus = Convert.ToString(israining);

            Console.WriteLine(rainingStatus);
            Console.ReadLine();
                        
        }
    }
}
