using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Classes
{
    internal class SmsMessage : ISmsMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public void Send()
        {
            Console.WriteLine("Send Sms message: {0}", Text);
        }
    }
}
