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

        public void Idle()
        {
            Console.WriteLine("Mario can't idle while running.");
        }

        public void Jump()
        {
            Console.WriteLine("Mario is now jumping.");
            mario.ChangeState(new MarioJumpState(mario));
        }

        public void Run()
        {
            Console.WriteLine("Mario is already running.");
        }

        public void Walk()
        {
            Console.WriteLine("Mario stops running and starts walking.");
            mario.ChangeState(new MarioWalkState(mario));
        }
    }
}
