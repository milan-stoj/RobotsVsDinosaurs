using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Fleet
    {
        // Init member variables
        List<Robot> robotFleet;

        public Fleet()
        {
            Robot robo1 = new Robot("Robot #1");
            Robot robo2 = new Robot("Robot #2");
            Robot robo3 = new Robot("Robot #3");
            robotFleet = new List<Robot> { robo1, robo2, robo3 };
        }

        public void PrintFleetInfo()
        {
            Console.Clear();
            Console.WriteLine($"Robot Fleet Info");
            foreach (Robot robo in robotFleet)
            {
                Console.WriteLine($"{robo.fleetTitle}\n{robo.name}\n");
            }
        }
    }
}
