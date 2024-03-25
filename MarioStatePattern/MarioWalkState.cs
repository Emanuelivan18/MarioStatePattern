using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioStatePattern
{
    public class MarioWalkState : IMarioState
    {
        private Mario mario;

        public MarioWalkState(Mario mario)
        {
            this.mario = mario;
        }

        public void Idle()
        {
            Console.WriteLine("Mario stops walking.");
            mario.ChangeState(new MarioIdleState(mario));
        }

        public void Jump()
        {
            Console.WriteLine("Mario can't jump while walking.");
        }

        public void Run()
        {
            Console.WriteLine("Mario is now running.");
            mario.ChangeState(new MarioRunState(mario));
        }

        public void Walk()
        {
            Console.WriteLine("Mario is already walking.");
        }
    }
}
