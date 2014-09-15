using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{

    public class StateButtonEvents
    {
        public delegate void PBClickLogic(int x, int y);
        public delegate void OnLogic();
        public delegate void OffLogic();

        public PBClickLogic PBClick { set; get; }
        public OnLogic On { set; get; }
        public OffLogic Off { set; get; }
    }
}
