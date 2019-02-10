using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class CreationACharacter
    {
        public static void Choice(ICharacters character)
        {
            Console.Clear();
            int origWidth = 110;
            origWidth = Console.WindowWidth;
            string k = "At the start of the game you have: " + character.AmountOfAtributes + " atributes to alocate.";
            string g = "                         You will get atributes also when you will win fight with opponent.";
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.SetCursorPosition((origWidth - k.Length) / 2, Console.CursorTop);
            Console.WriteLine(k+"\n"+g);
            Console.ReadKey();
            Increase.Add(character);
        }

    }
}