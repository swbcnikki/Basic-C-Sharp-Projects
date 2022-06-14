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
            Qualifications newAbility = new Qualifications("Ruthlessness"); // testing the new chain constructor - I'm not entirely sure how this is supposed to test it but we will talk about it tomorrow

            const string squadName = "The Deadly Viper Assassination Squad";

            Console.WriteLine("Meet the {0}. \n " +
                "Beatrix 'Black Mamba', \n Vernita 'Copperhead', \n O-Ren 'Cottonmouth', \n " +
                "Elle 'California Mountain Snake', \n Budd 'Sidewinder' \n and their leader Bill 'Snake Charmer'.", squadName);
            
            Console.ReadLine();

        }
        
    }
}
