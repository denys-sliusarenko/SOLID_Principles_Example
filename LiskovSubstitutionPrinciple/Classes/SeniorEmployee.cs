using LiskovSubstitutionPrinciple.Interfaces;

namespace LiskovSubstitutionPrinciple.Classes
{
    internal class SeniorEmployee : IWork, IEmployee
    {
        public string GetWorkDetails(int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Senior Employee";
        }
    }
}
