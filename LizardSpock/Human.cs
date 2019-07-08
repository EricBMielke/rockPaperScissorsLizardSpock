using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
    public class Human : Player
    {
        public string name;
        public string humanGesture;

        public override void ChooseName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
        }
        public override string SendGesture()
        {
            Console.WriteLine("What action do you choose? (Scissors/Rock/Paper/Lizard/Spock) ");
            string humanGesture = Console.ReadLine();
            return humanGesture;
        }
    }
}
