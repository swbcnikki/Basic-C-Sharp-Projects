using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment.cs
{
    class Program
    {
        public static void Main(string[] args)
        {

            // now create an object and then print the attributes
            // trace through with debugger

            // Chaining constructors is essentially overloading constructors. Number of attributes can be different.
            Qualifications qualifications = new Qualifications("availability");

            Qualifications qualifications1 = new Qualifications("availability", "capability");


            const string squadName = "The Deadly Viper Assassination Squad";

            Console.WriteLine("Meet the {0}. \n " +
                "Beatrix 'Black Mamba', \n Vernita 'Copperhead', \n O-Ren 'Cottonmouth', \n " +
                "Elle 'California Mountain Snake', \n Budd 'Sidewinder' \n and their leader Bill 'Snake Charmer'.", squadName);
            
            Console.ReadLine();

        }
        
    }
}
