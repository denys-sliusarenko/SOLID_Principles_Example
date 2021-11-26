namespace InterfaceSegregationPrinciple.Interfaces
{
    internal interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}
