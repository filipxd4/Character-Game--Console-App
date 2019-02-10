using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Shop : CreatingItems
    {
        public Shop(ICharacters character, Random rand) : base(character, rand)
        {
            int requiredLevel = character.Level;
            this.Required = requiredLevel*rand.Next(1,4);
            this.RequiredLevel = requiredLevel;
            this.Price = this.Required * 10 * rand.Next(80, 101) / 100;
            this.Min = this.Required * rand.Next(10, 30);
            this.Max = this.Min;
        }
    }
}
