public class CocktailComposition
{
    public string BaseAlcohol { get; set; }
    public string AdditionalAlcohol { get; set; } 
    public string FlavorBase { get; set; }

    public CocktailComposition(string baseAlcohol, string additionalAlcohol, string flavorBase)
    {
        BaseAlcohol = baseAlcohol;
        AdditionalAlcohol = additionalAlcohol;
        FlavorBase = flavorBase;
    }

    public override string ToString()
    {
        string additional = string.IsNullOrEmpty(AdditionalAlcohol) ? "No additionals" : AdditionalAlcohol;
        return $"Base: {BaseAlcohol}, Additional: {additional}, Flavour base: {FlavorBase}";
    }
}