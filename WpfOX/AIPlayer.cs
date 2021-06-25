using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOX
{
    class AIPlayer : Player
    {
        
        public AIPlayer(Board b) : base(b)
        {
     
            
        }


        public override int move()
        {
            Random rnd = new Random();
            int pos = rnd.Next(0, 8);
            b.addCounter(pos, 1);
            return pos;
        }
    }
}
