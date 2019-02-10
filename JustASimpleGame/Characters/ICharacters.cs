using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    interface ICharacters
    {
        int Durability { get; set; }
        int Intelligence { get; set; }
        int Range { get; set; }
        int Alchemics { get; set; }
        int Strength { get; set; }
        int Luck { get; set; }
        int AmountOfAtributes { get; set; }
        int HitPoints { get; set; }
        int Money { get; set; }
        int Armor { get; set; }
        int Level { get; set; }
        int Health();
        int[] TimeForActions { get; set; }
        int RequiredMoney { get; set; }
        void Picture();
        int HeldArmor { get; set; }
        int MinDmgWeapon { get; set; }
        int MaxDmgWeapon { get; set; }
        List<int> ListOfItems { get; set; }
    }
}
