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
            attacks = new AttackType[3] { new AttackType("Tail Whip", 15, 7), new AttackType("Base Attack", 5, 1), new AttackType("Defense", 0, -5) };
            powerRegen = 5;
        }
    }
}
