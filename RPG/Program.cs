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
                // RPG.Assets.Item.Item testItem = RPG.Assets.Item.ItemFactory.CreateWeapon();
                RPG.Assets.Item.Data.PrintNames();
            }
        }
    }
}
