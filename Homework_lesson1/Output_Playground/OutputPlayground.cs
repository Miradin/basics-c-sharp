//Zhigunov. Zadanie 5: Vyvod v konsol posredine
using System;

class Program
{
    static void CenteredText(string message, int nextline)
    {
        int height = Console.WindowHeight;
        int width = Console.WindowWidth;
        Console.SetCursorPosition((width - message.Length) / 2, height / 2 + nextline);
        Console.WriteLine(message);
    }

    static void Main(string[] args)
    {
        //without a method
        int height = Console.WindowHeight;
        int width = Console.WindowWidth;
        Console.Title = "Centered message";
        string message = "My name is Alexander";
        Console.SetCursorPosition((width - message.Length) / 2, height / 2);
        Console.WriteLine("My name is Alexander.");
        Console.SetCursorPosition((width - message.Length) / 2, height / 2 + 1);
        Console.WriteLine("I live in a city.");

        //using a method
        Console.ForegroundColor = ConsoleColor.Cyan;
        CenteredText("Welcome to this", 3);
        CenteredText("powerfull output!", 4);
        Console.ReadKey();
    }
}