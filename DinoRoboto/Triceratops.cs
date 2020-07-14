using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Triceratops : Dinosaur
    {

        public Triceratops(string herdTitle)
        {
            this.herdTitle = herdTitle;
            type = "Triceratops";
            health = 150;
            powerLevel = 3;
            attacks = new AttackType[3] { new AttackType("Horns", 5, 3), new AttackType("Base Attack", 5, 1), new AttackType("Defense", 0, -5) };
            powerRegen = 3;
        }
    }
}
