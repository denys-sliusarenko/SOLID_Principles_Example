using OpenClosedPrinciple.Classes;


Console.WriteLine("Open closed with strategy pattern");
Console.WriteLine();
CookExample1 bob = new CookExample1("Bob");
bob.MakeDinner(new PotatoMealExample1());
Console.WriteLine();
bob.MakeDinner(new SaladMealExample1());


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Open closed with template method pattern");
Console.WriteLine();
MealBase[] menu = new MealBase[] { new PotatoMealExample2(), new SaladMealExample2() };

CookExample2 bob2 = new ("Bob");
bob2.MakeDinner(menu);