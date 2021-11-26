using SingleResponsibilityPrinciple.Interfaces;

namespace SingleResponsibilityPrinciple.Classes
{
    internal class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone)
        {
            if (String.IsNullOrEmpty(phone.Model) || phone.Price <= 0)
                return false;

            return true;
        }
    }
}
