using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Item
{
    public class ItemFactory : Item
    {
        public static Item CreateWeapon()
        { 
            Random rnd = new Random();

            

            return new Weapons.Weapon()
            {
                ThisItemRarity = (Rarity)1,
            };
        }
    }
}
