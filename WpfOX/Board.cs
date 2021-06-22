using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOX
{
    class Board
    {
        OnX g;
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

        public int checkWin()
        {
            int b = g.getTurn();

            if (board[0] == 2 && board[1] == 2 && board[2] == 2)
            {
                return 0;
            }
            if (board[3] == 2 && board[4] == 2 && board[5] == 2)
            {
                return 0;
            }
            if (board[6] == 2 && board[7] == 2 && board[8] == 2)
            {
                return 0;
            }
            if (board[0] == 2 && board[3] == 2 && board[6] == 2)
            {
                return 0;
            }
            if (board[1] == 2 && board[4] == 2 && board[7] == 2)
            {
                return 0;
            }
            if (board[2] == 2 && board[5] == 2 && board[8] == 2)
            {
                return 0;
            }
            if (board[0] == 2 && board[4] == 2 && board[8] == 2)
            {
                return 0;
            }
            if (board[2] == 2 && board[4] == 2 && board[6] == 2)
            {
                return 0;
            }



            if (board[0] == 1 && board[1] == 1 && board[2] == 1)
            {
                return 1;
            }
            if (board[3] == 1 && board[4] == 1 && board[5] == 1)
            {
                return 1;
            }
            if (board[6] == 1 && board[7] == 1 && board[8] == 1)
            {
                return 1;
            }
            if (board[0] == 1 && board[3] == 1 && board[6] == 1)
            {
                return 1;
            }
            if (board[1] == 1 && board[4] == 1 && board[7] == 1)
            {
                return 1;
            }
            if (board[2] == 1 && board[5] == 1 && board[8] == 1)
            {
                return 1;
            }
            if (board[0] == 1 && board[4] == 1 && board[8] == 1)
            {
                return 1;
            }
            if (board[2] == 1 && board[4] == 1 && board[6] == 1)
            {
                return 1;
            }

            else
            {
                return 2;
            }
        }
    }
}