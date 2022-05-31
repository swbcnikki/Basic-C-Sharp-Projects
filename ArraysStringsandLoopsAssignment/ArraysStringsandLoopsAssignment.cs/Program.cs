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

            //A loop that iterates through each string in the array and adds the user's text input to the end
            //of each string. This step will not output anything to the console, but will update each array
            //element by appending the user's text.

            for (int ghosts = 0; ghosts < jeepersArray.Length; ghosts++) // loop
            {
                //here, the original string is being set to the string and the append together by index
                jeepersArray[ghosts] = jeepersArray[ghosts] + reaction;
            }

            // this is the step where the output will show. Below is a loop that prints each appended
            // string in the array on it own line. ghost is now ghost and reaction together. 
            foreach (string ghost in jeepersArray)
            {
                Console.WriteLine("It's " + ghost + " ! ");
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

            //for comparison, iterating the array with a < operator
            int ohno1 = 1;
            while (ohno1 < 14)
            {
                Console.WriteLine("Like, run Scoob!"); ohno1++;
            }
            Console.ReadLine();

            //for comparison, iterating the array with a > operator. Note the direction is in the negative 
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
            bool found = false; // bool set to false to begin with 

            for (int state = 0; state < statesList.Count; state++) // iterating through each index in the list until the count is complete
            {
                if (statesList[state] == entry) // if what the user types in is one of the elements in the list
                {
                    found = true;  // bool is reset and variable is now true                 
                    Console.WriteLine($"{statesList[state]} is {state}"); // displaying the index that matches the user entry
                    break; // code to the loop that stops it from executing once a match has been found
                }
            }
            if (!found) //if not found then its false
            {
                Console.WriteLine("You have typed in a state that does not exist on the list"); //communication to the user that their input is incorrect
            }
            Console.ReadLine();


            Console.WriteLine("NBA Champions Of The Last 10 Tournaments");

            List<string> paradeList = new List<string>() { "Bucks", "Lakers", "Raptors", "Warriors", "Warriors", "Cavaliers", "Warriors", "Spurs", "Heat", "Heat" };
                          
            Console.WriteLine("Select and type an NBA team has won the chip in the last 10 tournaments.");
            string champ = Console.ReadLine();
            bool won = false;
            for (int team1 = 0; team1 < paradeList.Count; team1++)
            {
                if (paradeList[team1] == champ)
                {
                    won = true;
                    Console.WriteLine($"{paradeList[team1]} is at index {team1}");
                }
            }
            if (!won)
            {
                Console.WriteLine("You have typed in a team that is not on the list");
            }
            Console.ReadLine();    
            
            if (!won)
            
            {
                Console.WriteLine("What? You've gotta be kidding! Goodbye.");
            }            
            Console.ReadLine();









            Console.WriteLine("NFL Teams With First Overall Pick Since 2017");

            List<string> bustList = new List<string>() { "Jaguars", "Jaguars", "Bengals", "Cardinals", "Browns", "Browns" };
            List<string> busters = new List<string>(); 
            // as it iterates bustList, the code evaluates whether the team has appeared on the list before or not. Each
            // team is the then copied to busters as the answer is found whether or not it appears once or multiple
            // times. By the end of the loop, busters and bustList will have the same exact items each. The objecive here
            // is to identify and report, not remove or change anything. User input is not required.
            
            foreach (string team in bustList) // in the original list each element is evaluated
            {
                if (busters.Contains(team)) // busters is empty to begin with, so each element is new to it
                {
                    Console.WriteLine( team + " has appeared before"); // code will recognize an element that has appeared before and report that in the console
                }
                else
                {
                    Console.WriteLine( team + "'s first appearance"); // not part of the assignment. I added this for me to see what the whole list would say
                }
                busters.Add(team); // this code adds a copy of each team from bustList to busters as it is evaluating and reporting how many times the team has appeared
                
            }
            Console.ReadLine();
            

        }
    }
}
