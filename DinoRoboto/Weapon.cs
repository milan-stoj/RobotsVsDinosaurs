using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Weapon
    {
        public string type;
        public int attackPower;
        public int powerCost;
        string attackType;

        public Weapon(string type, int attackPower, int powerCost)
        {
            this.type = type;
            this.attackPower = attackPower;
            this.powerCost = powerCost;
        }
    }

   
}
