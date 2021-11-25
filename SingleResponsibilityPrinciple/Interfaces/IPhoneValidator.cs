using SingleResponsibilityPrinciple.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Interfaces
{
    internal interface IPhoneValidator
    {
        bool IsValid(Phone phone);
    }
}
