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
        Player aiPlayer;

        public GameMaster(Player mainPlayer, Player ai) {
            // set player
            this.mainPlayer = mainPlayer;
            aiPlayer = ai;
            InitializeGame();
        }
        private void InitializeGame() {
            CurrentRound = 0;
        }
        public void Comparer(Card card1,Card card2) {
           
        }
        public void Deal() { 
        
        
        }
    }
}
