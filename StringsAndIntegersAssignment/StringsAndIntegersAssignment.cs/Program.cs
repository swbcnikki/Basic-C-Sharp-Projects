using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                List<int> dividend = new List<int>(); //in lists you do not declare a length
                dividend.Add(11);
                dividend.Add(12);
                dividend.Add(13);
                dividend.Add(14);
                dividend.Add(15);

                Console.WriteLine("In this list of integers, 11, 12, 13, 14, 15...");
                Console.ReadLine();
               
                Console.WriteLine("...type an integer you want to divide them by?");
                int divisor = Convert.ToInt32(Console.ReadLine());                               

                foreach (int number in dividend)
                {
                    int result = number / divisor;
                    Console.WriteLine(number + " divided by " + divisor + " equals " + result);                    
                }
                Console.ReadLine();
            }

            catch (FormatException ex) // if there is a user error, prog with execute catch
                                       //in this catch, we are catching a FormatException (string vs int) and sto
                                       //ring it a variable, ex
            {
                Console.WriteLine(ex.Message); // this is to write the Message of the error on the screen
                return; //stops execution of everything and takes them to a different page or where you
                        //want them to go after an error. Console.ReadLine will not execute and the screen
                        //closes immediately even though it is programmed in.
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
                // you could also put in your own error message within the parenth instead of the program default
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally // will always run with or without errors. Logs activity of program to db regardless of outcome
            {
                Console.ReadLine(); // if there is a return, like in the first catch above, it stops the whole program 
                                    // and the readline does not execute. To guarantee the readline executes, it is nested under the finally
            }
            Console.WriteLine("You have successfully run the program and emerged after going through the try-catch block");
            Console.ReadLine();
        }
        
    }
}
