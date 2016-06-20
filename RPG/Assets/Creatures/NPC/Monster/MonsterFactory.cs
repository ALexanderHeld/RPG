using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets.Creatures.NPC.Monster
{
    sealed class MonsterFactory
    {
        // ############################
        // ADD NEW MONSTERTYPES HERE!!!
        // ############################

        private static string[] MonsterTypes = { "Skelleton", "Vampire" };

        public static Entities SpawnSkelleton( int level)
        {
            return new Skelleton() { Level = level, Name = "Skelleton" };
        }

        public static Entities SpawnVampire( int level)
        {
            return new Vampire() { Level = level, Name = "Vampire" };
        }

        public static Entities SpawnRandom( int level)
        {
            Random rnd = new Random();
            string target = MonsterTypes[ rnd.Next(0, MonsterTypes.Count()) ];
            int targetLevel = rnd.Next(level, level + 3);

            if ( target == "Skelleton" )
                return SpawnSkelleton( targetLevel );
            if ( target == "Vampire" )
                return SpawnVampire( targetLevel ) ;
            return SpawnSkelleton( targetLevel );
        }
    }
}