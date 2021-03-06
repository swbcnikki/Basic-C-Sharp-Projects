using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public abstract class Game
    {
        public List<Player> Players { get; set; } // property
        public string Name { get; set; } // property
        public string Dealer { get; set; } // property

        public abstract void Play();
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
