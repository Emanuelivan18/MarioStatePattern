namespace MarioStatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new();

            mario.ChangeState(new MarioIdleState(mario)); // Invalid

            mario.ChangeState(new MarioJumpState(mario));
            mario.ChangeState(new MarioJumpState(mario)); // Invalid

            mario.ChangeState(new MarioWalkState(mario));
            mario.ChangeState(new MarioRunState(mario));

            mario.ChangeState(new MarioWalkState(mario));
            mario.ChangeState(new MarioIdleState(mario));

            mario.ChangeState(new MarioWalkState(mario));
        }
    }
}
