using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Robot
    {
        // Init member variables
        Random random = new Random();
        public string name;
        public int health;
        public int powerLevel;
        public int powerRegen;
        public string fleetTitle;
        Weapon[] weapons;

        public Robot(string fleetTitle)
        {
            weapons = new Weapon[3] { new Weapon("Laser Pistol", 10, 5), new Weapon("Laser Cannon", 15, 5), new Weapon("Defense", 0, 0) };
            this.fleetTitle = fleetTitle;
            name = SelectRobotType();
            switch (name)
            {
                case "PLS-15":
                    health = 75;
                    powerLevel = 15;
                    powerRegen = 5;
                    break;

                case "DS-125":
                    health = 150;
                    powerLevel = 3;
                    powerRegen = 1;
                    break;

                case "APH-100":
                    health = 100;
                    powerLevel = 10;
                    powerRegen = 2;
                    break;
            }
        }

        
        // Returns a robot name value, that is then switch-cased
        // in the constructor to assign respective health/power-levels.
        public string SelectRobotType()
        {
            Console.Write($"Please select the type of robot for {fleetTitle}: ");
            string input = Console.ReadLine();
            while (true)
            {
                switch (input)
                {
                    case "1":
                        return "PLS-15";
                    case "2":
                        return "DS-125";
                    case "3":
                        return "APH-100";
                    default:
                        Console.Write("\nNot a valid selection! Input again: ");
                        input = Console.ReadLine();
                        break;
                }
            }
        }

        // Targets a random dino from the herd, and reduces dino health
        // by weapon damage. Attacker power level reduced by weapon 
        // power cost.
        public void AttackDino(Herd dinoHerd, Weapon weapon)
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
