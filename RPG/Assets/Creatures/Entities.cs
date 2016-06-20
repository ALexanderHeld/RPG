using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Creatures
{
    public abstract class Entities
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxHP { get; set; }
        public int ActualHP { get; set; }
        public int Attack { get; set; }
        public int Intelligence { get; set; }

        public abstract void doAttack(Entities target);

        public void PrintLevel()
        {
            Console.WriteLine(Level);
        }
    }
}
