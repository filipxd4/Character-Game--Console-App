using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class ChangeNumbersToPlus
    {
        public static void Durability(ICharacters character)
        {

            string wynik = "";
            for (int i = 0; character.Durability > i; i++)
            {
                wynik += '+';
            }
            wynik.Replace(Environment.NewLine, String.Empty);
            Console.WriteLine("1.Durability" + "(" + character.Durability + ")" + wynik);

        }
        public static void Intelligence(ICharacters character)
        {

            string wynik = "";
            for (int i = 0; character.Intelligence > i; i++)
            {
                wynik += '+';
            }
            wynik.Replace(Environment.NewLine, String.Empty);
            Console.WriteLine("2.Inteligence" + "(" + character.Intelligence + ")" + wynik);

        }
        public static void Skill(ICharacters character)
        {

            string wynik = "";
            for (int i = 0; character.Alchemics > i; i++)
            {
                wynik += '+';
            }
            wynik.Replace(Environment.NewLine, String.Empty);
            Console.WriteLine("3.Skill" + "(" + character.Alchemics + ")" + wynik);

        }
        public static void Strength(ICharacters character)
        {

            string wynik = "";
            for (int i = 0; character.Strength > i; i++)
            {
                wynik += '+';
            }
            wynik.Replace(Environment.NewLine, String.Empty);
            Console.WriteLine("4.Strength" + "(" + character.Strength + ")" + wynik);



        }


    }
}