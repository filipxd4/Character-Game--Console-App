using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OpponentDracula : CharacterData,ICharacters
    {
        public OpponentDracula()
        {
            this.Durability = 3;
            this.Intelligence = 1;
            this.Alchemics = 2;
            this.Strength = 4;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.HeldArmor = 3;
            this.MinDmgWeapon = 1;
            this.MaxDmgWeapon = 4;
            this.TimeForActions = new int[6];
        }
        public OpponentDracula(int level)
        {
            this.Durability = 3+1*level;
            this.Intelligence = 1+3*level;
            this.Alchemics = 2+1*level;
            this.Strength = 4+2*level;
            this.HitPoints = 100;
            this.HeldArmor = 3+1*level;
            this.MinDmgWeapon = 1+2*level;
            this.MaxDmgWeapon = 4+2*level;
            this.TimeForActions = new int[6];
        }
        public override void Picture()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("           ____________       ");
            Console.WriteLine("          / _________  \\");
            Console.WriteLine("          | | _   _  | | ");
            Console.WriteLine("          | | 0   0  | | ");
            Console.WriteLine("   ___    | | ______ | |    ___");
            Console.WriteLine("  |_|_|   | ||\\/\\/\\/|| |   |_|_|");
            Console.WriteLine("   | |    |/||_/\\/\\_||\\|    | | ");
            Console.WriteLine("   \\ \\____| |________| |____/ /");
            Console.WriteLine("    \\_______           ______/");
            Console.WriteLine("            |         | ");
            Console.WriteLine("            |_________| ");
            Console.WriteLine("            |_________| ");
            Console.WriteLine("            |    |    | ");
            Console.WriteLine("           _|____|____|_ ");
            Console.WriteLine("          |_____________| ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
