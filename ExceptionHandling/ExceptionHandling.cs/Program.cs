using System;
class Program
{
    static void Main(string[] args)
    {
        //dividing one number by another
        try // try the following program. If an error occurs, execute the catch below this block
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine()); // user error is what we are trying to address
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine()); // eg. if they input a string instead of int? An error occurs. 
            Console.WriteLine("Divide the two..."); 
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
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
        
    }
}
