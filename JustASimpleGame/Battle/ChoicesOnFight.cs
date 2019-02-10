using JustASimpleGame.Battle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class ChoicesOnFight
    {
        public static void FightChoices(ref ICharacters character,ref ICharacters opponent,int ifPossible)
        {
            Console.Clear();
            character.Picture();
            Console.WriteLine("Character Hitpoints: " + character.HitPoints);
            opponent.Picture();
            Console.WriteLine("Opponent Hitpoints: " + opponent.HitPoints);
            var options = new Dictionary<string, Int32>
            {
                ["Attack"] = 1,
                ["Item"] = 3,
                ["Spells"] = 2,
                ["Tactical retreat"] = 4
            };
            for (int i = 0; i < (27 * 2 + 2); i++)
            {
                Console.Write("=");
            }
            Console.Write("\n");
            for (int i = 0; i < options.Count; i += 2)
            {
                var items = options.Skip(i).Take(2);
                Console.Write("|");
                foreach (var item in items)
                {
                    Console.Write($"|{item.Value,3}||{item.Key,-20}|");
                }
                Console.Write("|\n");
            }
            for (int i = 0; i < (27 * 2 + 2); i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\n");
            
            if (character.HitPoints <= 0 || opponent.HitPoints <= 0)
            {

                Arena.AfterFight(ref character,ref opponent);

            }
            Console.WriteLine();
            if (ifPossible == 0)
            {
                Console.WriteLine("Fast to do, to fight must rest!");
            }
            //if (character.HitPoints <= 0 || opponent.HitPoints <= 0)
            //{?????????????????????????????

            //    Arena.FightLayout(character,opponent,false);

            //}
            int Choice;
            int.TryParse(Console.ReadLine(), out Choice);
            ChoicesOnFight.FightOptionsHandler(Choice,ref character,ref opponent,out ifPossible);
        }

        public static void FightOptionsHandler(int choice,ref ICharacters character,ref ICharacters opponent,out int ifPossible)
        {
            
            switch(choice)
            {
                case 1:
                    {
                        Timer.IfActionPossible(character, 0, out ifPossible);
                        if(ifPossible== 1)
                        {
                            ifPossible = 1;
                            FightOptionAttack.AttackMechanics(ref character, ref opponent,ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFight.FightChoices(ref character, ref opponent,ifPossible);
                        }
                        break;
                    }
                case 2:
                    {
                        Timer.IfActionPossible(character, 2, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionSpell.SpellMechanics(ref character, ref opponent, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFight.FightChoices(ref character, ref opponent, ifPossible);
                        }
                        break;
                    }
                case 3:
                    {
                        Timer.IfActionPossible(character, 4, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionItem.ItemMechanics(ref character, ref opponent, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFight.FightChoices(ref character, ref opponent, ifPossible);
                        }
                        break;
                    }
                case 4:
                    {
                        ifPossible = 1;
                        character.HitPoints = 0;
                        ChoicesOnFight.FightChoices(ref character, ref opponent, ifPossible);
                        break;
                    }
                default:
                    {
                        ifPossible = 1;
                        ChoicesOnFight.FightChoices(ref character, ref opponent,ifPossible);
                        break;
                    }
            }
        }
    }
}
