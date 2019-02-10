using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OffensiveActions
    {
        public static int StrengthAction(ICharacters character)
        {
            Random rand = new Random();
            return character.Strength * rand.Next(character.MinDmgWeapon, character.MaxDmgWeapon);
        }
        public static int IntelligenceAction(ICharacters character)
        {
            Random rand = new Random();
            return character.Intelligence* rand.Next(3,7);
        }
    }
}
