using System;
namespace RPSLSGame
{
    public class Human : Player
    {
        // member variables (has a)
        public string player1Hand;
        public string player2Hand;

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

        // player Inputs
        public string PlayerInput()
        {
            Console.WriteLine("\nMake your move! Type one of the following: 1:Rock, 2:Paper, 3:Scissors, 4:Lizard, and 5:Spock");
            string userInput = Convert.ToString(Console.ReadLine());
            while (!ValidateHand(userInput))
            {
                ValidateHand(userInput);
                Console.WriteLine("Invalid user input.\nPlease type one of the following: 1:Rock, 2:Paper, 3:Scissors, 4:Lizard, and 5:Spock");
                userInput = Convert.ToString(Console.ReadLine());
            }
            return userInput;
        }

        // player plays
        public void PlayerPlay(string userInput)
        {
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
                    Console.WriteLine("Woops something unexpected happened!");
                    break;
            }
        }
    }
}
