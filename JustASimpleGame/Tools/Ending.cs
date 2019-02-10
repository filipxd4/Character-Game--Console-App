using System;
using System.Threading;

public class Ending
{
    public static void TheEnd()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        string s = "The End";
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
        Console.WriteLine(s);
        Console.ResetColor();
        Thread.Sleep(4000);
        Console.Clear();
    }
}

