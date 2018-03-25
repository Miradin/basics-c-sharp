//Zhigunov. Zadanie 3: S klaviatury vvodjatsja chisla, poka ne budet vvedet 0. Podschitat summu vseh nechetnych polozhitelnych chisel. 
using System;

class Program
{
    
    static void Main(string[] args)
    {
        double sum = 0;
        bool doexit = false;
        while (doexit == false)
        {
            Console.WriteLine("Enter a number (enter 0 to finish): ");
            double num = Double.Parse(Console.ReadLine());
            if (num == 0)
            {
                doexit = true;
            }
            else if (num > 0 && num % 2 != 0)
            {
                sum = sum + num;
            }
        }

        Console.WriteLine("Sum of all positive odds is: " + sum);
        Console.ReadKey();
    }
}
