using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Herd
    {
        // Init member variables
        public List<Dinosaur> dinoHerd;
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;

        public Herd()
        {
            dinoHerd = new List<Dinosaur>() { dino1, dino2, dino3 };
            for (int i = 0; i < dinoHerd.Count(); i++)
            {
                switch (SelectDinosaurType($"Dino #{i + 1}"))
                {
                    case "Hypsilophodon":
                        dinoHerd[i] = new Hypsilophodon($"Dino #{i + 1}");
                        break;

                    case "Triceratops":
                        dinoHerd[i] = new Triceratops($"Dino #{i + 1}");
                        break;

                    case "Tyrannosaur":
                        dinoHerd[i] = new Tyrannosaur($"Dino #{i + 1}");
                        break;
                }
            }
        }

        public string SelectDinosaurType(string herdTitle)
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

        public void PrintHerdInfo()
        {
            Console.WriteLine("+------------------------------+\n|        Herd Status           |\n+------------------------------+");
            foreach (Dinosaur dino in dinoHerd)
            {
                Console.WriteLine($"{dino.herdTitle} {dino.type}\nHP: {dino.health}\nPOWER LEVEL: {dino.powerLevel}\n");
            }
        }

        public string HerdWin()
        {
            return @"

                        ______ _                                        _    _ _       _ 
                        |  _  (_)                                      | |  | (_)     | |
                        | | | |_ _ __   ___  ___  __ _ _   _ _ __ ___  | |  | |_ _ __ | |
                        | | | | | '_ \ / _ \/ __|/ _` | | | | '__/ __| | |/\| | | '_ \| |
                        | |/ /| | | | | (_) \__ \ (_| | |_| | |  \__ \ \  /\  / | | | |_|
                        |___/ |_|_| |_|\___/|___/\__,_|\__,_|_|  |___/  \/  \/|_|_| |_(_)
                                                                                         
                                                                 ";
        }
        
    }
}
