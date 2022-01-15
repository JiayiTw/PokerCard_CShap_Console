using Poker.Code.Card;
using System;
using System.Text;

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

            Console.OutputEncoding = Encoding.UTF8;

            var viewPrinter = new ConsolePrinter();
            viewPrinter.GameStart();
            var inputName = Console.ReadLine();

            var mainPlayer = new Player(inputName);
            var otherPlayer = new Player("AI");
            // 產生新的遊戲
            var GM = new GameMaster(mainPlayer, otherPlayer);
            // 幫雙方發牌
            GM.Deal();

            // 遊戲開始
            // 回合開始

            Player _laterWinner = null;

            while (_laterWinner == null)
            {
                //--------持續5回合-------//
                // 顯示雙方剩餘的手牌
                viewPrinter.RoundStart(GM.mainPlayer.handDeck, GM.otherPlayer.handDeck, GM.CurrentRound);
                //viewPrinter.ShowBothHand()
                // 顯示目前回合數

                // 請玩家輸入你要打出的牌
                var inputIndex = PlayerInputToCardIndex();
                GM.roundData.currentMainCard = GM.mainPlayer.CumCard(inputIndex);

                GM.roundData.currentOtherCard = GM.otherPlayer.CumCard(inputIndex);

                ////// 比大小並計算回合勝利者
                GM.Comparer();
                _laterWinner = GM.WinnerCheck();

                viewPrinter.RoundEnd(GM.roundData.currentMainCard,
                    GM.roundData.currentOtherCard,
                    GM.roundData.wonPlayers[GM.CurrentRound - 1].Name);

                GM.CurrentRound++;


            }
            // 某玩家勝利
            // 顯示哪個玩家勝利
            viewPrinter.GameEnd(_laterWinner.Name);
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
                    //Console.Write("請輸入你要出第幾張牌:");
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
