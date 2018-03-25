//Zhigunov. Zadanie 1: Anketa. 
using System;

class Program
{
    static void Print(string message, ConsoleColor foregroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void Main(string[] args)
    {
        Print("Please, enter your name: ", ConsoleColor.Red);
        string name = Console.ReadLine();
        Print("Please, enter your surname: ", ConsoleColor.Red);
        string surname = Console.ReadLine();
        Print("How old are you?: ", ConsoleColor.Red);
        string age = Console.ReadLine();
        Print("Please, enter your height:", ConsoleColor.Red);
        string height = Console.ReadLine();
        Print("Please, enter your weight: ", ConsoleColor.Red);
        string weight = Console.ReadLine();
        //string concatenation
        Print("Hello, " + name + " " + surname + "! You are " + age + " years old and " + height + " cm tall;" + " your weight is " + weight + " kg.", ConsoleColor.Green);
        //formated output
        Console.WriteLine("Hello, {0} {1}! You are {2} years old and {3} cm tall; your weight is {4} kg.", name, surname, age, height, weight);
        //output using new syntaxis, with $... task with asterix
        Console.WriteLine($"Hello, {name} {surname}! You are {age} years old and {height} cm tall; your weight is {weight} kg");
        Console.ReadKey();
    }
}
