using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class DeckOfCards
    {
        private Card[] deck;
        private int size = 52;

        public DeckOfCards()
        {
            deck = new Card[52];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[i * 13 + j] = new Card(i, j);
                }
            }
        }

        public void shuffle()
        {
            size = 52;
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < deck.Length; i++)
            {
                int index = (int)(rnd.Next(52));
                Card temp = deck[i];
                deck[i] = deck[index];
                deck[index] = temp;
            }
        }

        public Card dealCard()
        {
            size--;
            return deck[size];
        }
    }
}
