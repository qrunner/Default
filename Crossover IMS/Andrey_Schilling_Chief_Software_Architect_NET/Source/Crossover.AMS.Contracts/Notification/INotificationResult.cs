namespace Crossover.AMS.Contracts.Notification
{
    public interface INotificationResult
    {
        NotificationState State { get; }

        IContact Contact { get; }

        string Description { get; }
    }
}