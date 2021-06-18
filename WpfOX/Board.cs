using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOX
{
    class Board
    {
        private int[] board = new int[9];

        public bool addCounter(int pos, int counter)
        {
            bool added = false;
            if (pos < 0 || pos > 8) return false;
            if (counter != 1 && counter != 2) return false;

            if (board[pos] == 0)
            {
                board[pos] = counter;
                added = true;
            }

            return added;
        }

        public int[] getBoard()
        {
            return board;
        }

        public int checkWin(int pos)
        { 

        }
    }
}