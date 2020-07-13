using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoRoboto
{
    class Program
    {
        static void Main(string[] args)
        {
            Herd dinoHerd = new Herd();
            Fleet robotFleet = new Fleet();
            BattleField NewBattlefield = new BattleField(dinoHerd, robotFleet);

            // StartBattle(NewBattleField);
        }
    }
}
