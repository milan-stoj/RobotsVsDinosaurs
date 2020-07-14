using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Tyrannosaur : Dinosaur
    {

        public Tyrannosaur(string herdTitle)
        {
            type = "Tyrannosaur";
            this.herdTitle = herdTitle;
            health = 100;
            powerLevel = 10;
            attacks = new AttackType[3] { new AttackType("Bite", 10, 5), new AttackType("Dash", 5, 1), new AttackType("Defense", 0, -5) };
            powerRegen = 3;
        }
    }
}
