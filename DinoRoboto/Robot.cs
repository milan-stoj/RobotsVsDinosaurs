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
        public string fleetTitle;
        Weapon weapon;

        public Robot(string fleetTitle)
        {
            this.fleetTitle = fleetTitle;
            name = SelectRobotType();
            switch (name)
            {
                case "PLS-15":
                    health = 75;
                    powerLevel = 15;
                    break;

                case "DS-125":
                    health = 150;
                    powerLevel = 3;
                    break;

                case "APH-100":
                    health = 100;
                    powerLevel = 10;
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
            powerLevel -= weapon.powerCost;
        }
    }
}
