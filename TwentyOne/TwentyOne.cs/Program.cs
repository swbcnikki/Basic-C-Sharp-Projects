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
        //static means the method was created before creating an object of that class
        //void is the return type (void means it returns nothing), Main is the method, string array is the parameter and args is it's variable name in this method
        {
            Deck deck = new Deck(); // instantiating the Deck object. Cards are in order.
            //calling the shuffle method after creating it below
            deck = Shuffle(deck); // this is the shuffle code. Without it, the deck remains in order

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            // deck object has the property Cards of datatype List<Card> of which list has a propert of Count
            Console.WriteLine(deck.Cards.Count); // to know how many are in the deck
            Console.ReadLine();
        }

        //public as access modifier makes it accessible anywhere,
        //static to ba able to call it before creating an object program,
        //Deck is the type of data being returned,
        //Shuffle is the name of the function/ Method,
        //(Deck is the parameter with deck as it's variable name inside of this method)
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>(); //empty temporary list to store shuffled items
            Random random = new Random();

            while (deck.Cards.Count > 0) // while loop grab cards until the deck hits 0
            {
                //create a random index between 0 and 52
                int randomIndex = random.Next(0, deck.Cards.Count); // min value 0 max value count of card deck
                TempList.Add(deck.Cards[randomIndex]); // add the random index to the temp list
                deck.Cards.RemoveAt(randomIndex); // removed from the original list of cards until no cards left
            }
            deck.Cards = TempList; // at this point deck.Cards is empty and we assign the templist to it
            return deck; // return the deck variable
        } 
            
    }
}
