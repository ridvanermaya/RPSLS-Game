using System;

namespace RPSLSGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AI computer = new AI(new Random());
            Game newGame = new Game();
        }
    }
}
