using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class FightOptionItemOpponent/*:CreatingItems*/
    {
        private static void Item(ref ICharacters opponent,ref ICharacters character)
        {
            Random rand = new Random();
            int requiredLevel = character.Level;
            int choice = rand.Next(10,30);
            int Min = requiredLevel * choice;
            opponent.HitPoints += Min;
        }
        public static void ItemMechanics(ref ICharacters opponent, ref ICharacters character, int ifPossible)
        {
            FightOptionItemOpponent.Item(ref opponent,ref character);
            TimerOpponent.SetTime(opponent, "ITEMS");
            ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
        }
    }
}
