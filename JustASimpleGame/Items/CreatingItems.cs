using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    abstract class CreatingItems
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Price { get; set; }
        public int Required { get; set; }
        public int RequiredLevel { get; set; }

        public CreatingItems(ICharacters character,Random rand)
        {
            int requiredLevel = character.Level;
            this.Required = requiredLevel * rand.Next(1, 4);
            this.RequiredLevel = requiredLevel;
            this.Price = this.Required * 100 * rand.Next(80, 101) / 100;
            this.Min = this.Required * rand.Next(1, 4);
            this.Max = this.Required * rand.Next(4, 6);
        }
        public CreatingItems(int requiredLevel,Random rand)
        {
            this.Required = requiredLevel * rand.Next(1, 4);
            this.RequiredLevel = requiredLevel;
            this.Price = requiredLevel * 100 * rand.Next(80, 101) / 100;
            this.Min = this.Required * rand.Next(1, 4);
            this.Max = this.Required * rand.Next(4, 6);
        }
    }
}
