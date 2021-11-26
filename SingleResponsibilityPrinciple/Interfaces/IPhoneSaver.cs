using SingleResponsibilityPrinciple.Classes;

namespace SingleResponsibilityPrinciple.Interfaces
{
    internal interface IPhoneSaver
    {
        void Save(Phone phone, string fileName);
    }
}
