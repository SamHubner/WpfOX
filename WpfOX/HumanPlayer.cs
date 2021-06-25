using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOX
{
    class HumanPlayer : Player
    {

        public HumanPlayer(Board b) : base(b)
        {

        }
        public override int move()
        {
            return -1;
        }
    }
}
