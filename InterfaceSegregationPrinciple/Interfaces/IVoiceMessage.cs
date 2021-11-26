namespace InterfaceSegregationPrinciple.Interfaces
{
    internal interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
}
