using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OpponentRay : CharacterData, ICharacters
    {
        public OpponentRay()
        {
            this.Durability = 2;
            this.Intelligence = 1;
            this.Alchemics = 3;
            this.Strength = 4;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.HeldArmor = 3;
            this.MinDmgWeapon = 1;
            this.MaxDmgWeapon = 4;
            this.TimeForActions = new int[6];

        }
        public OpponentRay(int level)
        {
            this.Durability = 2 + 2 * level;
            this.Intelligence = 1 + 1 * level;
            this.Alchemics = 3 + 1 * level;
            this.Strength = 4 + 3 * level;
            this.HitPoints = 100;
            this.HeldArmor = 3 + 1 * level;
            this.MinDmgWeapon = 1 + 2 * level;
            this.MaxDmgWeapon = 4 + 2 * level;
            this.TimeForActions = new int[6];
        }
        public override void Picture()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("              ' ' ' /\\  '  ' ''  ");
            Console.WriteLine("               ' ' /  \\  ' ''");
            Console.WriteLine("             '  ' /    \\'  '");
            Console.WriteLine("             '  '/ 0  0 \\'  '");
            Console.WriteLine("              ' /   --   \\'  '");
            Console.WriteLine("             ' |          |'");
            Console.WriteLine("                \\        /");
            Console.WriteLine("                 \\_/\\/\\_/   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

        }
    }
}