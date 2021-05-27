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
        private int turn;
        public OnX()
        {
            board = new Board();
            turn = 1;
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
