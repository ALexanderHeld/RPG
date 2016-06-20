using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Creatures.NPC.Monster
{
    class Skelleton : Entities
    {
        public override void doAttack(Entities target)
        {
            if (ActualHP <= Attack)
                ActualHP = 0;
            else
                ActualHP -= Attack;
        }
    }
}
