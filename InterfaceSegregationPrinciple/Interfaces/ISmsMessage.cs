namespace InterfaceSegregationPrinciple.Interfaces
{
    internal interface ISmsMessage : IMessage
    {
        string Text { get; set; }
    }
}
