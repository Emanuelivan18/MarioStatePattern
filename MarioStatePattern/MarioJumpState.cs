using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioStatePattern
{
    public class MarioJumpState : IMarioState
    {
        private Mario mario;

        public MarioJumpState(Mario mario)
        {
            this.mario = mario;
        }

        public void Idle()
        {
            Console.WriteLine("Mario can't idle while jumping.");
        }

        public void Jump()
        {
            Console.WriteLine("Mario is already jumping.");
        }

        public void Run()
        {
            Console.WriteLine("Mario starts running.");
            mario.ChangeState(new MarioRunState(mario));
        }

        public void Walk()
        {
            Console.WriteLine("Mario can't walk while jumping.");
        }
    }
}
