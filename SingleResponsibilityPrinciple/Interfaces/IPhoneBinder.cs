using SingleResponsibilityPrinciple.Classes;

namespace SingleResponsibilityPrinciple.Interfaces
{
    interface IPhoneBinder
    {
        Phone CreatePhone(string[] data);
    }
}
