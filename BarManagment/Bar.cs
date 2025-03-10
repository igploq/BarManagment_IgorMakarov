public class Bar
{
    private List<Drink> drinks = new List<Drink>();

    public void AddDrink(Drink drink)
    {
        drinks.Add(drink);
        Console.WriteLine($"Successfully added '{drink.Name}' to menu!");
    }

    public void ShowMenu()
    {
        if (drinks.Count == 0)
        {
            Console.WriteLine("Menu is empty");
            return;
        }

        Console.WriteLine("\nBar menu:");
        for (int i = 0; i < drinks.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            drinks[i].DisplayInfo();
        }
    }

    public Drink OrderDrink(int index)
    {
        if (index < 1 || index > drinks.Count)
        {
            Console.WriteLine("Enter a correct index");
            return null;
        }
        return drinks[index - 1];
    }
}