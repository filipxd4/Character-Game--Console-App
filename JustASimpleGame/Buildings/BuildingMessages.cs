using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class BuildingMessages
    {
        public static void BuldingMessage(string buldingName)
        {
            Console.WriteLine($"Welcome in the {buldingName}!");
            if (buldingName=="Shop")
            {
                Console.WriteLine("You can buy hear some HP potions!");
            }
            else if(buldingName == "ArmorSmith")
            {
                Console.WriteLine("You can buy hear some armor for you protection!");
            }
            else if (buldingName == "WeaponSmith")
            {
                Console.WriteLine("You can buy hear some weapon for you damage!");
            }
            else if (buldingName == "Arena")
            {
                Console.WriteLine("The moment you passed the door you entered to the dark place.\nMetallic stench of blood which flow beneath your feet reminds you why're you came here.\nWould you like to fight? ");
                Console.WriteLine("1.Yes, there's no comming back!");
                Console.WriteLine("2.Yes, I want to fight with BOSS!");
                Console.WriteLine("3.There must be other options to live!");
            }
            else
            {
                Console.WriteLine("No such command");
            }
            Console.WriteLine();
        }
    }
}
