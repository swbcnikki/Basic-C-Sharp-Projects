using System; //library actively used by document
using System.Collections.Generic; //this and all the libraries below it are grayed because they are not used
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport //makes it easier to identify where stored 
{
    class Program //main class of app
    {
        static void Main() //function named Main
        {
            Console.WriteLine("THE TECH ACADEMY\n Student Daily Report"); //Console.WriteLine(); code input that will display. Escape character \n starts a new line
            string heading = Console.ReadLine(); //console.readline(); prevents the console from closing itself so we can view the output of our code input.

            Console.WriteLine("What is your name?\n");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?\n");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?\n");
            string pageNumber = Console.ReadLine(); // don't use int. This is not a math operation, just a specific answer

            Console.WriteLine("Do you need help with anything?\n");            
            string helpQuestion = Console.ReadLine(); //bool could possibly be used for a simple y/n answer. If so, radio buttons or check boxes recommended. String works for space to describe question
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.\n");
            string yourExperience = Console.ReadLine(); //same notes as above concerning bool

            Console.WriteLine("Is there any other feedback you'd like to provide? please be specific.\n");
            string otherfeedback = Console.ReadLine(); //same notes as above concerning bool

            Console.WriteLine("How many hours did you study today?\n ");
            string hoursStudied = Console.ReadLine(); //not a math operation so int is not used. String does the job

            Console.WriteLine("Thank you for your answers. An Instructor will respond\n" +
                "to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
