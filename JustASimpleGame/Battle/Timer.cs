using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Timer
    {
        public static void SetTime(ICharacters character,string choice)
        {
            choice = choice.ToUpper();
            DateTime date = DateTime.Now;
            switch (choice)
            {
                case "ATTACK":
                    {
                        character.TimeForActions[0] = date.Minute;
                        character.TimeForActions[1] = date.Second+2;
                        break;
                    }
                case "SPELL":
                    {
                        character.TimeForActions[2] = date.Minute;
                        character.TimeForActions[3] = date.Second+4;
                        break;
                    }
                case "ITEMS":
                    {
                        character.TimeForActions[4] = date.Minute;
                        character.TimeForActions[5] = date.Second+10;
                        break;
                    }
            }
        }
        public static void IfActionPossible(ICharacters characters,int whatAction,out int ifPossible)
        {
            DateTime dateNow = DateTime.Now;
            if (characters.TimeForActions[0+whatAction] == dateNow.Minute)
            {
                if (characters.TimeForActions[1 + whatAction] < dateNow.Second)
                {
                    ifPossible = 1;
                }
                else
                {
                    ifPossible = 0;
                }
            }
            else
            {
                if (characters.TimeForActions[0 + whatAction] < 60)
                {
                    ifPossible = 1;
                }
                else if (characters.TimeForActions[0 + whatAction] % 60 < dateNow.Second % 60)
                {
                    ifPossible = 1;
                }
                else
                {
                    ifPossible = 0;
                }
            }
        }
    }
}
