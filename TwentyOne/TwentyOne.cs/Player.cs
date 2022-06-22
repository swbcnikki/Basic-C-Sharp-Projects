using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public class Player
    {
        public Player(string name, int beginningbalance) //constructor that takes 2 arguments
        {
            Hand = new List<Card>(); // initialize the list
            Balance = beginningbalance; //argument property
            Name = name; // argument property
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool  isActivelyPlaying { get; set; }

        public static Game operator + (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator - (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
}
