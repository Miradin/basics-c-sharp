//Zhigunov. Zadanie 2: Rasschet indeksa massy tela 
using System;

class Program
{
    static void Print(string message, ConsoleColor foregroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.Write(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void Main(string[] args)
    {
        Print("Hello! This program will calculate your BMI. \nPlease, enter your height (meters): ", ConsoleColor.Red);
        double height = double.Parse(Console.ReadLine());
        Print("Please, enter your weight (kg): ", ConsoleColor.Red);
        double weight = double.Parse(Console.ReadLine());
        //calculation according to given equation
        double bmi = weight / (height * height);
        //output using new syntaxis, with $
        Console.WriteLine($"Thank you. You BMI is {bmi:F2}.");
        Console.ReadKey();
    }
}
