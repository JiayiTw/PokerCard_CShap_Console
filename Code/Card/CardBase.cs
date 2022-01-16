using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    enum CardSuitType
    {
        spade,
        heart,
        diamond,
        club
    }

    abstract class CardBase
    {
        const int POKER_MAX_VALUE = 13;
        const int POKER_MIN_VALUE = 1;

        private CardSuitType suit;
        private int value;

        public int Value
        {
            get => value;
            set
            {
                if (value <= POKER_MAX_VALUE && value >= POKER_MIN_VALUE)
                {
                    this.value = value;
                }
                else
                {
                    throw new Exception("撲克牌點數錯誤，數值1-13，你的數值為:" + value);
                }
            }
        }
        public CardSuitType Suit { get => suit; set => suit = value; }


    }
}
