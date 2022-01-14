using Poker.Code.Card;
using System;

namespace Poker
{
    class Program
    {
        private static int inputCardIndex;

        public static int InputCardIndex
        {
            get => inputCardIndex;
            set
            {
                inputCardIndex = value;
            }
        }
        static void Main(string[] args) {
            var mainPlayer = new Player("1");
            var otherPlayer = new Player("AI");
            // 產生新的遊戲
            var GM = new GameMaster(mainPlayer, otherPlayer);
            // 幫雙方發牌
            GM.Deal();
            var viewPrinter = new ConsolePrinter();
            // 遊戲開始
            // 回合開始

            Player winner = null;

            while (winner == null)
            {
                //--------持續5回合-------//
                // 顯示雙方剩餘的手牌
                //viewPrinter.ShowBothHand()
                // 顯示目前回合數

                // 請玩家輸入你要打出的牌
                var inputIndex = PlayerInputToCardIndex();
                GM.mainPlayer.CumCard(inputIndex);
                GM.otherPlayer.CumCard(inputIndex);
                // 比大小並計算回合勝利者
                GM.Comparer();
                winner = GM.WinnerCheck();
            }
            // 某玩家勝利
            // 顯示哪個玩家勝利
        }
        /// <summary>
        /// 轉化與確認玩家輸入
        /// </summary>
        static int PlayerInputToCardIndex() {
            bool _inputSucess = false;
            while (!_inputSucess)
            {
                try
                {
                    Console.Write("請輸入你要出第幾張牌:");
                    var inputStr = Console.ReadLine();
                    var result = int.Parse(inputStr);
                    // 根據index查找手牌
                    _inputSucess = true;
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine("輸入錯誤，請重新輸入");
                }
            }
            return -5;
        }
    }
}
