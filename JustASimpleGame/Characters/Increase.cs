using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Increase
    {
        public static void Add(ICharacters character)
        {
            
            
                while (character.AmountOfAtributes > 0)
                {
            Again:

                Console.Clear();
                    Console.WriteLine("There are your atributes: ");
                    ChangeNumbersToPlus.Durability(character);
                    ChangeNumbersToPlus.Intelligence(character);
                    ChangeNumbersToPlus.Skill(character);
                    ChangeNumbersToPlus.Strength(character);

                    Console.WriteLine($"Now, you can use: " + character.AmountOfAtributes + " atributes. Select where do you want to add Atribute\n1-Durability\n2-Intelligence\n3-Skill\n4-Strength\nMake a mistake?Click 5 and go to decrease to correct it");
                    int Where;
                    Int32.TryParse(Console.ReadLine(), out Where);
                    switch (Where)
                    {
                        case 1:
                            {
                                Console.WriteLine("Write how many atributes do you want to add:");
                                int NumberOfEnter1;
                                Int32.TryParse(Console.ReadLine(), out NumberOfEnter1);
                                if (NumberOfEnter1 <= character.AmountOfAtributes)
                                {
                                    character.Durability += NumberOfEnter1;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wrong number");
                                    Thread.Sleep(750);
                                    Console.Clear();
                                    goto Again;
                                }
                                character.AmountOfAtributes = character.AmountOfAtributes - NumberOfEnter1;
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Write how many atributes do you want to add: ");
                                int NumberOfEnter2;
                                Int32.TryParse(Console.ReadLine(), out NumberOfEnter2);
                                if (NumberOfEnter2 <= character.AmountOfAtributes)
                                {
                                    character.Intelligence += NumberOfEnter2;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wrong number");
                                    Thread.Sleep(750);
                                    Console.Clear();
                                    goto Again;
                                }

                                character.AmountOfAtributes = character.AmountOfAtributes - NumberOfEnter2;
                                break;
                            }
                     
                        case 3:
                            {
                                Console.WriteLine("Write how many atributes do you want to add:");
                                int NumberOfEnter4;
                                Int32.TryParse(Console.ReadLine(), out NumberOfEnter4);
                                if (NumberOfEnter4 <= character.AmountOfAtributes)
                                {
                                    character.Alchemics += NumberOfEnter4;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wrong number");
                                    Thread.Sleep(750);
                                    Console.Clear();
                                    goto Again;
                                }
                                character.AmountOfAtributes = character.AmountOfAtributes - NumberOfEnter4;
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Write how many atributes do you want to add:");
                                int NumberOfEnter5;
                                Int32.TryParse(Console.ReadLine(), out NumberOfEnter5);
                                if (NumberOfEnter5 <= character.AmountOfAtributes)
                                {
                                    character.Strength += NumberOfEnter5;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wrong number");
                                    Thread.Sleep(750);
                                    Console.Clear();
                                    goto Again;
                                }
                                character.AmountOfAtributes = character.AmountOfAtributes - NumberOfEnter5;
                                break;
                            }
                        
                        case 5:
                            {

                                Decrease.DecreaseAtribute(character);
                                break;

                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong number try again");
                                Thread.Sleep(750);
                                Console.Clear();
                                break;
                            }
                    }


                }
                MoreOnChoices.Choice(character);
            }
            

        
    }
}
