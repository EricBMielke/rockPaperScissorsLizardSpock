﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
    class Game
    {
        Player player1;
        Player player2;

        public void RunGame()
        {
            string gameType;
            do
            {
                Console.WriteLine("RPSLS has two game battle settings: against AI or human. Who are you choosing to battle against?");
                gameType = Console.ReadLine();
                player1 = new Human();
                player1.name = player1.ChooseName();
                if (gameType == "human")
                {
                    player2 = new Human();
                }
                else if (gameType == "AI")
                {
                    player2 = new AI();
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please retry and use the word 'AI' or 'human'");
                }
                player2.name = player2.ChooseName();
            }
            while (gameType != "human" && gameType != "AI");
            BattleResults();
            CompareScores();
            Console.WriteLine("Would you like to retry?");
            string retryResponse = Console.ReadLine();
            if (retryResponse == "yes" || retryResponse == "Yes" || retryResponse == "yeah")
            {
                RunGame();
            }

        }
        public void BattleResults()
        {
            do
            {
                string firstAction = player1.SendGesture();
                string secondAction = player2.SendGesture();
                if (firstAction == "Rock")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine("Tie.");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from " + player2.name);
                            break;

                    }

                }
                else if (firstAction == "Scissors")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine("Tie.");
                            break;
                        case "Lizard":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from " + player2.name);
                            break;
                    }

                }
                else if (firstAction == "Paper")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine("Tie.");
                            break;
                        case "Rock":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from " + player2.name);
                            break;
                    }
                }
                else if (firstAction == "Lizard")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine("Tie.");
                            break;
                        case "Spock":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from " + player2.name);
                            break;

                    }

                }
                else if (firstAction == "Spock")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine("Tie.");
                            break;
                        case "Paper":
                            Console.WriteLine(player2.name + " wins.");
                            player2.winningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine(player1.name + " wins.");
                            player1.winningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from " + player2.name);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect type of input from " + player1.name);
                    BattleResults();
                }
            }
            while (player1.winningRecord.Count != 2 && player2.winningRecord.Count != 2);
        }
        public void CompareScores()
        {
            if (player1.winningRecord.Count == 2)
            {
                Console.WriteLine(player1.name + " wins the best of 3 series!");
            }
            else if (player2.winningRecord.Count == 2)
            {
                Console.WriteLine(player2.name + " wins the best of 3 series!");
            }
        }
    }
}
