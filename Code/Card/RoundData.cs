using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class RoundData
    {
        public Player[] wonPlayer = new Player[5];
        //當前回合各玩家出的卡
        public Card currentMainCard = null;

        public Card currentOtherCard = null;
    }
}
