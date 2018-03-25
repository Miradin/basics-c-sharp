/*Zhigunov. Zadanie 5. а) Написать программу, которая запрашивает массу и рост человека, 
* вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
* б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/
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
        Print("Hello! This program will calculate your BMI. \nPlease, enter your height (cm): ", ConsoleColor.Yellow);
        double height = double.Parse(Console.ReadLine())/100;
        Print("Please, enter your weight (kg): ", ConsoleColor.Green);
        double weight = double.Parse(Console.ReadLine());
        //calculation according to given equation
        double bmi = weight / (height * height);
        //output using new syntaxis, with $
        Console.WriteLine($"Thank you. You BMI is {bmi:F2}.");
        if (bmi > 24.99)
        {
            Console.WriteLine("Your weight is too big (or your height is too small ;)");
            Console.WriteLine("It is recommended for you to get rid of " + ((bmi - 24.99) * height * height) + " kg.");
        }
        else if (bmi < 18.5)
        {
            Console.WriteLine("Your weight is too small.");
            Console.WriteLine("It is recommended for you to get " + ((18.5-bmi) * height * height) + " kg more.");
        }
        else
        {
            Console.WriteLine("You are just fine.");
        }
        Console.ReadKey();
    }
}
