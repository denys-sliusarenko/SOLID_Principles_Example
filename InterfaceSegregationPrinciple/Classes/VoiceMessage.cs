using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
