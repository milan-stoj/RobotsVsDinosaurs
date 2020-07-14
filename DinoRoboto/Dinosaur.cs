using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Dinosaur
    {
        // Init member variables
        public string type;
        public int health;
        public int powerLevel;
        public int powerRegen;
        Random random = new Random();
        public AttackType[] attacks;
        public string herdTitle;


        public void AttackRobot(Fleet roboFleet, AttackType attack)
        {
            int index = random.Next(roboFleet.robotFleet.Count());
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
