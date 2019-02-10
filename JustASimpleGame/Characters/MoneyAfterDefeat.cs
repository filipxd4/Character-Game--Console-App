using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Characters
{
    class MoneyAfterDefeat
    {
        public static void MoneyAfterFight(ICharacters character)
        {
            Console.Clear();
            Random Rand0 = new Random();
            int AdditionalMoney = Rand0.Next(10, 20);
            int WinMoney = character.Level * 20 + AdditionalMoney;
            int SumOfMoney = character.Money + character.Level * 20 + AdditionalMoney;
            int origWidth = 110;
            int origHeight = 20;
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            string s = "You defeat but you get: " + WinMoney + " money. Together you have: " + SumOfMoney + "money!";
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.SetCursorPosition((origWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Thread.Sleep(5000);

        }
    }
}
