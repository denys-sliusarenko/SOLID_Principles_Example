﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Interfaces
{
    internal interface IEmailMessage : ISmsMessage
    {
        string Subject { get; set; }
    }
}
