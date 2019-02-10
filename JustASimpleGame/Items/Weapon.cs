using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Weapon : CreatingItems
    {
        public Weapon(ICharacters character, Random rand) : base(character,rand)
        {

        }
    }
}
