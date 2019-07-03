using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPSLS has two game battle settings: against AI or human. Who are you choosing to battle against? ");
            if (Console.ReadLine();="human") 
            {
                BattleResultHuman.Battle();
                LogResult.PushResult();
                //player 1 and player 2 should have lists that we push each victory towards
                //if user doesn't have 2 wins, replay, if they have 2 wins, alert a winner and end game
            }
            else if (result is ai)
            {
                BattleResultAI.Battle();
                LogResult.PushResult();
                //player 1 and player 2 should have lists that we push each victory towards
                //if user doesn't have 2 wins, replay, if they have 2 wins, alert a winner and end game
            }
        }
   }

}