using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOX
{
    class OnX
    {
        private Board board;
        private Player player1;
        private Player player2;
        public int turn;

        Player[] players = new Player[2];
        public OnX()
        {
            board = new Board();
            turn = 1;

            player1 = new HumanPlayer();
            player2 = new HumanPlayer();

            players[0] = player1;
            players[1] = player2;
        }

        public void move()
        {
            players[turn].move();
        }

        public int addCounter(int pos)
        {
            int winStatus = 0;
            bool added = false;
            added = board.addCounter(pos, turn);
            if (added == true)
            {
                if (turn == 1)
                {
                    turn = 2;
                }
                else turn = 1;
            }
            winStatus = board.checkWin(); 
            return winStatus;
        }

        public Board getBoard()
        {
            return board;
        }
        public int getTurn()
        {
            return turn;
        }

        
    }
}
