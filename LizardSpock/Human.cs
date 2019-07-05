using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
    public class Human : Player
    {
        public string userName;
        public string humanGesture;

        public override void ChooseName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
        }
        public override void SendGesture()
        {
            Console.WriteLine("What action do you choose? (Scissors/Rock/Paper/Lizard/Spock");
            string humanGesture = Console.ReadLine();
        }
    }
}
