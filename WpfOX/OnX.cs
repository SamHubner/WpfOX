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
        private int turn;

        Player[] players = new Player[2];
        public OnX()
        {
            board = new Board();
            turn = 1;

            player1 = new Player();
            player2 = new Player();

            players[0] = player1;
            players[1] = player2;
        }

        public bool addCounter(int pos)
        {
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
            return added; ;
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
