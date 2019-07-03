using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class BattleResultAI
    {
        public string firstAction;
        public string secondAction;
        IList<string> actionList = new List<string>({"Rock", "Spock", "Scissors", "Paper", "Lizard"});
        public string Battle()
        {
            Console.WriteLine("Player 1. What is your choice?");
            string firstAction = Console.ReadLine();
            Console.WriteLine("Player 2. What is your choice?");
            string secondAction = Console.ReadLine();
            if (firstAction == "Rock")
            {
                switch (secondAction)
                {
                    case "Scissors":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Lizard":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Spock":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
                        break;
                    case "Paper":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
                        break;
                    case "Rock":
                        Console.WriteLine("Tie.");
                        //return to program and tell users to retry
                        break;
                    default:
                        Console.WriteLine("Incorrect type of input from Player 2");
                        //restarts function
                        break;

                }

            }
            else if (firstAction == "Scissors")
            {
                switch (secondAction)
                {
                    case "Scissors":
                        Console.WriteLine("Tie.");
                    //return to program and tell users to retry
                        break;   
                    case "Lizard":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Paper":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Rock":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
                        break;
                    case "Spock":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
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
                        //return to program and add score
                        break;
                    case "Lizard":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
                        break;
                    case "Spock":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Paper":
                        Console.WriteLine("Tie.");
                        //return to program and tells users to retry
                        break;
                    case "Rock":
                        Console.WriteLine("User 1 wins.");
                        //return to program and adds score
                        break;
                    default:
                        Console.WriteLine("Incorrect type of input from Player 2");
                        //function
                        break;

                }

            }
            else if (firstAction == "Lizard")
            {
                switch (secondAction)
                {
                    case "Scissors":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
                        break;
                    case "Lizard":
                        Console.WriteLine("Tie.");
                        //return to program and tells users to retry.
                        break;
                    case "Spock":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Paper":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Rock":
                        Console.WriteLine("User 2 wins.");
                        //return to program and adds score
                        break;
                    default:
                        Console.WriteLine("Incorrect type of input from Player 2");
                        //restarts function
                        break;

                }

            }
            else if (firstAction == "Spock")
            {
                switch (secondAction)
                {
                    case "Scissors":
                        Console.WriteLine("User 1 wins.");
                        //return to program and add score
                        break;
                    case "Lizard":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
                        break;
                    case "Spock":
                        Console.WriteLine("Tie.");
                        //return to program and tells user to retry
                        break;
                    case "Paper":
                        Console.WriteLine("User 2 wins.");
                        //return to program and add score
                        break;
                    case "Rock":
                        Console.WriteLine("User 1 wins.");
                        //return to program and adds score
                        break;
                    default:
                        Console.WriteLine("Incorrect type of input from Player 2");
                        //restarts function
                        break;

                }

            }
            else
            {
                Console.WriteLine("Incorrect type of input from Player 1");
            }
        }
    }
}
