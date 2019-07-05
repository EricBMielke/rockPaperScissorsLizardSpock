using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
    public class AI : Player 
    {
        public string userName;
        public string humanGesture;
        string[] gestures = new string[] { "Scissors", "Rock", "Paper", "Lizard", "Spock" };
        public override string SendGesture()
        {
            Random rnd = new Random();
            int gestureNumber  = rnd.Next(4);
            string actualGesture = gestures[gestureNumber];
            return actualGesture;
        }
        public override void ChooseName()
        {
            string userName = "Arty Intelligence";
            Console.WriteLine("Player 2 is " + userName);
        }
    }
}
