using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JustASimpleGame
{
    class FightOptionAttack
    {
        private static ICharacters Attack(ref ICharacters attacker,ref ICharacters defender)
        {
            int AttackDealt;
            int HitPointsDefender;
            Random rand = new Random();
            AttackDealt = OffensiveActions.StrengthAction(attacker);
            HitPointsDefender = defender.HitPoints;
            int damage = (AttackDealt) - defender.HeldArmor * DefenseActions.LuckAction(defender);
            if (defender.HeldArmor> AttackDealt)
            {
                defender.HitPoints = HitPointsDefender - 5;
                Console.WriteLine("You take him: 5 damage!");
            }
            else
            {
                defender.HitPoints = HitPointsDefender - damage;
                Console.WriteLine("You take him:" + damage+"damage");
            }
            return defender;
        }
        public static void AttackMechanics(ref ICharacters character, ref ICharacters opponent,int ifPossible)
        {
            FightOptionAttack.Attack(ref character, ref opponent);
            Timer.SetTime(character, "ATTACK");
            ChoicesOnFight.FightChoices(ref character, ref opponent,ifPossible);
        }
    }
}

