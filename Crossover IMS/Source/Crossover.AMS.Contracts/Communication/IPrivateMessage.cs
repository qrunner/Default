namespace Crossover.AMS.Contracts.Communication
{
    /// <summary>
    /// Private message User-to-User
    /// </summary>
    public interface IPrivateMessage : IMessage
    {
        string RecipientSid { get; }

        bool Readed { get; }
    }
}