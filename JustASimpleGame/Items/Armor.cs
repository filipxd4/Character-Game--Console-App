using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Armor : CreatingItems
    {
        public Armor(ICharacters character, Random rand) : base(character,rand)
        {
            int requiredLevel = character.Level;
            this.Required = requiredLevel * rand.Next(1, 4);
            this.RequiredLevel = requiredLevel;
            this.Price = this.Required * 100 * rand.Next(80, 101) / 100;//Przykładowo randomowo to przecena 
            this.Min = this.Required * rand.Next(1, 5);
            this.Max = this.Min;
        }
    }
}
