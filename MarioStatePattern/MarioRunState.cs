using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioStatePattern
{
    public class MarioRunState : IMarioState
    {
        private Mario mario;

        public MarioRunState(Mario mario)
        {
            this.mario = mario;
        }

        public void Enter()
        {
            Console.WriteLine("Mario is now running.");
        }
    }
}
