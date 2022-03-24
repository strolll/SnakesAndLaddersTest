using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Game
    {


        private Board board;
        private IDice dice;
        private Turn turn;

        private List<Player> players;


        public void Init()
        {
            board.SetupFromView();
        }

        public void StartNew()
        {
            resetPlayers();
            turn.Reset();
        }

        public void SetPlayers(List<Player> players)
        {
            this.players = players;
            for( int i = 0; i < players.Count; i++ )
                players[i].Id = i;

            turn.Setup(players);
        }

        private void resetPlayers()
        {
            for( int i = 0; i < players.Count; i++ )
                players[i].MoveTo(0);
        }

        public void RollDice()
        {
            int d = dice.Roll();

            
            movePlayer(d);
        }

        public void PostMoveChecks()
        {
            if( checkGameOver() )
                gameOver(turn.CurrentPlayer.Id == 0);
            else
                checkSnakeOrLadder();
        }

        private void checkSnakeOrLadder()
        {
            //TODO: movePlayer(jumpVal);

            turn.Next();
        }

        private void movePlayer(int jumpVal)
        {
            turn.CurrentPlayer.MoveBy(jumpVal);

            // Reached end place?
            if( board.ReachedEndPlace(turn.CurrentPlayer.PlaceId) )
                turn.CurrentPlayer.MoveTo(board.EndPlace);

        }

        private bool checkGameOver()
        {
            return board.ReachedEndPlace(turn.CurrentPlayer.PlaceId);
        }

        private void gameOver(bool humanWon)
        {

        }
    }
}