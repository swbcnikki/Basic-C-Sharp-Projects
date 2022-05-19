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
            bool isStudying = false; //true or false
            byte hoursWorked = 42; //unsigned number between 0 and 255
            sbyte currentTemp = -2; //signed number between -128 and 127
            char questionMark = '\u2103'; //char represents one Unicode character assigned with single quotes

            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            decimal moneyInTheBank = 100.5m; // m is the decimal suffix. Represents any number up to 28 or 29 digits in length - 128-bits
            double heightInCentimeters = 225.683; //Represents any number up to 15 or 16 digits in length - 64-bits
            float secondsLeft = 13.4f; // f is the float suffix. Represents any number up to 7 digits in length - 32-bits
            short temparatureOnMars = -300; //Represents a whole number between -32,678 and 32,767. 16-bit version of int
            ushort antarcticaPopulation = 302; //Represents a whole number between 0 and 65,535. 16-bit version of uint
            long moleculeDifference = 4843349238903; //Represents a whole number between -9000000000000000000 and 9000000000000000000. 64-bit version of int
            ulong airMoleculesInJar = 24328493492309; //Represents a whole number between 0 and 18000000000000000000. 64-bit version of uint
            string myName = "Miss Jackson if ya nasty"; //Represents a set of 0 or more Unicode characters. Delimited by double-quotes
            int population = 495000000; // Represents a whole number between -2000000000 and 2000000000. 32-bits
            uint pixelWidth = 1280; // unsigned integer. Represents a whole number between 0 and about 4000000000

            int currentAge = 30; // convert int to str
            string yearsOld = currentAge.ToString();

            bool israining = true;
            string rainingStatus = Convert.ToString(israining);

            Console.WriteLine(rainingStatus);
            Console.ReadLine();
                        
        }
    }
}
