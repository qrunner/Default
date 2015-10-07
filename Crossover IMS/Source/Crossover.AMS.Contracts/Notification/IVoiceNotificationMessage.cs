namespace Crossover.AMS.Contracts.Notification
{
    public interface IVoiceNotificationMessage : INotificationMessage
    {
        string RecordLink { get; set; }
    }
}