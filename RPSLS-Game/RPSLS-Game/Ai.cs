using System;
namespace RPSLSGame
{
    public class AI : Player
    {
        // Member Variables (has a)
        public string computerHand;
        public int randomNumber;

        // Constructor
        public AI()
        {
            name = "Computer";
        }

        // Members Methods (can do)
        // creates a random number
        public int RandomNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 5);
            return number;
        }

        public void ComputerPlay(string userInput)
        {

        }
    }
}
