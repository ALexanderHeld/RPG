using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Item
{
    public abstract class Item
    {
        public string Name { get; set; }
        public Rarity ThisItemRarity { get; set; }
        public static Dictionary<Rarity, ConsoleColor> RarityConsoleColor = new Dictionary<Rarity, ConsoleColor>()
        {
            { Rarity.Common, ConsoleColor.Green },
            { Rarity.Rare, ConsoleColor.Blue },
            { Rarity.Epic, ConsoleColor.Magenta },
            { Rarity.Legendary, ConsoleColor.Yellow }
        };

        public enum Rarity { Common, Rare, Epic, Legendary}

        public void Equip()
        {
            SetConsoleColorBasedOnRarity();
            Console.WriteLine($"{Name} has been equipped!");
            Console.ResetColor();
        }

        public void SetConsoleColorBasedOnRarity()
        {
            Console.ForegroundColor = RarityConsoleColor[this.ThisItemRarity];
        }

        public static ConsoleColor GetConsoleColorBasedOnRarity(Item item)
        {
            return RPG.Assets.Item.Item.RarityConsoleColor[item.ThisItemRarity];
        }

        public static void PrintItemName(Item item)
        {
            item.SetConsoleColorBasedOnRarity();
            Console.WriteLine($"{item.Name}");
            Console.ResetColor();
        }
    }
}
