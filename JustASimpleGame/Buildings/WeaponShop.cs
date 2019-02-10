using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Buildings
{
    class WeaponShop
    {
       
        public static void Weapon (ICharacters character,List<CreatingItems> buildingitems, int wynik)
        {
            switch (wynik)
            {
                case 1:
                    {
                        CreatingItems one = buildingitems[0];
                        if (character.Strength >= one.Required)
                        {
                            if (one.Price <= character.Money)
                            {
                                character.MaxDmgWeapon += one.Max;
                                character.MinDmgWeapon += one.Min;
                                character.Money -= one.Price;
                                Console.WriteLine("You have: "+character.Money+" money and your min. damage increase to: "+character.MinDmgWeapon+" and max to: "+character.MaxDmgWeapon);
                                Thread.Sleep(750);
                                BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(),character);
                            }
                            else
                            {
                                Console.WriteLine("You dont have enought money!");
                                BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(),character);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have enought Strength:( ");
                            BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                        }
                        
                        break;
                    }
                case 2:
                    {
                        CreatingItems one = buildingitems[1];
                        if (character.Strength >= one.Required)
                        {
                            if (one.Price <= character.Money)
                            {
                                character.MaxDmgWeapon += one.Max;
                                character.MinDmgWeapon += one.Min;
                                character.Money -= one.Price;
                                Console.WriteLine("You have: " + character.Money + " money and your min. damage increase to: " + character.MinDmgWeapon + " and max to: " + character.MaxDmgWeapon);
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
                            Console.WriteLine("You don't have enought Strength:( ");
                            BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                        }
                        break;
                    }
                case 3:
                    {
                        CreatingItems one = buildingitems[2];
                        if (character.Strength >= one.Required)
                        {
                            if (one.Price <= character.Money)
                            {
                                character.MaxDmgWeapon += one.Max;
                                character.MinDmgWeapon += one.Min;
                                character.Money -= one.Price;
                                Console.WriteLine("You have: " + character.Money + " money and your min. damage increase to: " + character.MinDmgWeapon + " and max to: " + character.MaxDmgWeapon);
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
                            Console.WriteLine("You don't have enought Strength:( ");
                            BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
                        }
                        break;
                    }
                case 4:
                    {
                        CreatingItems one = buildingitems[3];
                        if (character.Strength >= one.Required)
                        {
                            if (one.Price <= character.Money)
                            {
                                character.MaxDmgWeapon += one.Max;
                                character.MinDmgWeapon += one.Min;
                                character.Money -= one.Price;
                                Console.WriteLine("You have: " + character.Money + " money and your min. damage increase to: " + character.MinDmgWeapon + " and max to: " + character.MaxDmgWeapon);
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
                            Console.WriteLine("You don't have enought Strength:( ");
                            BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(), character);
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
