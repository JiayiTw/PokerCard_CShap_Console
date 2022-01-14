using Poker.Code.Card;
using System;

namespace Poker
{
    class Program
    {
        private static int inputCardIndex;

        public static int InputCardIndex { get => inputCardIndex; set => inputCardIndex = value; }

        static void Main(string[] args) {
            //var mainPlayer = new Player("1");
            //var otherPlayer = new Player("AI");
            //// 產生新的遊戲
            //var GM = new GameMaster(mainPlayer, otherPlayer);
            //// 幫雙方發牌
            //GM.Deal();
            //var viewPrinter = new ConsolePrinter();
            // 遊戲開始
            // 回合開始

            //--------持續5回合-------//
            // 顯示雙方剩餘的手牌
            //viewPrinter.ShowBothHand()
            // 顯示目前回合數

            // 請玩家輸入你要打出的牌
            PlayerInput();

            // 比大小並計算回合勝利者
        }

        static void PlayerInput() {
            bool _inputSucess = false;
            while (!_inputSucess)
            {
                try
                {
                    Console.Write("請輸入你要出第幾張牌:");
                    var inputStr = Console.ReadLine();
                    InputCardIndex = int.Parse(inputStr);
                    _inputSucess = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("輸入錯誤，請重新輸入");
                }
            }
        }

    }
}
