using System.Collections.Generic;

namespace Crossover.AMS.Contracts.Notification
{
    public interface INotificationTask
    {
        INotificationMessage Message { get; }

        IEnumerable<INotificationResult> Status { get; }
    }
}