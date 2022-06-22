using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public class Dealer
    {
        public string Name { get; set; }//property
        public Deck Deck { get; set; } //propery
        public int  Balance { get; set; } //property

        public void Deal(List<Card> Hand) //method
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
