using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class MoreOnChoices
    {
        public static void Choice(ICharacters character)
        {

            Console.Clear();
            Console.WriteLine("You have: ");
            ChangeNumbersToPlus.Durability(character);
            ChangeNumbersToPlus.Intelligence(character);
            ChangeNumbersToPlus.Skill(character);
            ChangeNumbersToPlus.Strength(character);
            Console.WriteLine("Do you want to do Sometching else? You have: " + character.AmountOfAtributes + " atributes to allocate");
            Console.WriteLine("1.Decrease mode");
            Console.WriteLine("2.Increase mode");
            Console.WriteLine("3.GO TO MAP");
            int choice = OnInputWork.ChoiceHandler();
            switch (choice)
            {
              
                case 1:
                    {
                        Decrease.DecreaseAtribute(character);
                        break;
                    }
                case 2:
                    {
                        Increase.Add(character);
                        break;
                    }
                case 3:
                    {
                        if (character.AmountOfAtributes == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Are you sure? You couldn't go back from there");
                            Console.WriteLine("Click Y if yes N to go back");
                            string Map = Console.ReadLine();
                            Map = Map.ToUpper();
                            if (Map == "Y")
                            {
                                CityMap.ShowMap(character);
                            }
                            else if (Map == "N")
                            {
                                MoreOnChoices.Choice(character);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong Letter. Try Again");
                                MoreOnChoices.Choice(character);
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You couldn't go to arena. You have: " + character.AmountOfAtributes + " atributes to allocate!");
                            Thread.Sleep(1500);
                            MoreOnChoices.Choice(character);
                        }


                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong number try again");
                        Thread.Sleep(750);
                        Console.Clear();
                        CreationACharacter.Choice(character);
                        break;

                    }

            }
        }
    }

}