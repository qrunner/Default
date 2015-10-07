namespace Crossover.AMS.Contracts.Notification
{
    public interface ITextNotificationMessage : INotificationMessage
    {
        string Text { get; set; }
    }
}
