using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class StartBattle
    {
        private static string WhoStarts()
        {
            Random rand = new Random();
            if (rand.Next(0, (int)Math.Pow(10, 9)) > (5 * (int)Math.Pow(10, 8)))
            {
                return "EnemyStart";
            }
            else
                return "YouStart";
        }

    }
}
