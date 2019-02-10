using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Tools
{
    class Graphics
    {
        public static void ChangeGraphics()
        {
            Console.Clear();
            Console.WriteLine("Change the graphics: ");
            Console.WriteLine("1. Minimum Quality");
            Console.WriteLine("2. Medium Quality");
            Console.WriteLine("3. Max Quality");
            Console.WriteLine("4. Back");

            int choice = OnInputWork.ChoiceHandler();
            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Ehh.. so now you can see how good is your computer :) ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Options.Changes();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("This graphics is too advanced for your computer :(");
                    upper:
                        Console.WriteLine("1.Back and set another graphics");
                        int choice2 = OnInputWork.ChoiceHandler();

                        if (choice2 == 1)
                        {

                            Graphics.ChangeGraphics();


                        }
                        else
                        {
                            Console.WriteLine("Write correct number!");
                            Thread.Sleep(750);
                            Console.Clear();
                            goto upper;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Your Computer is too shity :(");
                    upper:
                        Console.WriteLine("1.Back and set another graphics");
                        int choice2 = OnInputWork.ChoiceHandler();

                        if (choice2 == 1)
                        {

                            Graphics.ChangeGraphics();


                        }
                        else
                        {
                            Console.WriteLine("Write correct number!");
                            Thread.Sleep(750);
                            Console.Clear();
                            goto upper;
                        }
                        break;
                    }
                case 4:
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
                        Graphics.ChangeGraphics();
                        break;
                    }
            }
        }
    }
}
