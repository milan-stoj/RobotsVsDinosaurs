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
        Herd dinoHerd;
        Fleet robotFleet;

        //Constructor
        public BattleField()
        {
            PrintDinoTypes();
            dinoHerd = new Herd();
            // print robo types.
            robotFleet = new Fleet();
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
                         |}      ||
                        //       ||
                      _//        {{
                   '='~'          \\_
                                   ~~'
                                        Health: 75
                                   Power Level: 15
";
            Console.WriteLine(type1);

            string type2 = @"
[2] Triceratops
                       _. - ~ ~ ~ - .
   ..       __.    .-~               ~-.
   ((\     /   `}.~                     `.
    \\\   {     }               /     \   \
(\   \\~~       }              |       }   \
 \`.-~ -@~     }  ,-,.         |       )    \
 (___     ) _}  (    :        |    / /      `.
  `----._-~.     _\ \ |_       \   / /- _      `.
         ~~----~~  \ \| ~~--~~~(  + /     ~-.     ~- _
                   /  /         \  \          ~- . _ _~_-_.
                __/  /          _\  )
              .<___.'         .<___/
                                        Health: 125
                                   Power Level: 5

";
            Console.WriteLine(type2);
            string type3 = @"
[3] Tyrannosaur
                                             ____
 ___                                      .-~    '.
`-._~-.                                  / /  ~@\   )
     \  \                               | /  \~\.  `\
     ]  |                              /  |  |< ~\(..)
    /   !                        _.--~T   \  \<   .,,
   /   /                 ____.--~ .    _  /~\ \< /
  /   /             .-~~'        /|   /o\ /-~\ \_|
 /   /             /     )      |o|  / /|o/_   '--'
/   /           .-'(     l__   _j \_/ / /\|~    .
/    l          /    \       ~~~|    `/ / / \.__/l_
|     \     _.-'      ~-\__     l      /_/~-.___.--~
|      ~---~           /   ~~'---\_    __[o,
l  .                _.    ___     _>-/~
\  \     .      .-~   .-~   ~>--'  /
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
    }
}
