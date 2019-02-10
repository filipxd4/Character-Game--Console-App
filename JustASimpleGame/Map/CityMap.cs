using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class CityMap
    {
        private static int MoveX=0;
        private static int MoveY=0;
        public static int PositionX;
        public static int PositionY;
        private static int tempPositionX = 44;
        private static int tempPositionY = 23;
        private static int width;
        private static int height;


        public static void ShowMap(ICharacters character)
        {
            Console.Clear();
            string[,] GameMap = new string[width, height];
            GameMap=CityMap.GenerateMap(out width,out height,out PositionX,out PositionY);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(GameMap[j, i]);
                }
                Console.WriteLine();
            }
            CityMap.MovingHandler(character);
        }
        public static void ShowMap(string choice, ICharacters character)
        {
            Console.Clear();
            string[,] GameMap = new string[width, height];
            GameMap = CityMap.GenerateMap(out width, out height, out PositionX, out PositionY);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(GameMap[j, i]);
                }
                Console.WriteLine();
            }
            CityMap.MovingHandler(choice,character);
        }
        private static void Move(string choice,out int MoveX,out int MoveY)
        {
            choice=choice.ToUpper();
            MoveX = 0;
            MoveY = 0;
            switch (choice)
            {
                case "W":
                    {
                        MoveY = -1;
                        break;
                    }
                case "S":
                    {
                        MoveY = 1;
                        break;
                    }
                case "A":
                    {
                        MoveX = -2;
                        break;
                    }
                case "D":
                    {
                        MoveX = 2;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Use WSAD!");
                        
                        break;
                    }
            }
        }
        private static void MapSize(out int width,out int height)
        {
            width = 51;
            height = 25;
        }
        private static string[,] GenerateMap(out int width,out int height,out int PositionX, out int PositionY)
        {
            CityMap.MapSize(out width, out height);
            string[,] GameMap = new string[width, height];
            GameMap = CityMap.StartMap(width, height);
            GameMap = CityMap.LimitsOfMap(width, height, out PositionX, out PositionY, ref tempPositionX, ref tempPositionY);
            return GameMap;
        }
        private static string[,] StartMap(int width,int height)
        {
            string[,] GameMap = new string[width, height];
            GameMap = CityMap.BlankArray(width, height);
            GameMap = CityMap.Rectangle(width, height, 0, 0, GameMap);
            GameMap = CityMap.Building(width, height, 11, 5, 4, 2, "Shop","right", GameMap);
            GameMap = CityMap.Building(width, height, 21, 5, 20, 2, "ArmorSmith","down", GameMap);
            GameMap = CityMap.Building(width, height, 21, 5, 4, 9, "WeaponSmith","right", GameMap);
            GameMap = CityMap.Building(width, height, 15, 10, 4, 14, "Arena","right", GameMap);
            return GameMap;
        }
        private static string[,] LimitsOfMap(int width,int height, out int PositionX, out int PositionY, ref int tempPositionX, ref int tempPositionY)
        {
            string[,] GameMap = new string[width, height];
            GameMap = CityMap.StartMap(width, height);
            CityMap.CalculatePosition(out PositionX, out PositionY, ref tempPositionX, ref tempPositionY);

            if(GameMap[PositionX,PositionY]==" ")
            {
                GameMap[PositionX, PositionY] = "X";

            }
            else if(GameMap[PositionX, PositionY] == "D")
            {
                GameMap[PositionX, PositionY] = "B";
            }
            else
            {
                PositionX = tempPositionX-MoveX;
                PositionY = tempPositionY-MoveY;
                GameMap[PositionX, PositionY] = "X";
                tempPositionX = PositionX;
                tempPositionY = PositionY;
            }
            return GameMap;
        }
        private static void CalculatePosition(out int PositionX,out int PositionY,ref int tempX,ref int tempY)
        {
            PositionX = tempX + MoveX;
            PositionY = tempY + MoveY;
            tempX = PositionX;
            tempY = PositionY;
        }
        private static void MovingHandler(ICharacters character)
        {
            OnBuildingActions.InDoors(character);
            CityMap.ShowWSAD();
            CityMap.Move(OnInputWork.MovingOnMapHandler(), out MoveX, out MoveY);
            CityMap.ShowMap(character);
        }
        private static void MovingHandler(string choice, ICharacters character)
        {
            CityMap.ShowWSAD();
            CityMap.Move(choice, out MoveX, out MoveY);
            CityMap.ShowMap(character);
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
        private static string[,] Building(int width,int height,int buildingWidth,int buildingHeight,int OffSetX,int OffSetY,string text, string WhereDoors,string[,] rectangle)
        {
            string[,] GameBulding = new string[width, height];
            GameBulding = CityMap.Rectangle(buildingWidth, buildingHeight,OffSetX,OffSetY,rectangle);
            string Text = text;
            for(int i=0;i<text.Length;i++)
            {
                GameBulding[2 + OffSetX+i, (buildingHeight / 2) + OffSetY] = Convert.ToString(text[i]);
            }
            switch (WhereDoors)
            {
                case "up":
                    {
                        GameBulding[buildingWidth / 2 + OffSetX, OffSetY - 1] = "D";
                        break;
                    }
                case "down":
                    {
                        GameBulding[buildingWidth / 2 + OffSetX, buildingHeight + OffSetY] = "D";
                        break;
                    }
                case "left":
                    {
                        GameBulding[OffSetX - 1, height / 2 + OffSetY] = "D";
                        break;
                    }
                case "right":
                    {
                        GameBulding[buildingWidth + 1 + OffSetX, buildingHeight / 2 + OffSetY] = "D";
                        break;
                    }
            }
            return GameBulding;
        }
        private static void ShowWSAD()
        {
            
            Console.WriteLine("To move use WSAD (for every move tap enter)");
            Console.WriteLine("  W");
            Console.WriteLine("A S D");

        }
    }
}
