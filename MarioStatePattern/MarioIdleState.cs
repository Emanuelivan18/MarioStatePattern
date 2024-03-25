using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioStatePattern
{
    public class MarioIdleState : IMarioState
    {
        private Mario mario;

        public MarioIdleState(Mario mario)
        {
            this.mario = mario;
        }

        public void Enter()
        {
            Console.WriteLine("Mario is now idle.");
        }
    }
}
