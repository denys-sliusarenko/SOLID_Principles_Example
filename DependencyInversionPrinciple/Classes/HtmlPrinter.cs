using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Classes
{
    internal class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Print to html");
        }
    }
}
