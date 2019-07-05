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
        public override void SendGesture()
        {
            Random rand = new Random();
            string index = rand.Next(gestures.Count);
            var gesture = gestures[index];
            return gesture;
        }
        public override void ChooseName()
        {
            string userName = "Arty Intelligence";
            Console.WriteLine("Player 2 is " + userName);
        }
    }
}
