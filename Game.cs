using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public void RunGame()
        {
            Console.WriteLine("RPSLS has two game battle settings: against AI or human. Who are you choosing to battle against? ");

            string gameType = Console.ReadLine();
            Player user1;
            user1 = new Human();
            user1.ChooseName();

            if (gameType == "human")
            {
                Human user2 = new Human();
                //player 1 and player 2 should have lists that we push each victory towards
                //if user doesn't have 2 wins, replay, if they have 2 wins, alert a winner and end game
            }
            else if (gameType == "AI")
            {
                AI user2 = new AI();
                //player 1 and player 2 should have lists that we push each victory towards
                //if user doesn't have 2 wins, replay, if they have 2 wins, alert a winner and end game
            }
            else
            {
                Console.WriteLine("Invalid selection. Please retry and use the word 'AI' or 'human'");
            }
        }
    }
}
