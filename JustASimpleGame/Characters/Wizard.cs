using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Wizard : CharacterData, ICharacters
    {
        public Wizard()
        {
            this.Durability = 2;
            this.Intelligence = 4;
            this.Alchemics = 3;
            this.Strength = 1;
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
            Console.WriteLine("                /\\");
            Console.WriteLine("               /  \\");
            Console.WriteLine("             ---------");
            Console.WriteLine("              | * *|     |");
            Console.WriteLine("              \\_--_/     |");
            Console.WriteLine("              __||___    |");
            Console.WriteLine("             /       \\  _|_");
            Console.WriteLine("            / /|   |\\ \\/ /");
            Console.WriteLine("           /_/ |___| \\__/");
            Console.WriteLine("               | | |    ");
            Console.WriteLine("               |_|_|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
