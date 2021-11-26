using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes;

internal class CookExample1
{
    public string Name { get; set; }

    public CookExample1(string name)
    {
        this.Name = name;
    }

    public void MakeDinner(IMeal meal)
    {
        meal.Make();
    }
}
internal class CookExample2
{
    public string Name { get; set; }

    public CookExample2(string name )
    {
        this.Name = name;
    }

    public void MakeDinner(MealBase[] menu)
    {
        foreach (MealBase meal in menu)
            meal.Make();
    }
}

