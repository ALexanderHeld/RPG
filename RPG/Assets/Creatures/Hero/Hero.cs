using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Creatures.Hero
{
    public class Hero : Entities
    {
        // Singleton
        private Hero() { }
        public static readonly Hero Player = new Hero();
        

        public Ressource ThisEntityRessource { get; set; }
        public enum Ressource { Mana, Rage, Sanity }

        private Dictionary<int, Item.Item> Inventory = new Dictionary<int, Item.Item>(5);

        public void PickUpItem(Item.Item item)
        {
            if (Inventory.Count < 5)
            {
                int temp = Inventory.Count;
                Inventory[temp] = item;
                Console.ForegroundColor = RPG.Assets.Item.Item.GetConsoleColorBasedOnRarity(item);
                Console.WriteLine($"{item.Name} has been added to your Inventory on Slot {temp + 1}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"INVENTORY FULL!");
                RPG.Assets.Item.Item.PrintItemName(item);
            }
        }

        public override void doAttack(Entities target)
        {
            throw new NotImplementedException();
        }
    }
}
