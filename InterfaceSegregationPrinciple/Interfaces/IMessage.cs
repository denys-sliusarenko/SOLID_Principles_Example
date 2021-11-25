using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Interfaces
{
    internal interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}
