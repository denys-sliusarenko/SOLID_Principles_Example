using SingleResponsibilityPrinciple.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Interfaces
{
    internal interface IPhoneSaver
    {
        void Save(Phone phone, string fileName);
    }
}
