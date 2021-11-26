using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes
{
    internal class PotatoMealExample1 : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Peeling the potatoes");
            Console.WriteLine("Put the peeled potatoes on the fire");
            Console.WriteLine("Drain the rest of the water, knead the boiled potatoes in mashed potatoes");
            Console.WriteLine("Sprinkle puree with spices and herbs");
            Console.WriteLine("Mashed potatoes are ready");
        }
    }
    class PotatoMealExample2 : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Put the peeled potatoes on the fire");
            Console.WriteLine("Cook for about 30 minutes");
            Console.WriteLine("Drain the rest of the water, knead the boiled potatoes in mashed potatoes");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Sprinkle puree with spices and herbs");
            Console.WriteLine("Mashed potatoes are ready");
            Console.WriteLine();
        }

        protected override void Prepare()
        {
            Console.WriteLine("Peeling the potatoes");
        }
    }
}
