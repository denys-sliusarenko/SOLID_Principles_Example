using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Classes
{
    internal class EmailMessage : IEmailMessage
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Send Email message: {0}", Text);
        }
    }
}
