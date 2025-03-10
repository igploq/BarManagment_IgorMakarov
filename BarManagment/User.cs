using System.ComponentModel;

public abstract class User
{
    public string Name { get; set; }

    protected User(string name)
    {
        Name = name;
    }

    public abstract void ShowOptions(Bar bar);
}

public class Bartender : User
{
    public Bartender(string name) : base(name) { }

    public override void ShowOptions(Bar bar)
    {


        Console.WriteLine("\n1. Add a non-alcholic drink");
        Console.WriteLine("2. Create a mix");
        Console.WriteLine("3. Show Bar menu");
        Console.WriteLine("4. Back to Login Screen");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Clear();
                Console.Write("Add a name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the price: ");
                if (int.TryParse(Console.ReadLine(), out int price))
                {
                    bar.AddDrink(new NonAlcoholicDrink(name, price));
                    Console.WriteLine("Drink added successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid price. Please enter a valid number.");
                }
                break;

            case "2":
                Console.Clear();
                AlcoholicDrink cocktail = CreateMix.CreateCocktail();
                bar.AddDrink(cocktail);
                break;
            case "3":
                Console.Clear();
                bar.ShowMenu();
                break;
            case "4":
                Console.Clear();
                return;
        }

        ShowOptions(bar);
    }
}        
    public class Customer : User
{
    public Customer(string name) : base(name) { }

    public override void ShowOptions(Bar bar)
    {
        
        Console.WriteLine("\n1. Show menu");
        Console.WriteLine("2. Order a drink");
        Console.WriteLine("3. Back to login screen");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Clear();
                bar.ShowMenu();
                break;
            case "2":
                Console.Clear();
                if (int.TryParse(Console.ReadLine(), out int order))
                {
                    Drink drink = bar.OrderDrink(order);
                    if (drink != null)
                    {
                        Console.WriteLine($"Successfully ordered: {drink.Name}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid drink number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                break;
            case "3":
                Console.Clear();
                return;
        }

        ShowOptions(bar);
    }
}
