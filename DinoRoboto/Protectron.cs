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
            powerRegen = 5;
            weapons = new Weapon[3] { new Weapon("9mm", 5, 6), new Weapon("Laser Cannon", 12, 10), new Weapon("Stand back, citizen!", 3, -5) };
        }
        
        
    }
}
