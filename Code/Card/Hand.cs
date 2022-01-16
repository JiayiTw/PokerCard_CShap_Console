using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Code.Card
{
    class Hand
    {
        public List<Card> visableCards;
        public List<Card> hiddinCards;

        public Hand() {
            visableCards = new List<Card>();
            hiddinCards = new List<Card>();
        }
        //獲取一張牌並從手牌中刪除
        public Card GetCard(int index) {
            var _totalList = visableCards.Union(hiddinCards).ToList<Card>();

            try
            {
                var result = _totalList[index];
                visableCards.Remove(result);
                hiddinCards.Remove(result);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private bool IsCardInHand(Card card) {
            // 如果選擇的牌有在手牌中
            foreach (var _handCard in hiddinCards)
            {
                return card.IsEqualTo(_handCard);
            }
            foreach (var _handCard in visableCards)
            {
                return card.IsEqualTo(_handCard);
            }
            return false;
        }

    }
}
