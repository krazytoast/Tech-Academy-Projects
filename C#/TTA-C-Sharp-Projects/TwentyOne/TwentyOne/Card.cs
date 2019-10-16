using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        //Creating a public string with name and { getting that value; setting that value}
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
