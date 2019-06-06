using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    public class Player
    {
        List<Card> cards = new List<Card>();

        public Player()
        {
        }

        public void AddCardToHand(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public List<Card> Cards
        {
            get { return cards; }
        }
    }
}
