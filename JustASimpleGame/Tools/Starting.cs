using JustASimpleGame.Tools;
using System;
using System.Threading;

public class Starting
{
    public static void StartTxt()
    {
        int origWidth = 110;
        int origHeight = 20;
        origWidth = Console.WindowWidth;
        origHeight = Console.WindowHeight;
        BackgroundColor.Color();
        string s = "Character Game";
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.SetCursorPosition((origWidth- s.Length) / 2, Console.CursorTop);
        Console.WriteLine(s);
        Console.ReadKey();
        Console.Clear();
    }
   
}
