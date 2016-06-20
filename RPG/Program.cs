using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                RPG.Assets.Creatures.Entities Dummy = RPG.Assets.Creatures.NPC.Monster.MonsterFactory.SpawnRandom(19);
                Dummy.PrintLevel();
                Console.ReadKey();
            }

            // Fertig
            Console.ReadKey();
        }
    }
}
