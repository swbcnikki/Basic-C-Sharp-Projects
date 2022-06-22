using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); // program to lowercase for ease on programming
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") // accomodate different answers. Executes the below code.
            {
                Player player = new Player(playerName, bank); //argument values from Player.cs entered
                Game game = new TwentyOneGame(); // creating the game - notice polymorphism
                game += player; // adding player to the game
                player.isActivelyPlaying = true; // property
                while (player.isActivelyPlaying && player.Balance > 0) // keep the game going as long as the player is actively playing and there is money
                {
                    game.Play(); // play method. code is in separate method for streamlining. Located in TwentyOneGame.cs
                }
                game -= player; //removing a player from the game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now."); // This executes if they answer no to playing at the beginning. Additional else statement not necessary
            Console.ReadLine();
        }
        
    }
}
