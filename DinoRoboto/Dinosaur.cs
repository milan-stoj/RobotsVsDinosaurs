using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Dinosaur
    {
        // Init member variables - variables assigned 
        // in the child-dino constructors.

        public string type;             // type/species of dino
        public int health;              // starting dino health
        public int powerLevel;          // starting power level of dino
        public int powerRegen;          // power regen of dino
        Random random = new Random();   // random num generator
        public AttackType[] attacks;    // array of possible dino attacks
        public string herdTitle;        // index name of dino in the herd


        // Targets a random robot from the fleet, and reduces dino health
        // by attack damage. Attacker power level reduced by attack 
        // power cost.
        public void AttackRobot(Fleet roboFleet, AttackType attack)
        {
            int index = random.Next(roboFleet.robotFleet.Count());
            if (roboFleet.robotFleet.Count() > 0)
            {
                roboFleet.robotFleet[index].health -= attack.attackPower;
                Console.WriteLine($"{herdTitle} uses {attack.type} against {roboFleet.robotFleet[index].fleetTitle} for {attack.attackPower} damage!");
                if (roboFleet.robotFleet[index].health <= 0)
                {
                    Console.WriteLine($"-----{roboFleet.robotFleet[index].fleetTitle} has been eliminated!!!-----");
                    roboFleet.robotFleet.RemoveAt(index);
                }
                powerLevel -= attack.powerCost;
                powerLevel += powerRegen;
            }
        }

        // selects an attack to perform from the attacks array
        // based on the selecting dino's power level. 
        public AttackType SelectAttack()
        {
            int bestAttackPower = 0;
            int bestIndex = 0;
            for (int i = 0; i < attacks.Count(); i++)
            {
                int testAttackPower = attacks[i].attackPower;
                int testAttackCost = attacks[i].powerCost;
                if (testAttackCost <= powerLevel && testAttackPower >= bestAttackPower)
                {
                    bestIndex = i;
                    bestAttackPower = testAttackPower;
                }
            }
            return attacks[bestIndex];
        }

    }
}
