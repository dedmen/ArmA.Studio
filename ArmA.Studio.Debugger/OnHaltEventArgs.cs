﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArmA.Studio.Debugger
{
    public class OnHaltEventArgs : EventArgs
    {
        public string DocumentPath;
        public int Line;
        public int Col;
    }
}