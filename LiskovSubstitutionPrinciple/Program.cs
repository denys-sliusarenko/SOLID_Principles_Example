using LiskovSubstitutionPrinciple.Classes;
using LiskovSubstitutionPrinciple.Interfaces;

List<IEmployee> list = new List<IEmployee>();

list.Add(new JuniorEmployee());
list.Add(new SeniorEmployee());

foreach (IEmployee emp in list)
{
    Console.WriteLine(emp.GetEmployeeDetails(985));
}