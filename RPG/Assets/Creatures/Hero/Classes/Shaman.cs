using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Creatures.Hero.Classes
{
    class Shaman : Hero
    {
        public void ShamanSpAttack()
        {
            ActualHP += Intelligence;
            if (ActualHP > MaxHP)
                ActualHP = MaxHP;
        }
    }
}
