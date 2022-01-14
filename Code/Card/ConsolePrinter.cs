using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class ConsolePrinter
    {
        /// <summary>
        /// 新的遊戲開始叫這支
        /// </summary>
        public void GameStart()
        {
            Console.WriteLine("歡迎來到 蝦☆G8 闇のゲーム！");
            Console.WriteLine("請輸入玩家暨電子本票立約人名稱：");
        }
        /// <summary>
        /// 新的一局開始叫這支，餵他 玩家手牌，AI手牌，目前菊數
        /// </summary>
        public void RoundStart(Hand mainPlayerHand, Hand otherPlayerHand, int currentRound) {
            Hand playerHand = mainPlayerHand;
            Hand aiHand = otherPlayerHand;
            Console.Write("第 ");
            Console.Write(currentRound);
            Console.WriteLine(" 局");
            Console.WriteLine("======= Game Start ======");
            ShowBothHand(playerHand,aiHand);
            Console.WriteLine("請輸入要打出的手牌編號：");
        }
        /// <summary>
        /// 顯示本局比賽結果叫這支 0800-080-552，餵他 玩家出的牌，AI出的牌，贏家 name
        /// </summary>
        public void RoundEnd(Card mainPlayerCard, Card otherPlayerCard ,string winner)
        {
            Card playerCard = mainPlayerCard;
            Card aiCard = otherPlayerCard;
            Console.Write("你出的牌： ");
            ShowInputCard(playerCard);
            Console.WriteLine("");
            Console.Write("對手出的牌： ");
            ShowInputCard(aiCard);
            Console.WriteLine("");
            Console.WriteLine("贏家：");
            Console.Write(winner);
            Console.WriteLine("======= Game End ======");
        }
        /// <summary>
        /// 遊戲結束叫這支
        /// </summary>
        public void GameEnd(string winner)
        {
            Console.Write("恭喜！恭喜！!恭喜我們的");
            Console.Write(winner);
            Console.WriteLine("成功在鋼棍上先刻下3顆★！");
        }
        /// <summary>
        /// 輸出雙方手牌
        /// 格式：
        /// 你的手牌： [ 第 {number} 張 數值：{card.Value} 花色：{card.Suit} ] * 5
        /// 對手的手牌： [ 第 {number} 張 數值：{card.Value} 花色：{card.Suit} ] * 2 [不給你看] * 剩餘張數
        /// </summary> 
        public void ShowBothHand(Hand mainPlayerHand, Hand otherPlayer) {
            Hand playerHand = mainPlayerHand;
            Hand aiHand = otherPlayer;
            int i = 1;
            int j = 1;
            //輸出玩家方手牌
            Console.WriteLine("你的手牌：");
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
            Console.WriteLine("對手的手牌：");
            foreach (Card card in aiHand.visableCards)
            {
                ShowInputCard(card, j);
                j++;
            }
            foreach (Card card in aiHand.hiddinCards)
            {
                Console.Write("[不給你看] ");
            }
            Console.WriteLine("------------------");
        }
        /// <summary>
        /// 輸出 1張 餵進來的卡
        /// 格式：[ 數值：{card.Value} 花色：{card.Suit} ]
        /// </summary> 
        private void ShowInputCard(Card inputCard)
        {
            Card card = inputCard;
            Console.Write("[ ");
            Console.Write("數值： ");
            Console.Write(card.Value);
            Console.Write(" ");
            Console.Write("花色： ");
            Console.Write(card.Suit);
            Console.Write(" ]");
            Console.Write(" ");
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
