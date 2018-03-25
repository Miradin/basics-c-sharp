/*Zhigunov. Zadanie 4: Реализовать метод проверки логина и пароля. 
 * На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.. 
 */
using System;

class Program
{
    static bool Check(string login, string password)
    {
        bool yes = false;     
        if (login == "root" && password == "GeekBrains")
        {
            yes = true;
        }
        return yes;
    }
    static void Main(string[] args)
    {
        int i = 0;
        string login = "";
        string password = "";
        do
        {
            i++;
            Console.WriteLine("Enter Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            password = Console.ReadLine();
            if (Check(login, password) == true)
            {
                Console.WriteLine("Successfully loggen in.");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect login/password. You have " + (3-i)+" tries left");
            }
        }
        while (i < 3);

        Console.ReadKey();
    }
}
