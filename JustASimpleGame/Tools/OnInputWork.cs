using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    static class OnInputWork
    {
        public static int ChoiceHandler()
        {
            int Choice = 0;
            Console.WriteLine("Choose your action: ");
            int.TryParse(Console.ReadLine(), out Choice);
            return Choice;
        }
        public static string MovingOnMapHandler()
        {
            string Choice;
            Console.WriteLine("Choose your action: ");
            Choice = Console.ReadLine();
            return Choice;
        }
    }
}
