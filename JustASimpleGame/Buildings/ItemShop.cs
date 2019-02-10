using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Buildings
{
    class ItemShop
    {
        public static void Item(ICharacters character, List<CreatingItems> buildingitems, int wynik)
        {
            switch (wynik)
            {
                case 1:
                    {
                        CreatingItems one = buildingitems[0];
                        if (character.Alchemics >= one.RequiredLevel)
                        {
                            if (character.ListOfItems.Count < 4)
                            {
                                if (one.Price <= character.Money)
                                {
                                    character.Money -= one.Price;
                                    character.ListOfItems.Add(one.Max);

                                    Console.WriteLine("You add to your items health! Now you can use it at attack.");
                                    Thread.Sleep(750);
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                                }
                                else
                                {
                                    Console.WriteLine("You dont have enought money!");
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Too many health items! You can own only 4 items!");
                                BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have required Strength!");
                        }
                        break;

                    }
                case 2:
                    {
                        CreatingItems one = buildingitems[1];
                        if (character.Alchemics >= one.RequiredLevel)
                        {
                            if (character.ListOfItems.Count < 4)
                            {
                                if (one.Price <= character.Money)
                                {
                                    character.Money -= one.Price;
                                    character.ListOfItems.Add(one.Max);
                                    Console.WriteLine("You add to your items health! Now you can use it at attack.");
                                    Thread.Sleep(750);
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                                }
                                else
                                {
                                    Console.WriteLine("You dont have enought money!");
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Too many health items! You can own only 4 items!");
                                BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                            }
                        }
                        break;

                    }
                case 3:
                    {
                        CreatingItems one = buildingitems[2];
                        if (character.Alchemics >= one.RequiredLevel)
                        {
                            if (character.ListOfItems.Count < 4)
                            {
                                if (one.Price <= character.Money)
                                {
                                    character.Money -= one.Price;
                                    character.ListOfItems.Add(one.Max);

                                    Console.WriteLine("You add to your items health! Now you can use it at attack.");
                                    Thread.Sleep(750);
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                                }
                                else
                                {
                                    Console.WriteLine("You dont have enought money!");
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Too many health items! You can own only 4 items!");
                                BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                            }
                        }
                        break;

                    }
                case 4:
                    {
                        CreatingItems one = buildingitems[3];
                        if (character.Alchemics >= one.RequiredLevel)
                        {
                            if (character.ListOfItems.Count < 4)
                            {
                                if (one.Price <= character.Money)
                                {
                                    character.Money -= one.Price;
                                    character.ListOfItems.Add(one.Max);

                                    Console.WriteLine("You add to your items health! Now you can use it at attack.");
                                    Thread.Sleep(750);
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                                }
                                else
                                {
                                    Console.WriteLine("You dont have enought money!");
                                    BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Too many health items! You can own only 4 items!");
                                BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                            }
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Wrong Number!");
                        BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                        break;
                    }
            }
        }
    }
}
