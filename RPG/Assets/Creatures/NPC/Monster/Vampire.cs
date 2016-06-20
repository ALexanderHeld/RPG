using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Creatures.NPC.Monster
{
    class Vampire : Entities
    {
        public override void doAttack(Entities target)
        {
            if (target.ActualHP <= Attack)
                target.ActualHP = 0;
            else
            {
                target.ActualHP -= Attack;
                ActualHP += Attack / 2;
                if (ActualHP > MaxHP)
                    ActualHP = MaxHP;
            }
        }
    }
}
