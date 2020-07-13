﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class BattleField
    {
        Herd dinoHerd;
        Fleet robotFleet;

        //Constructor
        public BattleField()
        {
            PrintDinoTypes();
            dinoHerd = new Herd();
            dinoHerd.PrintHerdInfo();
            PrintRoboTypes();
            robotFleet = new Fleet();
            robotFleet.PrintFleetInfo();
        }

        public void StartBattle()
        {
            string winner;
            bool victor = false;
            while(victor == false)
            {
                Console.Clear();
                dinoHerd.PrintHerdInfo();
                robotFleet.PrintFleetInfo();
                Console.WriteLine("Press enter to evaulate round");
                Console.ReadLine();
                AttackRound(dinoHerd, robotFleet);
                Console.ReadLine();
                if(dinoHerd.dinoHerd.Count() == 0)
                {
                    winner = "ROBOTS WIN!!!";
                    Console.WriteLine(winner);
                    Console.ReadLine();
                    victor = true;
                }
                else if(robotFleet.robotFleet.Count() == 0)
                {
                    winner = "DINOS WIN!!!";
                    Console.WriteLine(winner);
                    Console.ReadLine();
                    victor = true;
                }
            }
        }

        private void PrintDinoTypes()
        {
            Console.Clear();
            string type1 = @"
[1] Hypsilophodon
                             ___......__             _
                        _.-'           ~-_       _.=a~~-_
--=====-.-.-_----------~   .--.       _   -.__.-~ ( ___==>
              '''--...__  (    \ \\\ { )       _.-~
                        =_ ~_  \\-~~~//~~~~-=-~
                         |-=-~_ \\   \\
                         |_/   =. )   ~}
                        _//        {{
                     '='~'          \\_
                                        Health: 75
                                   Power Level: 15";
            Console.WriteLine(type1);

            string type2 = @"
[2] Triceratops
                       _. - ~ ~ ~ - .
   ..       __.    .-~               ~-.
   ((\     /   `}.~                     `.
(\   \\~~       }              |       }   \
 \`.-~ -@~     }  ,-,.         |       )    \
 (___     ) _}  (    :        |    / /      `.
  `----._-~.     _\ \ |_       \   / /- _      `.
         ~~----~~  \ \| ~~--~~~(  + /     ~-.     ~- _
              .<___.'         .<___/
                                        Health: 125
                                   Power Level: 5";
            Console.WriteLine(type2);
            string type3 = @"
[3] Tyrannosaur
                                             ____
 ___                                      .-~    '.
`-._~-.                                  / /  ~@\   )
     \  \                               | /  \~\.  `\
    /   !                        _.--~T   \  \<   .,,
   /   /                 ____.--~ .    _  /~\ \< /
  /   /             .-~~'        /|   /o\ /-~\ \_|
 /   /             /     )      |o|  / /|o/_   '--'
/   /           .-'(     l__   _j \_/ / /\|~    .
/    l          /    \       ~~~|    `/ / / \.__/l_
|     \     _.-'      ~-\__     l      /_/~-.___.--~
|      ~---~           /   ~~'---\_    __[o,
 \  ~---'            /         _.-'
  '-.,_____.,_  _.--~\     _.-~
              ~~     (   _}
                     `. ~(
                       )  \
                 /,`--'~\--'~\
                                        Health: 100
                                   Power Level: 10
";
            Console.WriteLine(type3);
        }

        private void PrintRoboTypes()
        {
            Console.Clear();
            string type1 = @"
[1] PLS-15
                      \_/
                     (* *)
                    __)#(__
                   ( )...( )(_)
                   || |_| ||//
                >==() | | ()/
                    _(___)_
                   [-]   [-]
                                        Health: 75
                                   Power Level: 15";
            Console.WriteLine(type1);

            string type2 = @"
[2] DS-125
                   __,_,
                  [_|_/ 
                   //
                 _//    __
                (_|)   |@@|
                 \ \__ \--/ __
                  \o__|----|  |   __
                      \ }{ /\ )_ / _\
                      /\__/\ \__O (__
                     (--/\--)    \__/
                     _)(  )(_
                    `---''---`
                                        Health: 125
                                   Power Level: 5";
            Console.WriteLine(type2);
            string type3 = @"
[3] APH-100
                        \_\
                       (_**)
                      __) #_
                     ( )...()
                     || | |I|
                     || | |()__/
                     /\(___)
                    _-''''''''' -''- _
                      -,,,,,,,,- ,,-

                                          Health: 100
                                   Power Level: 10
";
            Console.WriteLine(type3);
        }

        public void AttackRound(Herd dinoHerd, Fleet robotFleet)
        {
            foreach (Dinosaur dino in dinoHerd.dinoHerd)
            {
                
                dino.AttackRobot(robotFleet, dino.SelectAttack());
            }

            foreach (Robot robo in robotFleet.robotFleet)
            {
                robo.AttackDino(dinoHerd, robo.SelectWeapon());
            }
        }
    }
}
