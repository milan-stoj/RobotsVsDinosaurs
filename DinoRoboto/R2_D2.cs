using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class R2_D2 : Robot
    {
        public R2_D2(string fleetTitle)
        {
            this.fleetTitle = fleetTitle;
            name = "R2-D2";
            health = 75;
            powerLevel = 5;
            powerRegen = 3;
            weapons = new Weapon[3] { new Weapon("Shock", 10, 4), new Weapon("Blaster Beam", 15, 7), new Weapon("WOOooOOOOoooOOoohhh!", 0, 0) };

        }
    }
}
