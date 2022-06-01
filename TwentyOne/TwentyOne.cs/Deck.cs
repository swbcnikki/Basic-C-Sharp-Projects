using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public class Deck
    {
        //here we are creating a constructor. A method that is called as soon as an object is created
        public Deck()
        {
            Cards = new List<Card>(); //first it instatiates the property Cards as an empy list of cards
            // second it creates 2 more lists and instantiates them with values. The combination of these 2
            // lists creates the deck of 52 cards. 
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Jack", "Queen", "King", "Ace"
            };
            //For each of the items in the Faces list, we loop 4 times creating the suits for each face
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    // these 4 things happen for each card
                    Card card = new Card(); // create the card
                    card.Suit = suit; // assign the suit property the value of the suit
                    card.Face = face; // assign the face property the value of the face
                    Cards.Add(card); // the new card is added to the empty list of cards above
                }

            }
        }
        public List<Card> Cards { get; set; }
    }
}
