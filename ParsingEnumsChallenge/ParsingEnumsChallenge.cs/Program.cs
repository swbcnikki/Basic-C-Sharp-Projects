using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsChallenge.cs
{
    public class Program
    {
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter today's day of the week...");
                string answer = Console.ReadLine();
                //bool found = false;

                var yes = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), answer);                    
                Console.WriteLine("It's {0}", yes);   
            
            }                        
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
                
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
         
        
        
        
    }
}
