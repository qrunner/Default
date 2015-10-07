namespace Crossover.AMS.Contracts.Communication
{
    /// <summary>
    /// Message to conferention
    /// </summary>
    public interface IConferenceMessage : IMessage
    {
        long ConferenceId { get; }
    }
}