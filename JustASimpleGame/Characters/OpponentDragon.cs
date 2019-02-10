using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OpponentDragon : CharacterData, ICharacters
    {
        public OpponentDragon()
        {
            this.Durability = 4;
            this.Intelligence = 1;
            this.Alchemics = 2;
            this.Strength = 3;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.HeldArmor = 3;
            this.MinDmgWeapon = 1;
            this.MaxDmgWeapon = 4;
            this.TimeForActions = new int[6];
        }
        public OpponentDragon(int level)
        {
            this.Durability = 4 + 3 * level;
            this.Intelligence = 1 + 1 * level;
            this.Alchemics = 1+1*level;
            this.Strength = 3 + 2 * level;
            this.HitPoints = 100;
            this.HeldArmor = 3 + 1 * level;
            this.MinDmgWeapon = 1 + 2 * level;
            this.MaxDmgWeapon = 4 + 2 * level;
            this.TimeForActions = new int[6];
            this.HitPoints = 100;
        }
        public override void Picture()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                              ___________    ");
            Console.WriteLine("                             /           \\");
            Console.WriteLine("                            /   /       / \\");
            Console.WriteLine("             _____         /   /       /  /");
            Console.WriteLine("        ___/  0   |       /   /       /   /");
            Console.WriteLine("       /_____     \\      /   /       /    /");
            Console.WriteLine("       \\_________\\ \\    /   /       /     / ");
            Console.WriteLine("                  \\ \\__/   /       /      /   ______");
            Console.WriteLine("                   \\_                     \\___/  ___/");
            Console.WriteLine("                     \\     _____________     ___/");
            Console.WriteLine("                      |   |             |   |");
            Console.WriteLine("                      |___|             |___|");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}