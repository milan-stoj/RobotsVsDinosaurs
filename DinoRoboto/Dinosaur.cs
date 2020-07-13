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
        AttackType[] attacks;
        public string herdTitle;

        public Dinosaur(string herdTitle)
        {
            this.herdTitle = herdTitle;
            type = SelectDinosaurType();
            switch (type)
            {
                case "Hypsilophodon":
                    health = 75;
                    powerLevel = 15;
                    attacks = new AttackType[3] { new AttackType("Tail Whip", 15, 7), new AttackType("Base Attack", 5, 2), new AttackType("Defense", 0, 0)};
                    break;

                case "Triceratops":
                    health = 150;
                    powerLevel = 3;
                    attacks = new AttackType[3] { new AttackType("Horns", 5, 3), new AttackType("Base Attack", 5, 1), new AttackType("Defense", 0, 0) };
                    break;

                case "Tyrannosaur":
                    health = 100;
                    powerLevel = 10;
                    attacks = new AttackType[3] { new AttackType("Bite", 10, 5), new AttackType("Slash", 5, 2), new AttackType("Defense", 0, 0) };
                    break;
            }
        }

        public string SelectDinosaurType()
        {
            Console.Write($"Please select the species of dinosaur for {herdTitle}: ");
            string input = Console.ReadLine();
            while (true)
            {
                switch (input)
                {
                    case "1":
                        return "Hypsilophodon";
                    case "2":
                        return "Triceratops";
                    case "3":
                        return "Tyrannosaur";
                    default:
                        Console.Write("\nNot a valid selection! Input again: ");
                        input = Console.ReadLine();
                        break;
                }
            }
        }
        public void AttackRobot(Fleet roboFleet, AttackType attack)
        {
            Random random = new Random();
            int index = random.Next(roboFleet.robotFleet.Count());
            roboFleet.robotFleet[index].health -= attack.attackPower;
            powerLevel -= attack.powerCost;
        }

        public AttackType SelectAttack(List<AttackType> attacks)
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
