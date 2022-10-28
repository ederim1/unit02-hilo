
namespace hilo.Game
{
    public static class Program
    {
        /// <param name="args">The given arguments.</param>
        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }

    }
}