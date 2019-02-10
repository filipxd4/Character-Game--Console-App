using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Map
    {
        public static void ShowMap()
        {
            int height;
            int width;
            Map.GenerateMap(out width, out height);
            string[,] GameMap = new string[width, height];
            
            GameMap=Map.GenerateMap(out width,out height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(GameMap[j, i]);
                }
                Console.WriteLine();
            }
            
        }
        public static string[,] Moving(int width,int height,string[,] rectangle)
        {
            string[,] GameMap = new string[width, height];
            GameMap = rectangle;
            
            //PositionX = 3;
            //PositionY = 3;
            return GameMap;
        }
        private static string[,] GenerateMap(out int width,out int height)
        {
            height = 25;
            width = 50;
            string[,] GameMap = new string[width, height];
            GameMap = Map.BlankArray(width, height);
            GameMap = Map.Rectangle(width, height,0,0,GameMap);
            GameMap = Map.Building(width, height, 10, 5, 5, 2,"Shop",GameMap);
            GameMap = Map.Building(width, height, 20, 5, 20, 2, "ArmorSmith", GameMap);
            GameMap = Map.Building(width, height, 20, 5, 5, 9, "WeaponSmith", GameMap);
            GameMap = Map.Building(width, height, 15,10, 5, 14, "Arena", GameMap);
            GameMap[width - 5, height - 2] = "X";
            return GameMap;
        }
        private static string[,] Rectangle (int width,int height,int OffSetX,int OffSetY, string[,] rectangle)
        {
            string[,] GameMap = new string[width, height];
            GameMap = rectangle;
            for (int i = 1; i < height - 1; i++)
            {
                GameMap[0+OffSetX, i+OffSetY] = "║";
                GameMap[width - 1+OffSetX, i+OffSetY] = "║";
            }
            for (int i = 1; i < width - 1; i++)
            {
                GameMap[i+OffSetX, 0+OffSetY] = "═";
                GameMap[i+OffSetX, height - 1+OffSetY] = "═";
            }
            GameMap[0+OffSetX, 0+OffSetY] = "╔";
            GameMap[0+OffSetX, height - 1+OffSetY] = "╚";
            GameMap[width - 1+OffSetX, 0+OffSetY] = "╗";
            GameMap[width - 1+OffSetX, height - 1+OffSetY] = "╝";
            return GameMap;
        }
        private static string[,] BlankArray(int width,int height)
        {
            string[,] GameMap = new string[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    GameMap[j, i] = " ";
                }
            }
            return GameMap;
        }
        private static string[,] Building(int width,int height,int buildingWidth,int buildingHeight,int OffSetX,int OffSetY,string text,string[,] rectangle)
        {
            string[,] GameShop = new string[width, height];
            GameShop = Map.Rectangle(buildingWidth, buildingHeight,OffSetX,OffSetY,rectangle);
            string Text = text;
            for(int i=0;i<text.Length;i++)
            {
                GameShop[2 + OffSetX+i, (buildingHeight / 2) + OffSetY] = Convert.ToString(text[i]);
            }
            return GameShop;
        }
    }
}
//PRZY WIDTH HEIGHT =0 SIE WYWALA