using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatementAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrating a while statement. While statements need a limit, otherwise, they will go on forever.
            int numbers = 1;
            while (numbers <= 10)
            {
                Console.WriteLine(numbers);
                numbers++;                
            }
            //Demonstrating a do while statement
            //Question being asked
            Console.WriteLine("Which number is concidered to be arithmetically unique and the most prime? Hint - it is between 1 and 10.");
            int unique = Convert.ToInt32(Console.ReadLine());           
            bool isRight = unique == 7; //bool logic. True only if the answer is 7. False all other answers.            

            do //first part of do while loop. Ensures the while loop runs at least once to fully process the code
            {
                switch (unique)
                {
                    //each case is an attempt of a number
                    case 2:
                        Console.WriteLine("You guessed 2. Nice try, but no. Try again");
                        Console.WriteLine("Which number is concidered to be arithmetically unique and the most prime? Hint - it is between 1 and 10.");
                        unique = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Nice try, but no. Try again");
                        Console.WriteLine("Which number is concidered to be arithmetically unique and the most prime? Hint - it is between 1 and 10.");
                        unique = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Nice try, but no. Try again");
                        Console.WriteLine("Which number is concidered to be arithmetically unique and the most prime? Hint - it is between 1 and 10.");
                        unique = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. That's correct. It can't be divided or multiplied within the group of 10, for an answer within the same group.");
                        isRight = true;
                        break;
                    default:
                        Console.WriteLine("Nope! Either this number is not a prime or it is greater than 10 or both. Try again.");                    
                        Console.WriteLine("Which number is concidered to be arithmetically unique and the most prime? Hint - it is between 1 and 10.");
                        unique = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isRight); //Second part of do while loop. While isRight is false...

            Console.ReadLine(); //... print the question again

        }
    }
}
