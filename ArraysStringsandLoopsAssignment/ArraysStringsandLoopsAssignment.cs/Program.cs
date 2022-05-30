using System;
using System.Collections.Generic;


namespace ArraysStringsandLoopsAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 13 Ghosts of Scooby Doo!");//name of app
            //The array
            string[] jeepersArray = { "Maldor", "Morbidia", "Specter", "Zomba", "Ferguson", "Nekara", "Marcella", "Slime", "Demondo", "Rankor", "Phantazmo", "Zimbulu", "Asmodeus" };

            for (int ghosts = 0; ghosts < jeepersArray.Length; ghosts++)
            {
                Console.WriteLine(jeepersArray[ghosts]);
            }

            Console.ReadLine();

            Console.WriteLine("Type the reaction Scooby and his friends would have when they discover a ghost");

            string reaction = Console.ReadLine();


            foreach (string ghost in jeepersArray)
            {
                Console.WriteLine("It's " + ghost + " ! " + reaction);
            }
            Console.ReadLine();


            //This is an infinite loop.Scooby will be saying Ruh Roh forever and ever and ever and ever...
            //while (ohno)
            //{
            //    Console.WriteLine("Ruh Roh")
            //}
            //Console.ReadLine();

            // putting a limit on the loop allows control
            int ohno = 1; // int variable to start the count
            while (ohno <= 13) // limits the occurences to 13
            {
                Console.WriteLine("Ruh Roh Raggy!!!"); ohno++; // ++ allows for the increment by 1 which fires up the iteration of the loop, until the limit is reached
            }
            Console.ReadLine();

            //for comparison, iterating the loop with a < operator
            int ohno1 = 1;
            while (ohno1 < 14)
            {
                Console.WriteLine("Like, run Scoob!"); ohno1++;
            }
            Console.ReadLine();

            //for comparison
            int ohno2 = 14;
            while (ohno2 > 1)
            {
                Console.WriteLine("Jinkies! I found a clue."); ohno2--;
            }
            Console.ReadLine();

            // list of states that start with the letter M
            List<string> statesList = new List<string>() { "Montana", "Maine", "Minnesota", "Maryland", "Missouri", "Michigan", "Massachusetts", "Mississippi" };
            //question
            Console.WriteLine("Type the name of a state that starts with the letter M to see it's index value");
            string entry = Console.ReadLine(); //prints the answer the user types in

            int stateNum = 0; // numbering of the elements begins at 0
            int index = 0; //index begins at 0 if true answer is entered
            int notState = -1;// index value of false answer is entered
            foreach (string state in statesList) // each element in the list
            {
                if (entry == state) // if what the user types in is the same as one of the elements in the list
                {
                    index = stateNum; // the value in the index is the same as the value in the state number. They are the same element.
                    notState = notState + 1; // This is to ensure that if this inner if-true statement runs, the if-false statement below does not run. It neutralizes it. 
                }
                stateNum++; //to activate the loop by increasing the stateNum by 1 until the loop is done
            }                       

            if ( notState == -1) //if false statement
            {
                Console.WriteLine("You have typed in a state that does not exist on the list"); //communication to the user that their input is incorrect
            }
            else //if true, the foreach has run successfuly, the if false statement above has been bypassed and the app will display the information
            {
                Console.WriteLine($"{statesList[index]} is {index}"); //$ means the string is interpolated. {name of list[element in list]} {index}
            }
            Console.ReadLine();




            Console.WriteLine("NBA Champions Of The Last 10 Tournaments");

            List<string> paradeList = new List<string>() { "Bucks", "Lakers", "Raptors", "Warriors", "Warriors", "Cavaliers", "Warriors", "Spurs", "Heat", "Heat" };

            Console.WriteLine("Type an NBA team has won the chip in the last 10 tournaments.");
            string champ = Console.ReadLine();

            int teamNum = 1;
            int teamIndex = 0;
            int vanquished = -1;
            foreach (string team in paradeList)
            {
                if (champ == team)
                {
                    teamNum = teamIndex + 1;
                    vanquished = vanquished + 1;
                }
                teamNum++;
            }

            if (vanquished == -1)
            {
                Console.WriteLine("What? You've gotta be kidding! Goodbye.");
            }
            else
            {
                Console.WriteLine("Within this list, the index of the first and last win for that team is, ");
                Console.WriteLine(paradeList.IndexOf(champ));
                Console.WriteLine(paradeList.LastIndexOf(champ));
            }
            Console.ReadLine();


            // I need help with this

            
            Console.WriteLine("NFL Teams With First Overall Pick Since 2017");

            List<string> bustList = new List<string>() { "Jaguars", "Jaguars", "Bengals", "Cardinals", "Browns", "Browns" };
            List<string> bustRedo = new List<string>(); // stores habitual bust winners       

            Console.WriteLine("Of the 32 NFL teams, which have picked first in the last 6 drafts?");
            string hopeful = Console.ReadLine();

            int firstPick = 0;
            int lastPlace = 0;
            int gladNot = 0;
            foreach (string team in bustList)
            {
                if (hopeful == team)
                {
                    firstPick = lastPlace;
                    gladNot = gladNot + 1;
                }
                firstPick++;
            
                if
                    (!bustList.Contains(team))
                    bustList.Add(team);
                else
                    bustRedo.Add(team);
            }
            foreach (string team in bustRedo)
                Console.WriteLine(team + "(2)");
            Console.ReadLine();


            //foreach (string team in bustList)
            //{
            //    if (hopeful == team)
            //    {
            //        Console.WriteLine(bustList.IndexOf(team));
            //        Console.WriteLine(bustList.LastIndexOf(team));

            //    }
            //    Console.ReadLine();

            

        }
    }
}
