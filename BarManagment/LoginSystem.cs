using System;

public class LoginSystem
{
    public static User Login()
    {
        Console.WriteLine("Welcome to non-suspicous bar");
        Console.WriteLine("You are:");
        Console.WriteLine("1. Bartender");
        Console.WriteLine("2. Customer");

        string choice = Console.ReadLine();
        Console.Clear();
        Console.Write("Your name here: ");
        string name = Console.ReadLine();
        
        return choice == "1" ? new Bartender(name) : new Customer(name);

    }
}