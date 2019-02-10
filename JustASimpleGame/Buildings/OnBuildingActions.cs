using JustASimpleGame.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OnBuildingActions
    {
        public static void InDoors(ICharacters character)
        {
            if (CityMap.PositionX == 20 && CityMap.PositionY == 19)
            {
                BuildingMessages.BuldingMessage("Arena");
                Arena.FightInArena(character,OnInputWork.ChoiceHandler());
            }
            else if (CityMap.PositionX == 26 && CityMap.PositionY == 11)
            {
                BuildingMessages.BuldingMessage("WeaponSmith");
                Console.WriteLine("You have: " + character.Money + " money, " + character.Strength + " Strength!");
                List<CreatingItems> buildingitems = new List<CreatingItems>();
                buildingitems = ProductsInBuldings.GetWeaponsAvailable(character);
                Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Strength"));
                WeaponShop.Weapon(character, buildingitems, OnInputWork.ChoiceHandler());
            }
            else if (CityMap.PositionX == 30 && CityMap.PositionY == 7)
            {
                BuildingMessages.BuldingMessage("ArmorSmith");
                Console.WriteLine("You have: " + character.Money + " money, " + character.Durability + " Durability!");
                List<CreatingItems> buildingitems = new List<CreatingItems>();
                buildingitems = ProductsInBuldings.GetArmorAvailable(character);
                Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Durability"));
                ArmorSmith.Armor(character, buildingitems, OnInputWork.ChoiceHandler());
            }
            else if (CityMap.PositionX == 16 && CityMap.PositionY == 4)
            {
                BuildingMessages.BuldingMessage("Shop");
                Console.WriteLine("You have: " + character.Money + " money, " + character.Alchemics + " Alchemics!");
                List<CreatingItems> buildingitems = new List<CreatingItems>();
                buildingitems = ProductsInBuldings.GetShopAvailable(character);
                Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Alchemics"));
                ItemShop.Item(character, buildingitems, OnInputWork.ChoiceHandler());
            }
        }
    }
}
