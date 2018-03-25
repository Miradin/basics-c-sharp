//Zhigunov. Zadanie 1: Napisat metod vozvrashajushij minimalnoe iz 3-h chisel 
using System;

class Program
{
    static void Print(string message, ConsoleColor foregroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.Write(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static double Min_of_3(double num1, double num2, double num3)
    {
        double min3 = 0;
        if (num1 < num2 && num1 < num3)
        {
            //Console.WriteLine($"Lowest number is number 1: {num1}.");
            min3 = num1;
        }
        else if (num2 < num1 && num2 < num3)
        {
            //Console.WriteLine($"Lowest number is number 2: {num2}.");
            min3 = num2;
        }
        else if (num3 < num1 && num3 < num2)
        {
            //Console.WriteLine($"Lowest number is number 3: {num3}.");
            min3 = num3;
        }
        return min3;
    }
    static void Main(string[] args)
    {
        Print("Hello! This program will choose min of 3 entered numbers. \nPlease, enter number 1: ", ConsoleColor.Green);
        double num1 = double.Parse(Console.ReadLine());
        Print("Please, enter number 2: ", ConsoleColor.Green);
        double num2 = double.Parse(Console.ReadLine());
        Print("Please, enter number 3: ", ConsoleColor.Green);
        double num3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Lowest number is: " + Min_of_3(num1, num2, num3));
        Console.ReadKey();
    }
}
