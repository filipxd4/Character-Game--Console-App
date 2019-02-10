using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Giant : CharacterData, ICharacters
    {
        public Giant()
        {
            this.Durability = 3;
            this.Intelligence = 1;
            this.Alchemics = 1;
            this.Strength = 5;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.Money = 200;
            this.TimeForActions = new int[6];
            this.HeldArmor = 3;
            this.MinDmgWeapon = 1;
            this.MaxDmgWeapon = 4;
            this.ListOfItems = new List<int>();
            this.AmountOfAtributes = 5;
        }
        public override void Picture()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("           _______");
            Console.WriteLine("          /       \\ ");
            Console.WriteLine("          | *  *   |");
            Console.WriteLine("          |  __    |");
            Console.WriteLine("     _____\\_______/____");
            Console.WriteLine("    /                  \\");
            Console.WriteLine("   /                    \\");
            Console.WriteLine("   |      |      |      |");
            Console.WriteLine("   |_|__|_|      |_|__|_|");
            Console.WriteLine("         |________|");
            Console.WriteLine("         |___|_|__|  ");
            Console.WriteLine("         |____|___|    ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
