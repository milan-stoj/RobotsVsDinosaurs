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
        Robot[] robotFleet;

        public Fleet()
        {
            Robot robo1 = new Robot("Robot #1");
            Robot robo2 = new Robot("Robot #2");
            Robot robo3 = new Robot("Robot #3");
        }
    }
}
