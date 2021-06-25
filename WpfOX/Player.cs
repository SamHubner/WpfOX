using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOX
{

    abstract class Player

    {
        protected Board b;
        public Player(Board board)
        {
            b = board;
        }
        abstract public int move();

       
    }
}
