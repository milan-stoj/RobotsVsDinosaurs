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
        public List<Robot> robotFleet;
        Robot robo1;
        Robot robo2;
        Robot robo3;

        public Fleet()
        {
            robotFleet = new List<Robot>() { robo1, robo2, robo3 };
            for (int i = 0; i < robotFleet.Count(); i++)
            {
                switch (SelectRobotType($"Robot #{i + 1}"))
                {
                    case "R2-D2":
                        robotFleet[i] = new R2_D2($"Robot #{i + 1}");
                        break;

                    case "HAL-9000":
                        robotFleet[i] = new Protectron($"Robot #{i + 1}");
                        break;

                    case "T-800":
                        robotFleet[i] = new T_800($"Robot #{i + 1}");
                        break;
                }
            }
        }

        public void PrintFleetInfo()
        {
            Console.WriteLine("+------------------------------+\n|        Fleet Status          |\n+------------------------------+");
            foreach (Robot robo in robotFleet)
            {
                Console.WriteLine($"{robo.fleetTitle} {robo.name}\nHP: {robo.health}\nPOWER LEVEL:{robo.powerLevel}\n");
            }
        }

        public string SelectRobotType(string fleetTitle)
        {
            Console.Write($"Please select the type of robot for {fleetTitle}: ");
            string input = Console.ReadLine();
            while (true)
            {
                switch (input)
                {
                    case "1":
                        return "R2-D2";
                    case "2":
                        return "HAL-9000";
                    case "3":
                        return "T-800";
                    default:
                        Console.Write("\nNot a valid selection! Input again: ");
                        input = Console.ReadLine();
                        break;
                }
            }
        }

        public string FleetWin()
        {
            return @"
                            ______      _           _         _    _ _       _ 
                            | ___ \    | |         | |       | |  | (_)     | |
                            | |_/ /___ | |__   ___ | |_ ___  | |  | |_ _ __ | |
                            |    // _ \| '_ \ / _ \| __/ __| | |/\| | | '_ \| |
                            | |\ \ (_) | |_) | (_) | |_\__ \ \  /\  / | | | |_|
                            \_| \_\___/|_.__/ \___/ \__|___/  \/  \/|_|_| |_(_)
                                                                               
";
        }
    }
}
