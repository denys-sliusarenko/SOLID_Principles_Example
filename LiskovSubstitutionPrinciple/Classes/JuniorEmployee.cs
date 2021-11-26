using LiskovSubstitutionPrinciple.Interfaces;

namespace LiskovSubstitutionPrinciple.Classes
{
    internal class JuniorEmployee : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Junior Employee";
        }
    }
}
