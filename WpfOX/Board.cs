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
        private int [,] winLines = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

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
            int winStatus = 3;

            for (int player = 1; player < 3; player = player + 1)
            {
                for (int i = 0; i < winLines.Length / 3; i = i + 1)
                {
                    if (board[winLines[i, 0]] == player && board[winLines[i, 1]] == player && board[winLines[i, 2]] == player)
                    {
                        winStatus = player;
                        return winStatus;
                    }
                    
                }
            }
            return winStatus;
        }
    }
}