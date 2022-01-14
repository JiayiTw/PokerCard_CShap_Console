using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class Player
    {
        public string Name;

        public Hand handDeck;

        public Card CumCard(Card selected)
        {
            Console.WriteLine(" I cum !!! ");
            return selected;
        }

    }
}
