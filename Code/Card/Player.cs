﻿using System;
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
        /// <param name="selected"></param>
        /// <returns></returns>
        public virtual Card CumCard(Card selected) {

            if (CanCum(selected))
                return selected;
            return null;
        }
        protected bool CanCum(Card card) {
            // 如果選擇的牌有在手牌中

        }
    }
}
