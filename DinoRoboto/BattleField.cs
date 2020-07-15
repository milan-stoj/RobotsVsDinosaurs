using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class BattleField
    {
        // Member variables of battlefield. Battlefield contains a 
        // herd and a fleet to perform battle.
        Herd dinoHerd;
        Fleet robotFleet;
        Title title;

        //Constructor
        public BattleField()
        {
            title = new Title();       
            PrintDinoTypes();           // Print dino types to selection screen
            dinoHerd = new Herd();      // Instantiate new Herd
            PrintRoboTypes();           // Print robo types to selection screen
            robotFleet = new Fleet();   // Instantiate new Fleet
        }

        public void StartBattle()
        {
            Console.Clear();
            int roundCounter = 0;       // Counter for number of rounds elapsed
            string winner;              // String to store winnner declaration
            Console.WriteLine(title.BattleTitle()); // Print battle header to screen
            Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(title.BattleTitle()); // Print battle header to screen
                roundCounter++;
                // Print herd and fleet status
                dinoHerd.PrintHerdInfo();       
                robotFleet.PrintFleetInfo();
                Console.WriteLine($"+------------------------------+\n|        Round {roundCounter} Results       |\n+------------------------------+");
                DinoAttackRound(dinoHerd);
                if (robotFleet.robotFleet.Count() == 0)      // If fleet count reaches 0 - dinos win.
                {
                    winner = $"\n\n All robots eliminated in {roundCounter} Rounds! DINOS WIN!!!";
                    Console.WriteLine(winner);
                    Console.WriteLine(dinoHerd.HerdWin());
                    Console.ReadLine();
                    break;
                }

                RoboAttackRound(robotFleet);
                if(dinoHerd.dinoHerd.Count() == 0)          // If herd count reaches 0 - robos win.
                {
                    winner = $"\n\n -------- All dinosaurs eliminated in {roundCounter} Rounds! ROBOTS WIN!!! -------- ";
                    Console.WriteLine(winner);
                    Console.WriteLine(robotFleet.FleetWin());
                    Console.ReadLine();
                    break;

                }
                Console.ReadLine();
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
________________________________________________________
";
            Console.WriteLine(type3);
        }

        private void PrintRoboTypes()
        {
            Console.Clear();
            string type1 = @"
[1] R2-D2
                      .=.
                     '==c|
                     [)-+|
                     //'_|
                    /]==;\             
                                        Health: 75
                                   Power Level: 15";
            Console.WriteLine(type1);

            string type2 = @"
[2] Protectron
                    _-=-_
                   /     \
                  /   (=) \
                 /_  o |  _\
                /  \=|=|=/  \
               /   |=|=*=|   \
              /\   |=+=|=|   /\
              |\    \|_|/    /|
             /\               /\
          __/  \             /  \__
        _   _   \    ===    /   _   _
       /     \   \__/   \__/   /     \
      /__    |                 |    __\
      |  \__/   - - - - - - -   \__/  |
       \____/\       ====       /\____/
       <____> \     /____\     / <____>
       <____>  \   /______\   /  <____>
      <____>    \_/<______>\_/    <____>
      <____>       <______>       <____>
      /    \    _-_<______>_-_    /    \
     /     |   /   /      \   \   |     \
     |o    |   ====\      /====   |    o|
     |     |   \   /\____/\   /   |     |
     \==== /   |___|      |___|   \ ====/
      \___/    <___>      <___>    \___/
      ( ( )    <___>      <___>     ( |)
               <___>      <___>
            
                                        Health: 125
                                   Power Level: 5";
            Console.WriteLine(type2);
            string type3 = @"
[3] T-800
                   <((((((\\\
                   /      . }\
                   ;--..--._|}
(\                 '--/\--'  )
 \\                | '-'  :'|
  \\               . -==- .-|
   \\               \.__.'   \--._
   [\\          __.--|       //  _/'--.
   \ \\       .'-._ ('-----'/ __/      \
    \ \\     /   __>|      | '--.       |
     \ \\   |   \   |     /    /       /
      \ '\ /     \  |     |  _/       /
                                          Health: 100
                                   Power Level: 10
________________________________________________________
";
            Console.WriteLine(type3);
        }

        public void DinoAttackRound(Herd dinoHerd)
        {
            foreach (Dinosaur dino in dinoHerd.dinoHerd)
            {
                dino.AttackRobot(robotFleet, dino.SelectAttack());
            }
        }


        public void RoboAttackRound(Fleet robotFleet)
        {
            foreach (Robot robo in robotFleet.robotFleet)
            {
                robo.AttackDino(dinoHerd, robo.SelectWeapon());
            }
        }
    }
}
