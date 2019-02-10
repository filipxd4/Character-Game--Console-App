using JustASimpleGame.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    static class GameInvocation
    {
        public static void OptionsSelector()
        {
            Console.WriteLine("1.Start Game");
            Console.WriteLine("2.Options");
            Console.WriteLine("3.Exit");
            GameInvocation.OpeningActionHandler();
            
        }
        public static void OpeningActionHandler()
        {
            int Choice=OnInputWork.ChoiceHandler();
            switch(Choice)
            {
                case 1:
                    {
                        Console.Clear();
                        ICharacters character = new CharacterData();
                        StartGame.CreatingCharacter(ref character);
                        break;
                    }
                case 2:
                    {
                        Options.Changes();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Ending.TheEnd();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Select action from listed above!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        GameInvocation.OptionsSelector();
                        break;
                    }

            }

        }
    }
}
