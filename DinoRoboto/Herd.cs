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
        Dinosaur[] dinoFleet;

        public Herd()
        {
            Dinosaur dino1 = new Dinosaur("Dino #1");
            Dinosaur dino2 = new Dinosaur("Dino #2");
            Dinosaur dino3 = new Dinosaur("Dino #3");
            dinoFleet = new Dinosaur[3] { dino1, dino2, dino3 };
            PrintHerdInfo();
        }

        public void PrintHerdInfo()
        {
            Console.Clear();
            Console.WriteLine($"Dinosaur Herd Info\n");
            foreach (Dinosaur dino in dinoFleet)
            {
                Console.WriteLine($"\n{dino.HerdTitle()}\n{dino.DinoType()}\n\n");
            }
        }
    }
}
