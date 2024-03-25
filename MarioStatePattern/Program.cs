namespace MarioStatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new();

            mario.Idle(); // Invalid

            mario.Jump();
            mario.Jump(); // Invalid

            mario.Walk();
            mario.Run();

            mario.Walk();
            mario.Idle();

            mario.Walk();
        }
    }
}
