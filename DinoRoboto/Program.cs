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
            Title title = new Title();
            Console.WriteLine(title.title);
            Console.ReadKey();
            
            BattleField NewBattlefield = new BattleField();

            NewBattlefield.StartBattle();
            Console.ReadLine();
        }
    }
}
