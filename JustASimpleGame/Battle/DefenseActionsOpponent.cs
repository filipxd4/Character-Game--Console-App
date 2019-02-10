using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class DefenseActionsOpponent
    {
            public static int ArmorAction(ICharacters character)
            {
                return character.HeldArmor;
            }
            public static int LuckAction(ICharacters character)
            {
                Random rand = new Random();
                if (rand.Next(0, (int)Math.Pow(10, 9)) > ((100 - character.Luck) * (int)Math.Pow(10, 7)))
                {
                    return 0;
                }
                else
                    return 1;
            }
    }
}
