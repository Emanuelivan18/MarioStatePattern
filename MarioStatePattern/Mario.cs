using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioStatePattern
{
    public class Mario
    {
        private IMarioState currentState;

        public Mario()
        {
            currentState = new MarioIdleState(this);
        }

        public void Walk()
        {
            ChangeState(new MarioWalkState(this));
        }

        public void Run()
        {
            ChangeState(new MarioRunState(this));
        }

        public void Jump()
        {
            ChangeState(new MarioJumpState(this));
        }

        public void Idle()
        {
            ChangeState(new MarioIdleState(this));
        }

        private void ChangeState(IMarioState newState)
        {
            if (currentState.GetType() != newState.GetType())
            {
                currentState = newState;
                currentState.Enter();
            }
            else
            {
                Console.WriteLine("Mario is already in this state.");
            }
        }
    }
}
