//Zhigunov. Zadanie 3: Rasschet rasstojanija po formule
using System;

class Program
{
    static double DistanceCalc(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
 
    static void Main(string[] args)
    {
        double x1 = 10;
        double y1 = 20;
        double x2 = 150;
        double y2 = 100.5;
        //calculation according to given equation
        double distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
        //output using new syntaxis, with $
        Console.WriteLine($"Calculated distance is {distance:F2}.");
        //calculation using method... task with asterix
        Console.WriteLine($"Calculated distance is {DistanceCalc(x1,y1,x2,y2):F2}.");
        Console.ReadKey();
    }
}
