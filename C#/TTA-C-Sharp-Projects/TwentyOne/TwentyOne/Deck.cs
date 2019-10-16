using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Constructors always go at the top of the class before the properties
        public Deck()
        {
            //Instaniate new empty List called Cards
            Cards = new List<Card>();
            
            //Create two new lists and immediately instantiate them with values
            //First list is Suits and the next list is Faces
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //Nested foreach loop
            //foreach suit in Suits we will go through each face in Faces
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }



        }

        public List<Card> Cards { get; set; }


        //Function for shuffling the deck
        public void Shuffle(int times = 1)
        {
            //for loop to shuffle deck
            for (int i = 0; i < times; i++)
            {
                //TempList is randomly made with Card
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                //while deck Cards Count are less than zero continue random index for templist
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                //assign deck.Cards value of TempList
                Cards = TempList;
            }
        }
    }
}
