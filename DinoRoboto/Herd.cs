using System;
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

        public Herd()
        {
            Dinosaur dino1 = new Dinosaur("Dino #1");
            Dinosaur dino2 = new Dinosaur("Dino #2");
            Dinosaur dino3 = new Dinosaur("Dino #3");
            dinoHerd = new List<Dinosaur> { dino1, dino2, dino3 };
        }

        public void PrintHerdInfo()
        {
            Console.WriteLine($"\n\nDinosaur Herd Info");
            foreach (Dinosaur dino in dinoHerd)
            {
                Console.WriteLine($"{dino.herdTitle}\nSpecies: {dino.type}\nHealth: {dino.health}\nPower Level: {dino.powerLevel}\n");
            }
        }

        
    }
}
