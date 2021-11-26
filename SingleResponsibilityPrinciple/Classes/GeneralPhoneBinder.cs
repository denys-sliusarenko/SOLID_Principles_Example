using SingleResponsibilityPrinciple.Interfaces;

namespace SingleResponsibilityPrinciple.Classes
{
    internal class GeneralPhoneBinder : IPhoneBinder
    {
        public Phone CreatePhone(string[] data)
        {
            if (data.Length >= 2)
            {
                int price = 0;
                if (Int32.TryParse(data[1], out price))
                {
                    return new Phone { Model = data[0], Price = price };
                }
                else
                {
                    throw new Exception("Error binding model Phone. Incorrect data for property Price");
                }
            }
            else
            {
                throw new Exception("Error binding model Phone.");
            }
        }
    }
}
