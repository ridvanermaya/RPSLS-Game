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
            Console.WriteLine("Please enter your name:");
            return name = Convert.ToString(Console.ReadLine());
        }

        // player plays
        public void PlayerPlay()
        {
            Console.WriteLine("Make your move! Type one of the following: 1:Rock, 2:Paper, 3:Scissors, 4:Lizard, and 5:Spock");
            string userInput = Convert.ToString(Console.ReadLine());
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"{name} played 'Rock'");
                    break;
                case "2":
                    Console.WriteLine($"{name} played 'Paper'");
                    break;
                case "3":
                    Console.WriteLine($"{name} played 'Scissors'");
                    break;
                case "4":
                    Console.WriteLine($"{name} played 'Lizard'");
                    break;
                case "5":
                    Console.WriteLine($"{name} played 'Spock'");
                    break;
                default:
                    Console.WriteLine("Given input is invalid! Please provide a number 1-6.");
                    break;
            }
        }
    }
}
