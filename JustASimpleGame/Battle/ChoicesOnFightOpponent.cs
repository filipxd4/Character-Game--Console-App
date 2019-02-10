using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class ChoicesOnFightOpponent
    {
        public static void FightChoices(ref ICharacters opponent, ref ICharacters character, int ifPossible)
        {
           
            if (character.HitPoints <= 0 || opponent.HitPoints <= 0)
            {
                Arena.FightLayout(character, opponent, false);
            }
            Random Rand0 = new Random();
            int choice = Rand0.Next(1, 4);
            ChoicesOnFightOpponent.FightOptionsHandler(choice, ref opponent, ref character, out ifPossible);
        }
        public static void FightOptionsHandler(int choice, ref ICharacters opponent, ref ICharacters character, out int ifPossible)
        {

            switch (choice)
            {
                case 1:
                    {
                        TimerOpponent.IfActionPossible(opponent, 0, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionAttackOpponent.AttackMechanics(ref opponent, ref character, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        }
                        break;
                    }
                case 2:
                    {
                        TimerOpponent.IfActionPossible(opponent, 2, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionAttackOpponent.SpellMechanics(ref opponent, ref character, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        }
                        break;
                    }
                case 3:
                    {
                        TimerOpponent.IfActionPossible(opponent, 4, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionItemOpponent.ItemMechanics(ref opponent, ref character, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        }
                        break;
                    }
                default:
                    {
                        ifPossible = 1;
                        ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        break;
                    }
            }
        }
    }
}
