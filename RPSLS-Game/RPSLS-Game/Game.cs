﻿using System;
using System.Collections.Generic;

namespace RPSLSGame
{
    public class Game
    {
        // member variables (has a)
        public List<string> GameRules;
        public Player player1;
        public Player player2;
        public bool validateYesNo;
        public string response;

        // consturctor
        public Game()
        {

        }

        // member methods (can do)
        public void GameStart()
        {
            AddGameRules();
            DisplayRules();
            Console.WriteLine("\nWelcome to RPSLS Game.");
            Console.WriteLine("\nMultiplayer? If yes type 'yes' if no please type 'no'");

            response = Console.ReadLine().ToLower();
            while (!ValidateYesNo(response))
            {
                ValidateYesNo(response);
                Console.WriteLine("\nInvalid response, Multiplayer? If yes type 'yes' if no please type 'no'");
                response = Console.ReadLine().ToLower();
            }
            if (response == "yes")
            {
                Console.WriteLine("\nStarting a multiplayer game...");
                Multiplayer();
            }
            else
            {
                Console.WriteLine("\nStarting a single player game...");
                SinglePlayer();
            }
            StartNewGame();
        }

        public void StartNewGame()
        {
            Console.WriteLine("\nWould you like to play another game? [yes] or [no]");
            response = Console.ReadLine().ToLower();
            while (!ValidateYesNo(response))
            {
                ValidateYesNo(response);
                Console.WriteLine("\nInvalid response, would you like to play another game?[yes] or [no]");
                response = Console.ReadLine().ToLower();
            }
            if (response == "yes")
            {
                Console.Clear();
                Console.WriteLine("\nStarting a new game...");
                GameStart();
            }
            else
            {
                Console.WriteLine("\nGame over");
            }

        }

        public void CheckForRound()
        {
            while (CheckForWin(player1.currentScore, player2.currentScore))
            {
                Console.WriteLine($"\n{player1.name} choosing!");
                player1.ChooseGesture();
                Console.WriteLine($"\n{player2.name} choosing!");
                player2.ChooseGesture();

                if (player1.gesture == player2.gesture)
                {
                    DisplayTieResult();
                }
                else if ((player1.gesture == "rock" && player2.gesture == "scissors") || (player1.gesture == "rock" && player2.gesture == "lizard"))
                {
                    DisplayPlayer1Win();
                }
                else if ((player1.gesture == "scissors" && player2.gesture == "paper") || (player1.gesture == "scissors" && player2.gesture == "lizard"))
                {
                    DisplayPlayer1Win();
                }
                else if ((player1.gesture == "paper" && player2.gesture == "rock") || (player1.gesture == "paper" && player2.gesture == "spock"))
                {
                    DisplayPlayer1Win();
                }
                else if ((player1.gesture == "lizard" && player2.gesture == "spock") || (player1.gesture == "lizard" && player2.gesture == "paper"))
                {
                    DisplayPlayer1Win();
                }
                else if ((player1.gesture == "spock" && player2.gesture == "scissors") || (player1.gesture == "spock" && player2.gesture == "rock"))
                {
                    DisplayPlayer1Win();
                }
                else
                {
                    DisplayPlayer2Win();
                }
            }
        }

        // When user chooses multiplayer
        public void Multiplayer()
        {
            Console.Write("\nPlease enter a name for player1: ");
            player1 = new Human();
            Console.Write("\nPlease enter a name for player2: ");
            player2 = new Human();
            player1.currentScore = 0;
            player2.currentScore = 0;
            Console.Clear();
            DisplayRules();
            Console.WriteLine($"\n{player1.name} vs {player2.name}");
            CheckForRound();
        }

        // When user chooses single player
        private void SinglePlayer()
        {
            Console.Write("\nPlease enter a name for player1: ");
            player1 = new Human();
            player2 = new Computer();
            player1.currentScore = 0;
            player2.currentScore = 0;
            Console.Clear();
            DisplayRules();
            Console.WriteLine($"\n{player1.name} vs {player2.name}");

            CheckForRound();
        }

        // adds rules to GameRules list
        public void AddGameRules()
        {
            GameRules = new List<string>();
            GameRules.Add("1. Scissors cut Paper");
            GameRules.Add("2. Paper covers Rock");
            GameRules.Add("3. Rock crushes Lizard");
            GameRules.Add("4. Lizard poisons Spock");
            GameRules.Add("5. Spock smashes Scissors");
            GameRules.Add("6. Scissors decapitates Lizard");
            GameRules.Add("7. Lizard eats Paper");
            GameRules.Add("8. Paper disproves Spock");
            GameRules.Add("9. Spock vaporizes Rock");
            GameRules.Add("10. Rock crushes Scissors");
        }

        // displayes game rules
        public void DisplayRules()
        {
            Console.WriteLine("Game Rules\n");
            foreach(string rule in GameRules)
            {
                Console.WriteLine(rule);
            }
        }

        // validates user input for 'yes' and 'no' questions
        public bool ValidateYesNo(string input)
        {
            if (input.ToLower() == "yes" || input.ToLower() == "no")
            {
                return true;
            }
            return false;
        }

        // checks if a player reached 2 wins to determine winner
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

        // displays result when it is 'tie'
        public void DisplayTieResult()
        {
            Console.WriteLine($"\n{player1.name} and {player2.name} had {player1.gesture}");
            Console.WriteLine("TIE");
            DisplayCurrentScore();
        }

        // displays current score of each player
        public void DisplayCurrentScore()
        {
            Console.WriteLine($"\n{player1.name} {player1.currentScore}:{player2.currentScore} {player2.name}");
        }

        // displays when player1 wins a round
        public void DisplayPlayer1Win()
        {
            Console.WriteLine($"\n{player1.name} played {player1.gesture} and {player2.name} played {player2.gesture} \n{player1.name} wins the round!");
            player1.currentScore++;
            DisplayCurrentScore();
        }

        // displays when player2 wins a round
        public void DisplayPlayer2Win()
        {
            Console.WriteLine($"\n{player1.name} played {player1.gesture} and {player2.name} played {player2.gesture} \n{player2.name} wins the round!");
            player2.currentScore++;
            DisplayCurrentScore();
        }
    }
}