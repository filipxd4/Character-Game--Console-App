using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Tools
{
    class Options
    {
        public static void Changes()
        {
            Console.Clear();
            Console.WriteLine("1.Change the graphics ");
            Console.WriteLine("2.Change difficulty level");
            Console.WriteLine("3.Back");

            int choice = OnInputWork.ChoiceHandler();
            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Graphics.ChangeGraphics();
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        DifficultyLevel.ChangeDifficulty();
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        GameInvocation.OptionsSelector();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong number try again");
                        Thread.Sleep(750);
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
            }
        }
    }
}
