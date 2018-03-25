/*Zhigunov. 6. Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000. 
 * Хорошим называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */
using System;

class Program
{
    static bool NumberGoodness(int number)
    {
        bool yes = false;
        string text = number.ToString();
        int b = 0;
        foreach (char c in text)
        {
            b = b + Convert.ToInt32(c)-48; //ascii table dependent???
            
        }
        if (number%b == 0)
        {
            yes = true;
        }
        return yes;
    }

    static void Main(string[] args)
    {
        //version 1, using type convertation
        Console.WriteLine("Be patient...");
        double sum = 0;
        DateTime start = DateTime.Now;
        for (int i=1; i < 1000000000; i++)
        {
            if (NumberGoodness(i))
            {
                sum++;
            }
        }
        DateTime finish = DateTime.Now;
        TimeSpan period = finish - start;
        Console.WriteLine("There are " + sum + " good numbers in range up to 1 000 000 000.");
        Console.WriteLine("Calculation lasts for " + period);
        //version 2. Clever solution, found on Internet.
        sum = 0;
        int temp = 0;
        int testnum = 0;
        start = DateTime.Now;
        for (int i=1; i<1000000000; i++)
        {
            temp = 0;
            testnum = i;
            while (testnum != 0)
            {
                temp = temp + testnum % 10;
                testnum = testnum / 10;
            }
            if (i%temp == 0)
            {
                sum++;
            }
        }
        finish = DateTime.Now;
        period = finish - start;
        Console.WriteLine("Another solution...");
        Console.WriteLine("There are " + sum + " good numbers in range up to 1 000 000 000.");
        Console.WriteLine("Calculation lasts for " + period);
        Console.ReadKey();
    }
}
