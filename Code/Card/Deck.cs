using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class Deck 
    {
        public List<Card> deckcard;
        public int value;
        public Deck()
        {
            //初始化Deck
            for(int i=1; i<=13;i++)
            {

                Card card = new Card();
                    card.Value = i;
                    
                    for(int j=0;j<=3;j++)
                    {
                        switch (j)
                        {
                            case 0:
                                card.Suit = CardSuitType.spade;
                                break;
                            case 1:
                                card.Suit = CardSuitType.heart;
                                break;
                            case 2:
                                card.Suit = CardSuitType.diamond;
                                break;
                            case 3:
                                card.Suit = CardSuitType.club;
                                break;
                            default:
                                break;
                        }
                        deckcard.Add(card);
                    }

                }
            Random newr = new Random();
            //隨機洗牌
            List<Card> newlist = new List<Card>();
            foreach (Card item in deckcard)
            {
                newlist.Insert(newr.Next(newlist.Count + 1), item);

            }


            }
           
            
        
        public Card Drawcard()
        {
            Card card1 = new Card();
            
            return card1;
        }
    }
}
