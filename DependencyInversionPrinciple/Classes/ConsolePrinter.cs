using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Classes
{
    internal class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Printing to Console");
        }
    }
}
