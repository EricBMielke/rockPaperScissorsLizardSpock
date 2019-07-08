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
        List<string> gestureList = new List<string>();

        public override string SendGesture()
        {
            gestureList.Add("Scissors");
            gestureList.Add("Rock");
            gestureList.Add("Paper");
            gestureList.Add("Lizard");
            gestureList.Add("Spock");
            Random rnd = new Random();
            int gestureNumber  = rnd.Next(4);
            string actualGesture = gestureList[gestureNumber];
            return actualGesture;
        }
        public override void ChooseName()
        {
            string userName = "Arty Intelligence";
            Console.WriteLine("Player 2 is " + userName);
        }
    }
}
