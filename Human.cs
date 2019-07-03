using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : User
    {
        public string userName;
        public string humanGesture;

        public override void chooseName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
        }
         public override void sendGesture()
        {
        Console.WriteLine("What action do you choose? (Scissors/Rock/Paper/Lizard/Spock");
             string humanGesture = Console.ReadLine();
        }
    }
}
