using System;
namespace RPSLSGame
{
    public class Game
    {
        // member variables (has a)
        Player player;
        AI computer;
        bool validateHand;
        bool validateYesNo;

        // consturctor
        public Game()
        {
            GameStart();
        }

        // member methods (can do)
        public void GameStart()
        {
            DisplayRules();
            Console.WriteLine("\nWelcome to RPSLS Game. This game can be played against computer or a friend.");
            Console.WriteLine("\nPlease type one of the following.. type '1' for single player or '2' for multiplayer.");
        }

        public bool ValidateYesNo (string response)
        {
            while (true)
            {
                if (response != "yes" || response != "no")
                {
                    Console.WriteLine("Invalid response, please enter again.");
                    return true;
                }
                return false;
            }
            
        }

        public bool ValidateHand (string response)
        {
            while (true) {
                if (response != "1" || response != "2" || response != "3" || response != "4" || response != "5")
                {
                    Console.WriteLine("Invalid response, please enter again.");
                    return false;
                }
                return true;
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Game Rules\n1. Scissors cut Paper, \n2. Paper covers Rock, \n3. Rock crushes Lizard," +
                "\n4. Lizard poisons Spock, \n5. Spock smashes Scissors, \n6. Scissors decapitates Lizard," +
                "\n7. Lizard eats Paper, \n8. Paper disproves Spock, \n9. Spock vaporizes Rock," +
                "\n10. And as always Rock crushes Scissors.");
        }
    }
}
