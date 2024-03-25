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
            currentState.Walk();
        }

        public void Run()
        {
            currentState.Run();
        }

        public void Jump()
        {
            currentState.Jump();
        }

        public void Idle()
        {
            currentState.Idle();
        }

        internal void ChangeState(IMarioState newState)
        {
            currentState = newState;
        }
    }
}
