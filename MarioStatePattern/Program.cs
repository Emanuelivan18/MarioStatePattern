namespace MarioStatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new();

            mario.Idle(); // Invalid

            mario.Jump(); // Invalid
            mario.Jump(); // Invalid

            mario.Walk();
            mario.Run();

            mario.Walk();
            mario.Idle();
            mario.Run(); // Invalid
            mario.Jump(); // Invalid

            mario.Walk();
        }
    }
}
