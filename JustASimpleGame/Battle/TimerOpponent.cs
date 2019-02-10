using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class TimerOpponent
    {
        public static void SetTime(ICharacters opponent, string choice)
        {
            choice = choice.ToUpper();
            DateTime date = DateTime.Now;
            switch (choice)
            {
                case "ATTACK":
                    {
                        opponent.TimeForActions[0] = date.Minute;
                        opponent.TimeForActions[1] = date.Second + 2;
                        break;
                    }
                case "SPELL":
                    {
                        opponent.TimeForActions[2] = date.Minute;
                        opponent.TimeForActions[3] = date.Second + 4;
                        break;
                    }
                case "ITEMS":
                    {
                        opponent.TimeForActions[4] = date.Minute;
                        opponent.TimeForActions[5] = date.Second + 20;
                        break;
                    }
            }
        }
        
        public static void IfActionPossible(ICharacters opponent, int whatAction, out int ifPossible)
        {
            DateTime dateNow = DateTime.Now;
            if (opponent.TimeForActions[0 + whatAction] == dateNow.Minute)
            {
                if (opponent.TimeForActions[1 + whatAction] < dateNow.Second)
                {
                    ifPossible = 1;
                    Thread.Sleep(1000);
                }
                else
                {
                    ifPossible = 0;
                    Thread.Sleep(1000);
                }
            }
            else
            {
                if (opponent.TimeForActions[0 + whatAction] < 60)
                {
                    ifPossible = 1;
                    Thread.Sleep(1000);
                }
                else if (opponent.TimeForActions[0 + whatAction] % 60 < dateNow.Second % 60)
                {
                    ifPossible = 1;
                    Thread.Sleep(1000);
                }
                else
                {
                    ifPossible = 0;
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
