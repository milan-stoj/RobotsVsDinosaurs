using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class T_800 : Robot
    {
        public T_800(string fleetTitle)
        {
            this.fleetTitle = fleetTitle;
            name = "T-800";
            health = 100;
            powerLevel = 10;
            powerRegen = 5;
        }
        
    }
}
