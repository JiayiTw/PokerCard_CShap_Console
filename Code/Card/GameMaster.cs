using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Code.Card
{
    class GameMaster
    {
        private int currentRound;
        /// <summary>
        /// 當前回合
        /// </summary>
        public int CurrentRound { get => currentRound; set => currentRound = value; }
        /// <summary>
        /// 主要玩家
        /// </summary>
        public Player mainPlayer;
        /// <summary>
        /// 電腦玩家
        /// </summary>
        public Player otherPlayer;

        Deck mainDeck;
        //---------回合變數---------//
        public RoundData roundData { get; private set; }
        /// <summary>
        /// 不要用我
        /// </summary>
        public GameMaster() {
            // 不要用我
        }
        //建構子
        public GameMaster(Player mainPlayer, Player ai) {
            // set player
            this.mainPlayer = mainPlayer;
            otherPlayer = ai;
            InitializeGame();
        }

        private void InitializeGame() {
            //初始化回合
            CurrentRound = 1;
            // 初始化牌組
            mainDeck = new Deck();
            roundData = new RoundData();
        }
        /// <summary>
        /// 幫兩位玩家比大小
        /// </summary>        
        public void Comparer() {
            if (roundData.currentMainCard.IsBiggerThan(roundData.currentOtherCard))
            {
                // 主玩家屌比較大
                // 增加主玩家勝利次數
                roundData.wonPlayers[CurrentRound - 1] = mainPlayer;
            }
            else
            {
                // 另一位玩家屌比較大
                roundData.wonPlayers[CurrentRound - 1] = otherPlayer;
            }

        }
        // 確認是否有玩家勝利
        public Player WinnerCheck() {

            if (CurrentRound < 3)
                return null;
            var mainWonTimes = 0;
            var otherWonTimes = 0;

            foreach (var wonPlayer in roundData.wonPlayers)
            {
                if (wonPlayer == mainPlayer)
                {
                    mainWonTimes++;
                }
                else if (wonPlayer == otherPlayer)
                {
                    otherWonTimes++;
                }
            }
            if (mainWonTimes >= 3)
            {
                return mainPlayer;
            }
            if (otherWonTimes >= 3)
            {
                return otherPlayer;
            }            
            return null;
        }
        /// <summary>
        /// 發牌給雙方
        /// </summary>
        public void Deal() {
            //幫玩家發牌
            SetHandToPlayer(mainPlayer);
            //幫電腦發牌
            SetHandToPlayer(otherPlayer);
        }

        private void SetHandToPlayer(Player player) {

            var _newHand = new Hand();
            const int _visableCount = 2;
            const int _hiddenCount = 3;
            // 抽兩張牌到隱藏
            for (int i = 0; i < _visableCount; i++)
            {
                _newHand.visableCards.Add(mainDeck.Drawcard());
            }
            // 抽三張牌到隱藏           
            for (int i = 0; i < _hiddenCount; i++)
            {
                _newHand.hiddinCards.Add(mainDeck.Drawcard());
            }
            player.handDeck = _newHand;
        }
    }
}
