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
            attacks = new AttackType[3] { new AttackType("Bite", 5, 1), new AttackType("Head Slam", 15, 20), new AttackType("Roar", 0, -5) };
            powerRegen = 3;
        }
    }
}
