using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class FightOptionSpell
    {
        public static void SpellMechanics(ref ICharacters character, ref ICharacters opponent, int ifPossible)
        {
            FightOptionSpell.Spell(ref character, ref opponent);
            Timer.SetTime(character, "SPELL");
            ChoicesOnFight.FightChoices(ref character, ref opponent, ifPossible);
        }
        public static ICharacters Spell(ref ICharacters character, ref ICharacters opponent)
        {
            int AttackDealt;
            int HitPointsDefender;
            Random rand = new Random();
            AttackDealt = OffensiveActions.IntelligenceAction(character);
            HitPointsDefender = opponent.HitPoints;
            int damage = AttackDealt * DefenseActions.LuckAction(opponent);
            opponent.HitPoints = HitPointsDefender - damage;
            Console.WriteLine("You take him:"+damage);
            return opponent;
        }
    }
}
