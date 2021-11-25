using SingleResponsibilityPrinciple.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Interfaces
{
    interface IPhoneBinder
    {
        Phone CreatePhone(string[] data);
    }
}
