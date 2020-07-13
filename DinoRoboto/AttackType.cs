using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class AttackType
    {
        string type;
        public int attackPower;
        public int powerCost;

        public AttackType(string type, int attackPower, int powerCost)
        {
            this.type = type;
            this.attackPower = attackPower;
            this.powerCost = powerCost;
        }
    }
}
