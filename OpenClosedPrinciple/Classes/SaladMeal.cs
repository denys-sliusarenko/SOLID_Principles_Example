using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes
{
    internal class SaladMealExample1 : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Chop tomatoes and cucumbers");
            Console.WriteLine("Sprinkle with herbs, salt and spices");
            Console.WriteLine("Sprinkle with sunflower oil");
            Console.WriteLine("Salad ready");
        }
    }

    internal class SaladMealExample2 : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Chop tomatoes and cucumbers");
            Console.WriteLine("Sprinkle with herbs, salt and spices");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Sprinkle with sunflower oil");
            Console.WriteLine("Salad ready");
            Console.WriteLine();
        }

        protected override void Prepare()
        {
            Console.WriteLine("Wash tomatoes and cucumbers");
        }
    }
}