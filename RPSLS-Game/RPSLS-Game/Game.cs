using System;
namespace RPSLSGame
{
    public class Game
    {
        // member variables (has a)
        public Human player;
        public AI computer;
        public bool validateHand;
        public bool validateYesNo;
        string response;

        // consturctor
        public Game()
        {
            GameStart();
            if (response == "yes")
            {
                Console.WriteLine("Starting a multiplayer game...");
                Multiplayer();
            }
            else
            {
                Console.WriteLine("Starting a single player game...");
                SinglePlayer();
            }
        }

        // member methods (can do)
        public string GameStart()
        {
            DisplayRules();
            Console.WriteLine("\nWelcome to RPSLS Game. This game can be played against computer or with a friend.");
            Console.WriteLine("\nWould you like to play against a friend? If yes type 'yes' if no please type 'no'");

            response = Console.ReadLine();
            while (!ValidateYesNo(response))
            {
                ValidateYesNo(response);
                Console.WriteLine("Invalid response, Would you like to play against a friend? If yes type 'yes' if no please type 'no'");
                response = Console.ReadLine();
            }
            return response;
        }

        // When user chooses multiplayer
        public void Multiplayer()
        {

        }

        // When user chooses single player
        public void SinglePlayer()
        {
            Human player1 = new Human();
            AI computer = new AI();
            Console.Write($"{player1.name} is playing against {computer.name}");
            string playerInput = player1.PlayerInput();
            player1.PlayerPlay(playerInput);
        }

        public void DisplayRules()
        {
            Console.WriteLine("Game Rules\n1. Scissors cut Paper, \n2. Paper covers Rock, \n3. Rock crushes Lizard," +
                "\n4. Lizard poisons Spock, \n5. Spock smashes Scissors, \n6. Scissors decapitates Lizard," +
                "\n7. Lizard eats Paper, \n8. Paper disproves Spock, \n9. Spock vaporizes Rock," +
                "\n10. And as always Rock crushes Scissors.");
        }

        public bool ValidateYesNo(string input)
        {
            if (input.ToLower() == "yes" || input.ToLower() == "no")
            {
                return true;
            }
            return false;
        }

        public bool ValidateHand(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5")
            {
                return true;
            }
            return false;
        }
    }
}
