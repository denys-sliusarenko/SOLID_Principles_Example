using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Interfaces
{
    internal interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }
}
