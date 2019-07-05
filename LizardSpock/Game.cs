using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
    class Game
    {
        public string firstAction;
        public string secondAction;
        public string gameType;
        List<string> player1WinningRecord = new List<string>();
        List<string> player2WinningRecord = new List<string>();
        public void RunGame()
        {
            Console.WriteLine("RPSLS has two game battle settings: against AI or human. Who are you choosing to battle against? ");

            string gameType = Console.ReadLine();
            Player player1;
            player1 = new Human();
            player1.ChooseName();
            if (gameType == "human")
            {
                Human player2 = new Human();
                return player2;
            }
            else if (gameType == "AI")
            {
                AI player2 = new AI();
                return player2;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please retry and use the word 'AI' or 'human'");
            }
            BattleResults();
            CompareScores();
            Retry();

        }
        public void BattleResults()
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
                        RunGame();
                        break;
                    default:
                        Console.WriteLine("Incorrect type of input from Player 2");
                        RunGame();
                        break;

                }

            }
            else if (firstAction == "Scissors")
            {
                switch (secondAction)
                {
                    case "Scissors":
                        Console.WriteLine("Tie.");
                        BattleResults();
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
                        BattleResults();
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
                        BattleResults();
                        break;
                    case "Rock":
                        Console.WriteLine("User 1 wins.");
                        player1WinningRecord.Add("Win");
                        break;
                    default:
                        Console.WriteLine("Incorrect type of input from Player 2");
                        BattleResults();
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
                        BattleResults();
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
                        BattleResults();
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
                        BattleResults();
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
                        BattleResults();
                        break;

                }

            }
            else
            {
                Console.WriteLine("Incorrect type of input from Player 1");
                BattleResults();
            }
        }
        public void CompareScores()
        {
            if (player1WinningRecord.Length = 2)
            {
                Console.WriteLine("Player 1 wins!");
                return true;
            }
            else if (player2WinningRecord = 2)
            {
                Console.WriteLine("Player 2 wins!");
                return true;
            }
            else
            {
                BattleResults();
            }
        }
        public void Retry()
        {
            Console.WriteLine("Incorrect type of input from Player 1");
            string retryResponse = Console.ReadLine();
            if (retryResponse == "true")
            {
                RunGame();
            }
        }
    }
}
