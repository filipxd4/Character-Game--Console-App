using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class FightOptionItem
    {
        private static ICharacters Item(ref ICharacters character)
        {
            if (character.ListOfItems.Count != 0)
            {
                int i = 1;
                Console.WriteLine("Choose one of items below:");
                foreach (int item in character.ListOfItems)
                {
                    Console.WriteLine(i + ": " + item + " HP");
                    i++;
                }
                Console.WriteLine("");
                int Choice = OnInputWork.ChoiceHandler();
                if (Choice <= character.ListOfItems.Count)
                {
                    character.HitPoints += character.ListOfItems[Choice - 1];
                    character.ListOfItems.RemoveAt(Choice - 1);
                    
                }
                else
                {
                    Console.WriteLine("Wrong number! Try again");
                }
            }
            else
            {
                Console.WriteLine("You don't have any items!");
                Thread.Sleep(500);
                Console.Clear();
            }
            return character;
        }
        public static void ItemMechanics(ref ICharacters character, ref ICharacters opponent, int ifPossible)
        {
            FightOptionItem.Item(ref character);
            Timer.SetTime(character, "ITEMS");
            ChoicesOnFight.FightChoices(ref character, ref opponent, ifPossible);
        }
    }
}
