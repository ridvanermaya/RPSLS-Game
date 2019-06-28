using System;
namespace RPSLSGame
{
    public class Computer : Player
    {
        // Member Variables (has a)

        // Constructor
        public Computer()
        {
            name = "computer";
        }

        // Members Methods (can do)
        public override void ChooseGesture()
        {
            Console.Clear();
            random = new Random();
            randomNumber = Convert.ToString(random.Next(1, 6));

            switch (randomNumber)
            {
                case "1":
                    Console.WriteLine($"{name} played 'Rock'");
                    gesture = "rock";
                    break;
                case "2":
                    Console.WriteLine($"{name} played 'Paper'");
                    gesture = "paper";
                    break;
                case "3":
                    Console.WriteLine($"{name} played 'Scissors'");
                    gesture = "scissors";
                    break;
                case "4":
                    Console.WriteLine($"{name} played 'Lizard'");
                    gesture = "lizard";
                    break;
                case "5":
                    Console.WriteLine($"{name} played 'Spock'");
                    gesture = "spock";
                    break;
                default:
                    Console.WriteLine("Woops something unexpected happened!");
                    break;
            }
        }
    }
}
