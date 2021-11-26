namespace InterfaceSegregationPrinciple.Interfaces
{
    internal interface IEmailMessage : ISmsMessage
    {
        string Subject { get; set; }
    }
}
