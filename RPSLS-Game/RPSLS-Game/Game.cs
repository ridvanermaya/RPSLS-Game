using System;
namespace RPSLSGame
{
    public class Game
    {
        // member variables (has a)
        public Player player1;
        public Player player2;
        public bool validateHand;
        public bool validateYesNo;
        string response;
        public int player1Win;
        public int player2Win;
        Random random;

        // consturctor
        public Game()
        {
            random = new Random();
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
            player1 = new Human();
            player2 = new Human();
            player1Win = 0;
            player2Win = 0;
            Console.WriteLine($"{player1.name} vs {player2.name}");

            while(CheckForWin(player1Win, player2Win))
            {
                string player1Input = player1.PlayerInput();
                string player2Input = player2.PlayerInput();
                string player1Hand = player1.PlayerPlay(player1Input);
                string player2Hand = player2.PlayerPlay(player2Input);

                if (player1Hand == player2Hand)
                {
                    Console.WriteLine("Tie!");
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "rock" && player2Hand == "scissors")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "scissors" && player2Hand == "paper")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "paper" && player2Hand == "rock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "rock" && player2Hand == "lizard")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "lizard" && player2Hand == "spock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "spock" && player2Hand == "scissors")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "Scissors" && player2Hand == "lizard")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "lizard" && player2Hand == "paper")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "paper" && player2Hand == "spock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (player1Hand == "spock" && player2Hand == "rock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else
                {
                    Console.WriteLine($"{player2.name} wins!");
                    player2Win++;
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                }
            }

        }

        // When user chooses single player
        private void SinglePlayer()
        {
            player1 = new Human();
            player2 = new AI(random);
            player1Win = 0;
            player2Win = 0;
            Console.Write($"{player1.name} is playing against {player2.name}");

            while (CheckForWin(player1Win, player2Win))
            {
                string playerInput = player1.PlayerInput();
                string playerHand = player1.PlayerPlay(playerInput);
                string computerHand = player2.ComputerPlay();

                if (playerHand == computerHand)
                {
                    Console.WriteLine("Tie!");
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "rock" && computerHand == "scissors")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "scissors" && computerHand == "paper")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "paper" && computerHand == "rock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "rock" && computerHand == "lizard")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins."); 
                }
                else if (playerHand == "lizard" && computerHand == "spock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "spock" && computerHand == "scissors")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");  
                }
                else if (playerHand == "Scissors" && computerHand == "lizard")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "lizard" && computerHand == "paper")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "paper" && computerHand == "spock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else if (playerHand == "spock" && computerHand == "rock")
                {
                    Console.WriteLine($"{player1.name} wins!");
                    player1Win++;
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                }
                else
                {
                    Console.WriteLine($"{player2.name} wins!");
                    player2Win++;
                    Console.WriteLine($"{player2.name} has {player2Win} wins.");
                    Console.WriteLine($"{player1.name} has {player1Win} wins.");
                }
            }  
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

        public bool CheckForWin(int player1Win, int player2Win)
        {
            if (player1Win >= 2 || player2Win >= 2)
            {
                if (player1Win == 2)
                {
                    Console.WriteLine($"{player1.name} wins!");
                }
                else
                {
                    Console.WriteLine($"{player2.name} wins!");
                }
                return false;
            }
            return true;
        }
    }
}
