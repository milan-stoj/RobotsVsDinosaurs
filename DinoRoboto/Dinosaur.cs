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
        string[] attackType;
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
                    break;

                case "Triceratops":
                    health = 150;
                    powerLevel = 3;
                    break;

                case "Tyrannosaur":
                    health = 100;
                    powerLevel = 10;
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
    }
}
