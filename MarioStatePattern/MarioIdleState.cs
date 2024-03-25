using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioStatePattern
{
    public class MarioIdleState : IMarioState
    {
        private readonly Mario mario;

        public MarioIdleState(Mario mario)
        {
            this.mario = mario;
        }

        public void Idle()
        {
            Console.WriteLine("Mario is already idling.");
        }

        public void Jump()
        {
            Console.WriteLine("Mario can't jump from idling.");
        }

        public void Run()
        {
            Console.WriteLine("Mario can't run from idling.");
        }

        public void Walk()
        {
            Console.WriteLine("Mario is now walking.");
            mario.ChangeState(new MarioWalkState(mario));
        }
    }
}
