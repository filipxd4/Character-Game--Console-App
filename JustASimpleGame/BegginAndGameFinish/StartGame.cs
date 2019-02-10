using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class StartGame
    {
        public static void CreatingCharacter(ref ICharacters character)
        {
            Console.Clear();
            Console.WriteLine("What type of character would you like to choose?");
            Console.WriteLine("1.Giant");
            Console.WriteLine("2.Wizard");
            Console.WriteLine("3.Archer");
            Console.WriteLine("4.To get more information about them");
            Console.WriteLine("5.Back");
            int Choice = OnInputWork.ChoiceHandler();

            switch (Choice)
            {
                case 1:
                    {
                        Console.WriteLine("Are you sure? You couldn't go back from there");
                        Console.WriteLine("Click Y if yes N to go back");
                        string select = Console.ReadLine();
                        select = select.ToUpper();

                        if (select == "Y")
                        {
                            StartGame.GiantCharacter(out character);
                            CreationACharacter.Choice(character);
                        }
                        else if (select == "N")
                        {
                            StartGame.CreatingCharacter(ref character);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong Letter. Try Again");
                            StartGame.CreatingCharacter(ref character);
                        }

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Are you sure? You couldn't go back from there");
                        Console.WriteLine("Click Y if yes N to go back");
                        string select = Console.ReadLine();
                        select = select.ToUpper();

                        if (select == "Y")
                        {
                            StartGame.WizardCharacter(out character);
                            CreationACharacter.Choice(character);
                        }
                        else if (select == "N")
                        {
                            StartGame.CreatingCharacter(ref character);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong Letter. Try Again");
                            StartGame.CreatingCharacter(ref character);
                        }


                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Are you sure? You couldn't go back from there");
                        Console.WriteLine("Click Y if yes N to go back");
                        string select = Console.ReadLine();
                        select = select.ToUpper();

                        if (select == "Y")
                        {
                            StartGame.ArcherCharacter(out character);
                            CreationACharacter.Choice(character);
                        }
                        else if (select == "N")
                        {
                            StartGame.CreatingCharacter(ref character);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong Letter. Try Again");
                            StartGame.CreatingCharacter(ref character);
                        }
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        StartGame.HeroTypeInformation(character);
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        GameInvocation.OptionsSelector();
                        break;
                    }
                default:
                    {
                        StartGame.CreatingCharacter(ref character);
                        break;
                    }
            }
        }
        public static void HeroTypeInformation(ICharacters character)
        {
            Console.Clear();
            Console.WriteLine("1.Wizard");
            Console.WriteLine("2.Giant");
            Console.WriteLine("3.Archer");
            Console.WriteLine("4.Back");

            int choice = OnInputWork.ChoiceHandler();
            switch (choice)
            {
                case 1:
                    {
                        Wizard wizard = new Wizard();
                        Console.WriteLine("              WIZARD");
                        wizard.Picture();
                        ChangeNumbersToPlus.Durability(wizard);
                        ChangeNumbersToPlus.Intelligence(wizard);
                        ChangeNumbersToPlus.Skill(wizard);
                        ChangeNumbersToPlus.Strength(wizard);
                    upper:
                        int choice2 = OnInputWork.ChoiceHandler();

                        if (choice2 == 4)
                        {
                            StartGame.HeroTypeInformation(character);
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
                case 2:
                    {
                        Giant giant = new Giant();
                        Console.WriteLine("            GIANT");
                        giant.Picture();
                        ChangeNumbersToPlus.Durability(giant);
                        ChangeNumbersToPlus.Intelligence(giant);
                        ChangeNumbersToPlus.Skill(giant);
                        ChangeNumbersToPlus.Strength(giant);

                    upper:


                        int choice2 = OnInputWork.ChoiceHandler();

                        if (choice2 == 4)
                        {

                            StartGame.HeroTypeInformation(character);


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
                        Archer archer = new Archer();
                        Console.WriteLine("              ARCHER");
                        archer.Picture();
                        ChangeNumbersToPlus.Durability(archer);
                        ChangeNumbersToPlus.Intelligence(archer);
                        ChangeNumbersToPlus.Skill(archer);
                        ChangeNumbersToPlus.Strength(archer);


                    upper:
                        int choice2 = OnInputWork.ChoiceHandler();

                        if (choice2 == 4)
                        {
                            StartGame.HeroTypeInformation(character);
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
                        StartGame.CreatingCharacter(ref character);

                        break;
                    }

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong number try again");
                        Thread.Sleep(750);
                        Console.Clear();
                        StartGame.HeroTypeInformation(character);
                        break;
                    }
            }
        }
        public static void GiantCharacter(out ICharacters character)
        {
            Giant gigant = new Giant();
            character = gigant;
        }
        public static void WizardCharacter(out ICharacters character)
        {
            Wizard wizard = new Wizard();
            character = wizard;
        }
        public static void ArcherCharacter(out ICharacters character)
        {
            Archer archer = new Archer();
            character = archer;
        }
    
}
}
