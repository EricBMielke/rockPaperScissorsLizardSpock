using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
    class Game
    {
        public string firstAction = "nothing";
        public string secondAction = "nothing";
        List<string> player1WinningRecord = new List<string>();
        List<string> player2WinningRecord = new List<string>();
        Player player1;
        Player player2;
        public string gameType;

        public void RunGame()
        {
            do
            {
                Console.WriteLine("RPSLS has two game battle settings: against AI or human. Who are you choosing to battle against?");
                string gameType = Console.ReadLine();
                player1 = new Human();
                player1.ChooseName();
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
            }
            //This while loop is currently broken, it forever loops
            while (gameType != "human" || gameType != "AI");
            BattleResults();
            CompareScores();
            Console.WriteLine("Would you like to retry?");
            string retryResponse = Console.ReadLine();
            if (retryResponse == "true")
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
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine("Tie.");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from Player 2");
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
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from Player 2");
                            break;
                    }

                }
                else if (firstAction == "Paper")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine("Tie.");
                            break;
                        case "Rock":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from Player 2");
                            break;
                    }
                }
                else if (firstAction == "Lizard")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine("Tie.");
                            break;
                        case "Spock":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Paper":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from Player 2");
                            break;

                    }

                }
                else if (firstAction == "Spock")
                {
                    switch (secondAction)
                    {
                        case "Scissors":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        case "Lizard":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Spock":
                            Console.WriteLine("Tie.");
                            break;
                        case "Paper":
                            Console.WriteLine("User 2 wins.");
                            player2WinningRecord.Add("Win");
                            break;
                        case "Rock":
                            Console.WriteLine("User 1 wins.");
                            player1WinningRecord.Add("Win");
                            break;
                        default:
                            Console.WriteLine("Incorrect type of input from Player 2");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect type of input from Player 1");
                    BattleResults();
                }
            }
            while (player1WinningRecord.Count == 2 || player2WinningRecord.Count == 2);
        }
        public void CompareScores()
        {
            if (player1WinningRecord.Count == 2)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (player2WinningRecord.Count == 2)
            {
                Console.WriteLine("Player 2 wins!");
            }
        }
    }
}
