using System;
using System.Collections.Generic;

namespace RPSLSGame
{
    public class Player
    {
        // member variables (has a)
        public string name;
        public List<string> Gestures = new List<string>();
        public string gesture;
        public string player1Hand;
        public string player2Hand;
        public int randomNumber;
        public Random random;

        // constructor
        public Player()
        {
            
        }

        // member methods (can do)
        // inform the user if wins
        public void Win()
        {
            Console.WriteLine($"{name} won!");
        }

        // player plays
        public string PlayerPlay(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"{name} played 'Rock'");
                    return gesture = "rock";
                case "2":
                    Console.WriteLine($"{name} played 'Paper'");
                    return gesture = "paper";
                case "3":
                    Console.WriteLine($"{name} played 'Scissors'");
                    return gesture = "scissors";
                case "4":
                    Console.WriteLine($"{name} played 'Lizard'");
                    return gesture = "lizard";
                case "5":
                    Console.WriteLine($"{name} played 'Spock'");
                    return gesture = "spock";
                default:
                    Console.WriteLine("Woops something unexpected happened!");
                    return gesture = "";
            }
        }
        public string ComputerPlay()
        {
            switch (Convert.ToString(RandomNumber()))
            {
                case "1":
                    Console.WriteLine($"{name} played 'Rock'");
                    return gesture = "rock";
                case "2":
                    Console.WriteLine($"{name} played 'Paper'");
                    return gesture = "paper";
                case "3":
                    Console.WriteLine($"{name} played 'Scissors'");
                    return gesture = "scissors";
                case "4":
                    Console.WriteLine($"{name} played 'Lizard'");
                    return gesture = "lizard";
                case "5":
                    Console.WriteLine($"{name} played 'Spock'");
                    return gesture = "spock";
                default:
                    Console.WriteLine("Woops something unexpected happened!");
                    return gesture = "";
            }
        }

        public int RandomNumber()
        {
            randomNumber = random.Next(1, 6);
            return randomNumber;
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

        // inform the user if loses
        public void Lose()
        {
            Console.WriteLine($"{name} lose!");
        }

        // validates user input
        public bool ValidateHand(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5")
            {
                return true;
            }
            return false;
        }

        // add gestures to gestures List
        public void AddGestures()
        {
            Gestures.Add("rock");
            Gestures.Add("paper");
            Gestures.Add("scissors");
            Gestures.Add("lizard");
            Gestures.Add("spock");
        }

        public void Play()
        {
            Console.WriteLine($"{name} played {gesture}");
        }
    }
}
