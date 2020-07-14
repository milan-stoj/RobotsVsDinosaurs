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
            Console.WindowHeight = 65;
            Title title = new Title();
            Console.WriteLine(title.MainTitle());
            Console.ReadKey();
            
            BattleField NewBattlefield = new BattleField();

            NewBattlefield.StartBattle();
            Console.ReadLine();
        }
    }
}
