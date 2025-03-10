public abstract class Drink
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Drink(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();

    
}
public class NonAlcoholicDrink : Drink
{
    public NonAlcoholicDrink(string name, int price) : base(name, price) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($">Non-alcoholic< {Name} - {Price}$");
    }
}

public class AlcoholicDrink : Drink
{
    public CocktailComposition Composition { get; set; }

    public AlcoholicDrink(string name, int price, CocktailComposition composition)
        : base(name, price)
    {
        Composition = composition;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($">Cocktail< {Name} - {Price}$");
        Console.WriteLine(Composition);
    }
}