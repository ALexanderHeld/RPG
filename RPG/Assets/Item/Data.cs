using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Item
{
    class Data
    {

        // Sword Names
        public static List<string> SwordNames = new List<string>()
        {
            "Blade",
            "Giant Blade",
            "Razorsharp Blade",
            "Lasersword",
            "Woodstick"
        };
        public static int SwordNamesLength = SwordNames.Count;

        // Präfix
        public static List<string> Präfix = new List<string>()
        {
            "Holy",
            "Unholy",
            "Vampiristic",
            "Bloodseeking",
            "Thundering"
        };
        public static int PräfixLength = Präfix.Count;

        // Suffix 
        public static Dictionary<Item.Rarity, string> Suffix = new Dictionary<Item.Rarity, string>()
        {
            {Item.Rarity.Common, "testC" },
            {Item.Rarity.Rare, "testR" },
            {Item.Rarity.Epic, "testE1" },
            {Item.Rarity.Epic, "testE2" }
        };
        public static Dictionary<Item.Rarity, int> SuffixLength = new Dictionary<Item.Rarity, int>()
        {
            {Item.Rarity.Common, Suffix.Count(}
        };

    }


}
