using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Hypsilophodon : Dinosaur
    {
        public Hypsilophodon(string herdTitle)
        {
            this.herdTitle = herdTitle;
            type = "Hypsilophodon";
            health = 75;
            powerLevel = 15;
            attacks = new AttackType[3] { new AttackType("Tail Whip", 5, 6), new AttackType("Bite", 5, 1), new AttackType("Sprint", 0, -5) };
            powerRegen = 5;
        }
    }
}
