using System;
namespace lab1
{
    public class Game
    {
        Players players;
        Board boardGame;
        Player activePlayer;
        bool endGame;

        private Players Players { get { return players; } set { players = value; } }
        private Board Board { get { return boardGame; } set { boardGame = value; } }
        private Player Player { get { return activePlayer; } set { activePlayer = value; } }
        private bool EndGame { get { return endGame; } set { endGame = value; } }


        public void CheckIfEndGame() {
        }
        public void GetWinner()
        {
        }
        public void Play()
        {
        }
    }
}
