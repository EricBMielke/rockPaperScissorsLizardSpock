using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        public string userName;
        public string humanGesture;
        string[] gestures = new string[] { "Scissors","Rock","Paper","Lizard","Spock" };
        public override void SendGesture()
        {
            Console.WriteLine("What action do you choose? (Scissors/Rock/Paper/Lizard/Spock");
            string humanGesture = Console.ReadLine();
        }
        public override void ChooseName()
        {
            string userName = "Arty Intelligence";
            Console.WriteLine("User 2 is " + userName);
        }
        // string returnSelection(string gestures)
        //{
        //    Random rand = new Random();
        //    string index = rand.Next(gestures.Count);
        //    var gesture = gestures[index];
        //    gestures.RemoveAt(index);
        //    return gesture;
        //}
    }
}