using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    internal class AiPlayer : Player
    {
        public AiPlayer(string name) : base(name) {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedIndex">參數沒用了</param>
        /// <returns></returns>
        public override Card CumCard(int selectedIndex) {
            return GetRandomCard();
        }
        private Card GetRandomCard() {
            var _totalCount = handDeck.visableCards.Count + handDeck.hiddinCards.Count;
            var _randomIndex = new Random().Next(0, _totalCount - 1);
            return handDeck.GetCard(_randomIndex);
        }
    }
}
