using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    public class Card
    {
        // sometimes, default values are assigned to properties of an object at program creation. Not
        // neccesary in this project but this is what it looks like 
        // this is a constructor. It would be the default if no other code is entered in the main program
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}

        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
