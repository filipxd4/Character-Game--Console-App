using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class BuildingPurchase
    {
        public static void Buying(string choice, ICharacters character)
        {
            choice = choice.ToUpper();
            if(choice=="D")
            {
                CityMap.ShowMap(choice,character);

            }
        }
    }
}
