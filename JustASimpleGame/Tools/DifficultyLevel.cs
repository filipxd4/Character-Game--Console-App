using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Tools
{
    class DifficultyLevel
    {
        public static void ChangeDifficulty()
        {
            Console.Clear();
            Console.WriteLine("Change difficulty level: ");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium ");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. Back");

            int choice = OnInputWork.ChoiceHandler();
            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Difficulty Changed to: Hard");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Difficulty Changed to: Hard");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Difficulty Changed to: Hard");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong number try again");
                        Thread.Sleep(750);
                        Console.Clear();
                        Graphics.ChangeGraphics();
                        break;
                    }
            }
        }
    }
}
