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
        public Deck() //constructor
        {
            Cards = new List<Card>(); //first it instatiates the property Cards as an empy list of cards. Notice static is not included.
            // second it creates 2 more lists and instantiates them with values. The combination of these 2
            // lists creates the deck of 52 cards. 

            for (int i = 0; i < 13; i++) //face
            {
                for (int j = 0; j < 4; j++) //suit
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    card.Add(card);
                }
            }


            
        }
        public List<Card> Cards { get; set; } // properties

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++) // after including the default int times = 1 in the original method, move the method code under a for loop, except the return statement.
            {
                List<Card> TempList = new List<Card>(); //empty temporary list to store shuffled items
                Random random = new Random();

                while (Cards.Count > 0) // while loop grab cards until the deck hits 0
                {
                    //create a random index between 0 and 52
                    int randomIndex = random.Next(0, Cards.Count); // min value 0 max value count of card deck
                    TempList.Add(Cards[randomIndex]); // add the random index to the temp list
                    Cards.RemoveAt(randomIndex); // removed from the original list of cards until no cards left
                }
                Cards = TempList; // at this point deck.Cards is empty and we assign the templist to it
            }

        }
    }
}
