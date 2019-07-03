using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : User
    {
        public string userName;
        public string humanGesture;
        string[] gestures = new string[] { "Scissors","Rock","Paper","Lizard","Spock" };
        public override void sendGesture()
        {
            Console.WriteLine("What action do you choose? (Scissors/Rock/Paper/Lizard/Spock");
            string humanGesture = Console.ReadLine();
        }
        public string returnSelection(string gestures)
        {
            Random rand = new Random();
            string index = rand.Next(gestures.Count);
            var gesture = gestures[index];
            gestures.RemoveAt(index);
            return gesture;
        }
    }
}