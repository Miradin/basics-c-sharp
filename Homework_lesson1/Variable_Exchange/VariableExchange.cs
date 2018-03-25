//Zhigunov. Zadanie 4: Obmen zna4enij peremennyh
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        double x = -10;
        double y = 20;
        Console.WriteLine($"Initial values are: x = {x} and y = {y}.");
        //exchange using 3rd variable
        double z = x;
        x = y;
        y = z;
        Console.WriteLine($"After exchange result is: x = {x} and y = {y}.");

        //exchange without 3rd variable... task with asterix... It is highly NOT recommended. Method below is slow.
        x = -10;
        y = 20;
        y = Interlocked.Exchange(ref x, y);
        Console.WriteLine($"After exchange result is: x = {x} and y = {y}.");
        // another method, using some math... also slower
        x = -10;
        y = 20;
        x = x + y; //we lost initial x here
        y = x - y; // new y = x + y - y  
        x = x - y; // new x = x + y - x + y - y
        Console.WriteLine($"After exchange result is: x = {x} and y = {y}.");
        Console.ReadKey();
    }
}
