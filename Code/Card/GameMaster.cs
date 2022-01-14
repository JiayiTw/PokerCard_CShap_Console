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
        public int CurrentRound { get => currentRound; private set => currentRound = value; }

        /// <summary>
        /// 主要玩家
        /// </summary>
        Player mainPlayer;
        /// <summary>
        /// 電腦玩家
        /// </summary>
        Player otherPlayer;

        Deck mainDeck;

        public GameMaster(Player mainPlayer, Player ai) {
            // set player
            this.mainPlayer = mainPlayer;
            otherPlayer = ai;
            InitializeGame();
        }
        private void InitializeGame() {
            //初始化回合
            CurrentRound = 0;
            // 初始化牌組
            mainDeck = new Deck();
        }
        public void Comparer(Card card1, Card card2) {

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
