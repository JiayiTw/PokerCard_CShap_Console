using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class Deck
    {
        public List<Card> deckCards;

        public Deck() {
            deckCards = new List<Card>();
            //初始化Deck
            try
            {
                for (int i = 1; i < 13; i++) // 1到13
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        Card _newCard = new Card();
                        ;
                        _newCard.Value = i; //set 1到13
                        switch (j)
                        {
                            case 0:
                                _newCard.Suit = CardSuitType.spade;
                                break;
                            case 1:
                                _newCard.Suit = CardSuitType.heart;
                                break;
                            case 2:
                                _newCard.Suit = CardSuitType.diamond;
                                break;
                            case 3:
                                _newCard.Suit = CardSuitType.club;
                                break;
                            default:
                                break;
                        }
                        ;
                        deckCards.Add(_newCard);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Random newr = new Random();
            ////隨機洗牌
            //List<Card> newlist = new List<Card>();
            //foreach (Card item in deckCards)
            //{
            //    newlist.Insert(newr.Next(newlist.Count + 1), item);

            //}
        }
        /// <summary>
        /// 從牌堆抽一張卡
        /// </summary>
        /// <returns></returns>
        public Card Drawcard() {
            Random _random = new Random();
            var _randomInt = _random.Next(0, deckCards.Count - 1);
            var result = deckCards[_randomInt];
            deckCards.RemoveAt(_randomInt);
            return result;
        }
    }
}
