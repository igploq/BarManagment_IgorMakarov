using static Drink;

public class CreateMix
{
    public static AlcoholicDrink CreateCocktail()
    {
        Console.Write("Add a name: ");
        string name = Console.ReadLine();

        int price;
        while (true)
        {
            Console.Write("Enter the price: ");
            if (int.TryParse(Console.ReadLine(), out price))
            {
                break; 
            }
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.Write("Add a base spirit (e.g. whiskey): ");
        string baseAlcohol = Console.ReadLine();

        Console.Write("Add an additional spirit (leave empty if not needed): ");
        string additionalAlcohol = Console.ReadLine();

        Console.Write("Add a flavour base (e.g. orange juice): ");
        string flavorBase = Console.ReadLine();

        var composition = new CocktailComposition(baseAlcohol, additionalAlcohol, flavorBase);
        return new AlcoholicDrink(name, price, composition);
    }
}