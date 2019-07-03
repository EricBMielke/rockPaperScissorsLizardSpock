using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class User
    {
        public string name;
        public string score;

        public abstract void sendGesture();
        public virtual void chooseName()
        {
            Console.WriteLine("The name is Arty Intelly");
        }

    }

}
