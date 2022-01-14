using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class Card : CardBase
    {

        /// <summary>
        /// Return true if U R BiggerRRRR
        /// </summary>
        /// <param name="card">要比較的卡</param>
        /// <returns>大，有夠大</returns>
        public bool IsBiggerThan(Card card) {
            //還沒時做
            Card inputedCard = card;
            if (this.Value > inputedCard.Value) {
                //大GG
                return true;
            }
            else if (this.Value == inputedCard.Value) {
                //世界的意志決定你小GG
                return false;
            }
            else {
                //小GG
                return false;
            }
            

        }

    }
}
