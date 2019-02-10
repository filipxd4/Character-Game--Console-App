using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class ProductsInBuldings
    {
        public static List<CreatingItems> GetWeaponsAvailable(ICharacters character)
        {
            Random rand = new Random();
            List<CreatingItems> items = new List<CreatingItems>();
            Weapon FirstItem = new Weapon(character,rand);
            items.Add(FirstItem);
            Weapon SecondItem = new Weapon(character,rand);
            items.Add(SecondItem);
            Weapon ThirdItem = new Weapon(character,rand);
            items.Add(ThirdItem);
            Weapon FourhtItem = new Weapon(character,rand);
            items.Add(FourhtItem);
            return items;
        }
        public static List<CreatingItems> GetArmorAvailable(ICharacters character)
        {
            Random rand = new Random();
            List<CreatingItems> items = new List<CreatingItems>();
            Armor FirstItem = new Armor(character, rand);
            items.Add(FirstItem);
            Armor SecondItem = new Armor(character, rand);
            items.Add(SecondItem);
            Armor ThirdItem = new Armor(character, rand);
            items.Add(ThirdItem);
            Armor FourhtItem = new Armor(character, rand);
            items.Add(FourhtItem);
            return items;
        }
        public static List<CreatingItems> GetShopAvailable(ICharacters character)
        {
            Random rand = new Random();
            List<CreatingItems> items = new List<CreatingItems>();
            Shop FirstItem = new Shop(character, rand);
            items.Add(FirstItem);
            Shop SecondItem = new Shop(character, rand);
            items.Add(SecondItem);
            Shop ThirdItem = new Shop(character, rand);
            items.Add(ThirdItem);
            Shop FourhtItem = new Shop(character, rand);
            items.Add(FourhtItem);
            return items;
        }
            public static string ShowProductsAvailable(List<CreatingItems> items, string requiredAttribute)
        {
            var report = new System.Text.StringBuilder();
            List<CreatingItems> buildingitems = new List<CreatingItems>();
            buildingitems = items;
            report.AppendLine($"No.  Required {requiredAttribute,-12}  Price  Actions");
            report.AppendLine("┌───────────────────────────────────────────┐");
            int i = 1;
            foreach (var item in buildingitems)
            {
                if(requiredAttribute=="Alchemics" || requiredAttribute== "Durability")
                {
                    report.AppendLine($"{i}.  │ {item.Required,-22}│{item.Price,-7}│{item.Max,-7}│");
                }
                else
                {
                    report.AppendLine($"{i}.  │ {item.Required,-22}│{item.Price,-7}│{item.Min}-{item.Max,-4}│");
                }
                i++;
            }
            report.AppendLine("└───────────────────────────────────────────┘");
            return report.ToString();
        }
    }
}
