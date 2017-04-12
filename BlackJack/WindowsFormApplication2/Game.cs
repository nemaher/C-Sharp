using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Game
    {
        List<Card> Hand = new List<Card>();

        public List<Card> dealCard(DeckOfCards deck)
        {
            Card NewCard = deck.dealCard();
            Hand.Add(NewCard);
            return Hand;
        }

        public int total()
        {
            int total = 0;

            for(int i = 0; i < Hand.Count; i++)
            {
                total = total + Hand[i].dealSum();
            }
            return total;
        }

        public int add(List<Card> DeltHand)
        {
            int total = 0;
            for (int i = 0; i < DeltHand.Count; i++)
            {
                total = total + DeltHand[i].dealSum();
            }
            return total;
        }

        public string displayHand(List <Card> Hand)
        {
            string formatedHand = "";
            for (int i = 1; i < Hand.Count; i++)
            {                
               formatedHand = Hand[i - 1].toSuite() + Hand[i].toSuite();
            }
            return formatedHand;
        }
       
        /*public List<Card> toSuit(List<Card> Hand)
        {
            for(int i = 0; i < Hand.Count; i++)
            {
                List<string> DealersHand[i] = Hand[i].toSuite();
            }
        }*/
    }
}
