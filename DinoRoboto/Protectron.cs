using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Protectron : Robot
    {

        public Protectron(string fleetTitle)
        {
            this.fleetTitle = fleetTitle;
            name = "Protectron";
            health = 150;
            powerLevel = 3;
            powerRegen = 1;

        }
        
        
    }
}
