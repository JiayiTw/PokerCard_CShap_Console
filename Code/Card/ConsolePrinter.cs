using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class ConsolePrinter
    {
        /// <summary>
        /// 用ConsoleLine Print 雙方的牌在畫面上
        /// </summary>
        /// 
        public void GameStart(Hand mainPlayerHand, Hand otherPlayer) {
            Hand playerHand = mainPlayerHand;
            Hand aiHand = otherPlayer;
            Console.WriteLine("====== Game Start ======");
            ShowBothHand(playerHand,aiHand);
        }
        /// <summary>
        /// 輸出雙方手牌
        /// 格式：
        /// 你的手牌： [ 第 {number} 張 數值：{card.Value} 花色：{card.Suit} ] * 5
        /// 對手的手牌： [ 第 {number} 張 數值：{card.Value} 花色：{card.Suit} ] * 2 [不給你看] *3
        /// </summary> 
        private void ShowBothHand(Hand mainPlayerHand, Hand otherPlayer) {
            Hand playerHand = mainPlayerHand;
            Hand aiHand = otherPlayer;
            int i = 1;
            int j = 1;
            //輸出玩家方手牌
            Console.Write("你的手牌：");
            foreach ( Card card  in playerHand.visableCards)
            {
                ShowInputCard(card, i);
                i++;
            }
            foreach ( Card card in playerHand.hiddinCards)
            {
                ShowInputCard(card, i);
                i++;
            }
            //輸出 AI 方手牌
            Console.Write("對手的手牌：");
            foreach (Card card in aiHand.visableCards)
            {
                ShowInputCard(card, j);
                j++;
            }
            foreach (Card card in aiHand.hiddinCards)
            {
                Console.Write("[不給你看]");
            }
        }
        /// <summary>
        /// 輸出 1張 餵進來的卡
        /// 格式：[ 第 {number} 張 數值：{card.Value} 花色：{card.Suit} ]
        /// </summary> 
        private void ShowInputCard(Card inputCard, int number)
        {
            Card card = inputCard;
            Console.Write("[ ");
            Console.Write("第 ");
            Console.Write(number);
            Console.Write(" 張");
            Console.Write(" ");
            Console.Write("數值： ");
            Console.Write(card.Value);
            Console.Write(" ");
            Console.Write("花色： ");
            Console.Write(card.Suit);
            Console.Write(" ]");
            Console.Write(" ");
        }
    }
}
