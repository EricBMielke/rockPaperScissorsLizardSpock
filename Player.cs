﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public string score;
        public abstract void SendGesture();
        public abstract void ChooseName();

    }

}