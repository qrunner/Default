namespace Crossover.AMS.Contracts.Notification
{
    public interface INotificationMessage
    {
        long AccidentId { get; set; }

        string Title { get; set; }
    }
}