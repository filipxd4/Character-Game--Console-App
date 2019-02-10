using System;
using System.Threading;

namespace JustASimpleGame
{
    class Decrease
    {
        public static void DecreaseAtribute(ICharacters character)
        {
        Again:
            Console.Clear();
            Console.WriteLine("You Have: ");
            ChangeNumbersToPlus.Durability(character);
            ChangeNumbersToPlus.Intelligence(character);
            ChangeNumbersToPlus.Skill(character);
            ChangeNumbersToPlus.Strength(character);
            Console.WriteLine("What atribute would you like to decrease?");
            int Where = OnInputWork.ChoiceHandler();
            switch (Where)
            {
                case 1:
                    {
                        Console.WriteLine("Write how many atributes do you want to remove:");
                        int NumberOfEnter1;
                        Int32.TryParse(Console.ReadLine(), out NumberOfEnter1);
                        if (NumberOfEnter1 <= character.Durability)
                        {
                            character.Durability -= NumberOfEnter1;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Too big number!");
                            Thread.Sleep(750);
                            Console.Clear();
                            goto Again;
                        }
                        character.AmountOfAtributes = character.AmountOfAtributes + NumberOfEnter1;
                        MoreOnChoices.Choice(character);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Write how many atributes do you want to remove: ");
                        int NumberOfEnter2;
                        Int32.TryParse(Console.ReadLine(), out NumberOfEnter2);
                        if (NumberOfEnter2 <= character.Intelligence)
                        {
                            character.Intelligence -= NumberOfEnter2;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Too big number!");
                            Thread.Sleep(750);
                            Console.Clear();
                            goto Again;
                        }

                        character.AmountOfAtributes = character.AmountOfAtributes + NumberOfEnter2;
                        MoreOnChoices.Choice(character);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Write how many atributes do you want to remove:");
                        int NumberOfEnter3;
                        Int32.TryParse(Console.ReadLine(), out NumberOfEnter3);
                        if (NumberOfEnter3 <= character.Range)
                        {
                            character.Range -= NumberOfEnter3; ;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Too big number!");
                            Thread.Sleep(750);
                            Console.Clear();
                            goto Again;
                        }
                        character.AmountOfAtributes = character.AmountOfAtributes + NumberOfEnter3;
                        MoreOnChoices.Choice(character);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Write how many atributes do you want to remove:");
                        int NumberOfEnter4;
                        Int32.TryParse(Console.ReadLine(), out NumberOfEnter4);
                        if (NumberOfEnter4 <= character.Alchemics)
                        {
                            character.Alchemics -= NumberOfEnter4;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Too big number!");
                            Thread.Sleep(750);
                            Console.Clear();
                            goto Again;
                        }
                        character.AmountOfAtributes = character.AmountOfAtributes + NumberOfEnter4;
                        MoreOnChoices.Choice(character);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Write how many atributes do you want to remove:");
                        int NumberOfEnter5;
                        Int32.TryParse(Console.ReadLine(), out NumberOfEnter5);
                        if (NumberOfEnter5 <= character.Strength)
                        {
                            character.Strength -= NumberOfEnter5;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Too big number!");
                            Thread.Sleep(750);
                            Console.Clear();
                            goto Again;
                        }
                        character.AmountOfAtributes = character.AmountOfAtributes + NumberOfEnter5;
                        MoreOnChoices.Choice(character);

                        break;
                    }
                case 6:
                    {
                        CreationACharacter.Choice(character);
                        break;
                    }
                case 7:
                    {
                        Increase.Add(character);
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


    }

}