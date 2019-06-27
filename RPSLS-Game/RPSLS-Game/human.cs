using System;
namespace RPSLSGame
{
    public class Human : Player
    {
        // member variables (has a)

        // constructor
        public Human()
        {
            SetName();
        }

        // member methods (can do)
        // set user's name requiring input
        public string SetName()
        {
            Console.Write("Please enter your name:");
            return name = Convert.ToString(Console.ReadLine());
        }
    }
}
