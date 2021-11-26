using SingleResponsibilityPrinciple.Interfaces;

namespace SingleResponsibilityPrinciple.Classes
{
    internal class ConsolePhoneReader : IPhoneReader
    {
        public string[] GetInputData()
        {
            Console.WriteLine("Input model:");
            string model = Console.ReadLine();
            Console.WriteLine("Input price:");
            string price = Console.ReadLine();
            return new string[] { model, price };
        }
    }
}
