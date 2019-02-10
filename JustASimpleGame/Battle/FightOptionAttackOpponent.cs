using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class FightOptionAttackOpponent
    {
     
            public static ICharacters Attack(ref ICharacters character, ref ICharacters opponent)
            {
                int AttackDealt;
                int HitPointsDefender;
                Random rand = new Random();
                AttackDealt = OffensiveActionsOpponent.StrengthAction(opponent);
                HitPointsDefender =character.HitPoints;
                if (DefenseActionsOpponent.ArmorAction(character) > AttackDealt)
                {
                   character.HitPoints = HitPointsDefender - 5;
                }
                else
                {
                    character.HitPoints = HitPointsDefender - ((AttackDealt) - DefenseActionsOpponent.ArmorAction(character)) * DefenseActionsOpponent.LuckAction(character);
                }
                return character;
            }
            public static void AttackMechanics(ref ICharacters opponent, ref ICharacters character, int ifPossible)
            {
                FightOptionAttackOpponent.Attack(ref character, ref opponent);
                TimerOpponent.SetTime(opponent, "ATTACK");
                ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
            }
            public static void SpellMechanics(ref ICharacters opponent, ref ICharacters character, int ifPossible)
              {
                 FightOptionAttackOpponent.Spell(ref character, ref opponent);
                 TimerOpponent.SetTime(opponent, "SPELL");
                 ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                 
              }
            public static ICharacters Spell(ref ICharacters character, ref ICharacters opponent)
            {
                int AttackDealt;
                int HitPointsDefender;
                Random rand = new Random();
                AttackDealt = OffensiveActionsOpponent.IntelligenceAction(opponent);
                HitPointsDefender = character.HitPoints;
                if (DefenseActionsOpponent.ArmorAction(character) > AttackDealt)
                {
                    character.HitPoints = HitPointsDefender - 10;
                }
                else
                {
                    character.HitPoints = HitPointsDefender - ((AttackDealt)* DefenseActionsOpponent.LuckAction(character));
                }
                return character;
            }


        }
}
