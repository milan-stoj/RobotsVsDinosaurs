using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Robot
    {
        // Init member variables - variables assigned 
        // in the child-robo constructors.

        Random random = new Random();
        public string name;             // name of robot
        public int health;              // starting health of robot
        public int powerLevel;          // stamina/energy used for attacking
        public int powerRegen;          // per-attack round power added to total power level
        public string fleetTitle;       // index name of robot in fleet list
        public Weapon[] weapons;        // weapons array usable by each robot


        // Targets a random dino from the herd, and reduces dino health
        // by weapon damage. Attacker power level reduced by weapon 
        // power cost.
        public void AttackDino(Herd dinoHerd, Weapon weapon)
        {
            if (dinoHerd.dinoHerd.Count() > 0)
            {
                int index = random.Next(dinoHerd.dinoHerd.Count());
                dinoHerd.dinoHerd[index].health -= weapon.attackPower;
                Console.WriteLine($"{fleetTitle} uses {weapon.type} against {dinoHerd.dinoHerd[index].herdTitle} for {weapon.attackPower} damage!");
                if (dinoHerd.dinoHerd[index].health <= 0)
                {
                    Console.WriteLine($"-----{dinoHerd.dinoHerd[index].herdTitle} has been eliminated!!!-----");
                    dinoHerd.dinoHerd.RemoveAt(index);
                }
                powerLevel -= weapon.powerCost;
                powerLevel += powerRegen;
            }
        }


        public Weapon SelectWeapon()
        {
            int bestAttackPower = 0;
            int bestIndex = 0;
            for (int i = 0; i < weapons.Count(); i++)
            {
                int testAttackPower = weapons[i].attackPower;
                int testAttackCost = weapons[i].powerCost;
                if (testAttackCost <= powerLevel && testAttackPower >= bestAttackPower)
                {
                    bestIndex = i;
                    bestAttackPower = testAttackPower;
                }
            }
            return weapons[bestIndex];
        }
    }
}
