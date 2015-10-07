namespace Crossover.AMS.Contracts.Notification
{
    public interface IMailNotificationMessage : ITextNotificationMessage
    {
        string[] Attachments { get; set; }
    }
}
