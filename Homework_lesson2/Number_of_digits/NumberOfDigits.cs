//Zhigunov. Zadanie 2: Napisat metod podscheta kolichestva cifr chisla 
using System;

class Program
{
    static int DigitsNumber(string text)
    {
        int i = 0;
        foreach (char c in text)
        {
            i++;
        }
        return i;
    }
    static void Main(string[] args)
    {
        System.Console.Write("Hello! This program will calculate digits in number. \nPlease, enter number 1: ");
        string text = Console.ReadLine();
        System.Console.WriteLine("Total number of digits is: " + DigitsNumber(text));
        Console.ReadKey();
    }
}
