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
            Console.WindowHeight = 65;                          // Setting window height to fit content
            Title title = new Title();                          // Instantiating title/headers class
            Console.WriteLine(title.MainTitle());               // Printing main title to console
            Console.ReadKey();                              
            
            BattleField NewBattlefield = new BattleField();     // Instantiating new BattleField class
            NewBattlefield.StartBattle();
            Console.ReadLine();
        }
    }
}
