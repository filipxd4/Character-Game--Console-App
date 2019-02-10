using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class CharacterData : ICharacters
    {
        public int Durability { get; set; }
        public int Intelligence { get; set; }
        public int Range { get; set; }
        public int Alchemics { get; set; }
        public int Strength { get; set; }
        public int AmountOfAtributes { get; set; }
        public int Luck { get; set; }
        public int RequiredMoney { get; set; }
        private int _HitPoints;
        public int HitPoints
        {
            get
            {
                return _HitPoints;
            }
            set
            {
                _HitPoints = value;
            }
        }
        public int Money { get; set; }
        public int Level { get; set; }
        public int Armor { get; set; }
        public int[] TimeForActions { get; set; }
        public int Health()
        {
            int Health;
            Health = this.HitPoints;
            Health += this.Durability * 6 + this.Alchemics * 3 + this.Strength * 1;
            return Health;
        }
        public int HeldArmor { get; set; }
        public int MinDmgWeapon { get; set; }
        public int MaxDmgWeapon { get; set; }
        public List<int> ListOfItems { get; set; }
        public virtual void Picture()
        {
            
        }
    }
}
