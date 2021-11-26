using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Classes
{
    internal class VoiceMessage : IVoiceMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public byte[] Voice { get; set; }
        public void Send()
        {
            Console.WriteLine("Send voice message");
        }
    }
}
