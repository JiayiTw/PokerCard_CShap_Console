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

    class CardBase
    {
        private CardSuitType suit;
        private int value;

        public int Value
        {
            get => value;
            set
            {
                try
                {
                    if (value >= 13 && value <= 1)
                    {
                        this.value = value;
                    }
                    else
                    {
                        throw new Exception("撲克牌點數錯誤，數值1-13，你的數值為:" + value);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public CardSuitType Suit { get => suit; set => suit = value; }
    }
}
