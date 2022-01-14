using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class Player
    {
        public string Name;

        public Hand handDeck;

        //建構子
        public Player(string name) {
            Name = name;
        }
        /// <summary>
        /// 出牌
        /// </summary>
        /// <param name="selectedIndex"></param>
        /// <returns></returns>
        public virtual Card CumCard(int selectedIndex) {
            return handDeck.GetCard(selectedIndex);
        }
    }
}
